using ExileConfigurator.Data;
using System.Collections.Generic;

namespace ExileConfiguratorTests
{
	public abstract class AbstractItemTest
	{
		protected Item generateItem()
		{
			var item = new Item("Test", "Item", "test_item", 10, 1);
			return item;
		}

		protected List<Item> generateList()
		{
			var items = new List<Item>();
			var item = generateItem();
			item.Id += "_2";
			items.Add(item);

			items.Add(generateItem());

			return items;
		}
	}
}
