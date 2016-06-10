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
			if(needle == null)
				return null;

			var obj = haystack.Find(o => o.Id.ToLower().Equals(needle.Id.ToLower()));
			return obj;
		}
		
		public List<Item> cleanDuplicates(List<Item> list)
		{
			var clean = new List<Item>();
			foreach(var i in list)
			{
				if(clean.Find(o => o.Id.ToLower().Equals(i.Id.ToLower())) == null)
					clean.Add(i);
			}
			return clean;
		}
	}
}
