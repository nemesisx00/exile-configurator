using ExileConfigurator.Data;
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
		private const string FormatClassName = "class {0}	{{ quality = {1}; price = {2}; }};";

		public string formatList(List<Item> items)
		{
			var sorted = items.OrderBy(o => o.Mod).ThenBy(o => o.Type).ToList();

			string output = "";
			Mod currentMod = Mod.HLC;
			ItemType currentType = ItemType.Handgun;
			string groupLabel = string.Empty;
			foreach (var i in sorted)
			{
				if (currentMod != i.Mod)
					currentMod = i.Mod;
				if (currentType != i.Type)
					currentType = i.Type;
				
				var temp = string.Format("{0} {1}", currentMod.ToString(), currentType.ToString());
				if (!groupLabel.Equals(temp))
				{
					groupLabel = temp;
					output += Environment.NewLine + string.Format(FormatGroupComment, groupLabel) + Environment.NewLine;
				}

				var line = string.Format(FormatClassName, i.Id, i.Quality, i.Price);
				output += line + Environment.NewLine;
			}

			return output;
		}
	}
}
