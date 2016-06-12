using ExileConfigurator.Data;
using ExileConfigurator.Util;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExileConfigurator.UI
{
	public class ItemList : ListBox
	{
		private DuplicateDetector detector;
		private List<Item> items;

		public string CurrentFilter { get; set; }

		public ItemList()
		{
			detector = new DuplicateDetector();
			items = new List<Item>();
		}

		public List<Item> getList()
		{
			cleanList();
			orderList();
			return items;
		}

		public List<Item> getFilteredList(string filter)
		{
			if(filter == null)
				return items;

			List<Item> filtered = items.FindAll(o => o.Id.ToLower().Contains(filter.ToLower()))
										.ToList();
			return filtered;
		}

		public Item getItemById(string id)
		{
			return detector.detect(items, id);
		}

		public void addItem(Item i)
		{
			items.Add(i);
			refreshList();
		}

		public void addItems(List<Item> il)
		{
			items.AddRange(il);
			refreshList();
		}

		public void removeItem(Item i)
		{
			var selected = SelectedItem;
			var selectedIndex = items.IndexOf((Item)selected);
			items.Remove(i);
			refreshList();

			if(i.Equals(selected))
			{
				if(selectedIndex > 0)
					selected = items.ElementAt(selectedIndex - 1);
				else
					selected = null;
			}
			SelectedItem = selected;
		}
		
		public void refreshList()
		{
			cleanList();
			orderList();

			var temp = items;
			if(!string.Empty.Equals(CurrentFilter))
				temp = getFilteredList(CurrentFilter);

			var selected = SelectedItem;
			DataSource = null;
			DataSource = temp;
			SelectedItem = selected;
		}

		private void cleanList()
		{
			items = detector.cleanDuplicates(items);
		}

		private void orderList()
		{
			items = items.OrderBy(o => o.Mod)
						.ThenBy(o => o.Type)
						.ThenBy(o => o.Id)
					.ToList();
		}
	}
}
