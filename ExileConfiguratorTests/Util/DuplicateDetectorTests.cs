using ExileConfigurator.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExileConfigurator.Util.Tests
{
	[TestClass()]
	public class DuplicateDetectorTests
	{

		private Item generateItem()
		{
			var item = new Item("Test", "Item", "test_item", "Test Item", 10, 1);
			return item;
		}

		private List<Item> generateList()
		{
			var items = new List<Item>();
			var item = generateItem();
			item.Id += "_2";
			items.Add(item);

			item = generateItem();
			items.Add(item);

			return items;
		}

		[TestMethod()]
		public void detectTest_success()
		{
			var items = generateList();
			var item = generateItem();

			var instance = new DuplicateDetector();
			var expected = generateItem();
			var result = instance.detect(items, item);

			Assert.AreEqual(expected, result);
		}

		[TestMethod()]
		public void detectTest_failure()
		{
			var items = generateList();
			var item = generateItem();
			item.Id += "_3";

			var instance = new DuplicateDetector();
			var expected = generateItem();
			var result = instance.detect(items, item);

			Assert.AreNotEqual(expected, result);
		}
	}
}