using ExileConfigurator.Data;
using ExileConfigurator.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExileConfigurator.IO
{
	/// <summary>
	/// Class for use in serializing the item list into the necessary format for the vendor list, in mpmissions/Exile.[Altis|Namalsk]/config.cpp
	/// </summary>
	public class VendorFormatter
	{
		private const string FormatGroupComment = "///////////////////////////////////////////////////////////////////////////////\r\n// {0}\r\n///////////////////////////////////////////////////////////////////////////////";
		private const string FormatGroupString = "class {0}\r\n{{\r\n\tname = \"{1}\";\r\n\ticon = \"a3\\ui_f\\data\\gui\\Rsc\\RscDisplayArsenal\\itemacc_ca.paa\";\r\n\titems[] =\r\n\t{{\r\n\t\t{2}\r\n\t}};\r\n}};";
		private const string FormatClassName = "\"{0}\"";

		public string formatAllList(List<Item> items) { return formatAllList(items, true); }
		public string formatAllList(List<Item> items, bool clean)
		{
			var sb = new StringBuilder();

			List<Item> itemList;
			if(clean)
				itemList = cleanList(items);
			else
				itemList = sortItems(items);

			sb.Append(formatClassList(items, false));
			sb.Append(formatVendorList(items, false));
			sb.Append(formatGroupList(items, false));

			return sb.ToString();
		}

		public string formatClassList(List<Item> items) { return formatClassList(items, true); }
		public string formatClassList(List<Item> items, bool clean)
		{
			List<Item> sorted = null;
			if(clean)
				sorted = cleanList(items);
			else
				sorted = sortItems(items);

			var sb = new StringBuilder();
			string groupLabel = String.Empty;
			foreach(var i in sorted)
			{
				if(!groupLabel.Equals(i.getGroupString()))
				{
					groupLabel = i.getGroupString();
					sb.AppendLine();
					sb.AppendLine(String.Format(FormatGroupComment, groupLabel));
				}
				sb.AppendLine(i.getClassString());
			}

			return sb.ToString();
		}

		public string formatGroupList(List<Item> items) { return formatGroupList(items, true); }
		public string formatGroupList(List<Item> items, bool clean)
		{
			List<Item> sorted = null;
			if(clean)
				sorted = cleanList(items);
			else
				sorted = sortItems(items);

			var sb = new StringBuilder();
			string groupLabel = String.Empty;
			foreach(var i in sorted)
			{
				if(!groupLabel.Equals(i.getGroupString()))
				{
					groupLabel = i.getGroupString();

					if(sb.Length > 0)
						sb.AppendLine(",");
					sb.AppendFormat(FormatClassName, groupLabel.Replace("-", "").Replace(" ", ""));
				}
			}

			return sb.ToString();
		}

		public string formatVendorList(List<Item> items) { return formatVendorList(items, true); }
		public string formatVendorList(List<Item> items, bool clean)
		{
			List<Item> sorted = null;
			if(clean)
				sorted = cleanList(items);
			else
				sorted = sortItems(items);
			
			var groupLists = new Dictionary<string, List<string>>();
			string groupLabel = String.Empty;
			foreach(var i in sorted)
			{
				if(!groupLabel.Equals(i.getGroupString()))
				{
					groupLabel = i.getGroupString();
					if(!groupLists.ContainsKey(groupLabel))
						groupLists.Add(groupLabel, new List<string>());
				}

				groupLists[groupLabel].Add(i.Id);
			}

			var sb = new StringBuilder();
			foreach(var key in groupLists.Keys)
			{
				List<string> ids = groupLists[key];

				var idList = new StringBuilder();
				foreach(var id in ids)
				{
					if(idList.Length > 0)
					{
						idList.AppendLine(",");
						idList.Append("\t\t");
					}
					idList.AppendFormat(FormatClassName, id);
				}

				sb.AppendFormat(FormatGroupString, key.Replace("-", "").Replace(" ", ""), key, idList);
				sb.AppendLine();
				sb.AppendLine();
			}

			return sb.ToString();
		}

		private List<Item> cleanList(List<Item> items)
		{
			var detector = new DuplicateDetector();
			var cleaned = detector.cleanDuplicates(items);
			var sorted = sortItems(cleaned);

			return sorted;
		}

		private List<Item> sortItems(List<Item> items)
		{
			var sorted = items.OrderBy(o => o.Mod).ThenBy(o => o.Type).ToList();
			return sorted;
		}
	}
}
