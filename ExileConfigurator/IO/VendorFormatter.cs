using ExileConfigurator.Data;
using ExileConfigurator.Util;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public string formatClassList(List<Item> items)
		{
			var detector = new DuplicateDetector();
			var cleaned = detector.cleanDuplicates(items);
			var sorted = sortItems(cleaned);

			string output = "";
			string groupLabel = string.Empty;
			foreach(var i in sorted)
			{
				if(!groupLabel.Equals(i.getGroupString()))
				{
					groupLabel = i.getGroupString();
					output += Environment.NewLine + string.Format(FormatGroupComment, groupLabel) + Environment.NewLine;
				}

				var line = i.getClassString();
				output += line + Environment.NewLine;
			}

			return output;
		}

		public string formatVendorList(List<Item> items)
		{
			var detector = new DuplicateDetector();
			var cleaned = detector.cleanDuplicates(items);
			var sorted = sortItems(cleaned);

			string output = "";
			var groupLists = new Dictionary<string, List<string>>();
			
			string groupLabel = string.Empty;
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

			foreach(var key in groupLists.Keys)
			{
				List<string> ids = groupLists[key];

				string idList = string.Empty;
				foreach(var id in ids)
				{
					if(idList.Length > 0)
						idList += ",\r\n\t\t";
					idList += string.Format(FormatClassName, id);
				}
				
				output += string.Format(FormatGroupString, key.Replace("-", "").Replace(" ", ""), key, idList) + Environment.NewLine + Environment.NewLine;
			}

			return output;
		}

		private List<Item> sortItems(List<Item> items)
		{
			var sorted = items.OrderBy(o => o.Mod).ThenBy(o => o.Type).ToList();
			return sorted;
		}
	}
}
