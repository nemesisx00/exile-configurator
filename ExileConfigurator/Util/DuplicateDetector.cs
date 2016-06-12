using ExileConfigurator.Data;
using System.Collections.Generic;

namespace ExileConfigurator.Util
{
	public class DuplicateDetector
	{
		public Item detect(List<Item> haystack, string idNeedle)
		{
			var obj = haystack.Find(o => o.EqualsId(idNeedle));
			return obj;
		}

		public Item detect(List<Item> haystack, Item needle)
		{
			if(needle == null)
				return null;

			var obj = haystack.Find(o => o.EqualsId(needle));
			return obj;
		}
		
		public List<Item> cleanDuplicates(List<Item> list)
		{
			var clean = new List<Item>();
			foreach(var i in list)
			{
				if(!clean.Exists(o => o.EqualsId(i)))
					clean.Add(i);
			}
			return clean;
		}
	}
}
