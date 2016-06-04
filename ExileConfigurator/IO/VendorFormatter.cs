using ExileConfigurator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExileConfigurator.IO
{
	/// <summary>
	/// Class for use in serializing the item list into the necessary format for the vendor list, in mpmissions/Exile.[Altis|Namalsk]/config.cpp
	/// </summary>
	public class VendorFormatter
	{
		private const string RegexSplitCapitals = "((?<=\\p{Ll})\\p{Lu}|\\p{Lu}(?=\\p{Ll}))";
		private const string FormatGroupComment = "///////////////////////////////////////////////////////////////////////////////\r\n// {0}\r\n///////////////////////////////////////////////////////////////////////////////";
		private const string FormatClassString = "class {0}	{{ quality = {1}; price = {2}; }};";
		private const string FormatGroupString = "class {0}\r\n{{\r\n\tname = \"{1}\";\r\n\ticon = \"a3\\ui_f\\data\\gui\\Rsc\\RscDisplayArsenal\\itemacc_ca.paa\";\r\n\titems[] =\r\n\t{{\r\n\t\t{2}\r\n\t}};\r\n}};";
		private const string FormatClassName = "\"{0}\"";

		public string formatClassList(List<Item> items)
		{
			var sorted = sortItems(items);

			string output = "";
			Mod currentMod = Mod.HLC;
			ItemType currentType = ItemType.Handgun;
			string groupLabel = string.Empty;
			foreach(var i in sorted)
			{
				if(currentMod != i.Mod)
					currentMod = i.Mod;
				if(currentType != i.Type)
					currentType = i.Type;

				var temp = string.Format("{0} {1}", currentMod.ToString(), currentType.ToString());
				if(!groupLabel.Equals(temp))
				{
					groupLabel = temp;
					output += Environment.NewLine + string.Format(FormatGroupComment, groupLabel) + Environment.NewLine;
				}

				var line = string.Format(FormatClassString, i.Id, i.Quality, i.Price);
				output += line + Environment.NewLine;
			}

			return output;
		}

		public string formatVendorList(List<Item> items)
		{
			var sorted = sortItems(items);

			string output = "";
			var groupLists = new Dictionary<string, List<string>>();

			Mod currentMod = Mod.HLC;
			ItemType currentType = ItemType.Handgun;
			string groupLabel = string.Empty;
			foreach(var i in sorted)
			{
				if(currentMod != i.Mod)
					currentMod = i.Mod;
				if(currentType != i.Type)
					currentType = i.Type;

				var groupName = string.Format("{0}{1}", currentMod.ToString(), currentType.ToString());
				if(!groupLists.ContainsKey(groupName))
					groupLists.Add(groupName, new List<string>());

				groupLists[groupName].Add(i.Id);
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

				var rgx = new Regex(RegexSplitCapitals);
				output += string.Format(FormatGroupString, key, rgx.Replace(key, " $1").Trim(), idList) + Environment.NewLine + Environment.NewLine;
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
