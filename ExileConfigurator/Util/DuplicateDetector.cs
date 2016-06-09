using ExileConfigurator.Data;
using System;
using System.Collections.Generic;

namespace ExileConfigurator.Util
{
	public class DuplicateDetector
	{
		public Item detect(List<Item> haystack, string idNeedle)
		{
			var obj = haystack.Find(o => o.Id.Equals(idNeedle));
			return obj;
		}

		public Item detect(List<Item> haystack, Item needle)
		{
			var obj = haystack.Find(o => o.CompareTo(needle) == 0);
			return obj;
		}
		
		public List<Item> cleanDuplicates(List<Item> list)
		{
			var clean = new List<Item>();
			foreach(var obj in list)
			{
				if(!clean.Contains(obj))
					clean.Add(obj);
			}
			return clean;
		}
	}
}
