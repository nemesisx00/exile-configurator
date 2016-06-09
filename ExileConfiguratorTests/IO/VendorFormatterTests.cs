using ExileConfigurator.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExileConfigurator.IO.Tests
{
	[TestClass()]
	public class VendorFormatterTests
	{
		private const string expectedClassString = @"
///////////////////////////////////////////////////////////////////////////////
// Test - Item
///////////////////////////////////////////////////////////////////////////////
class test_myitem_1	{ quality = 1; price = 25; };
class test_myitem_2	{ quality = 2; price = 50; };
";

		private const string expectedVendorString = @"class TestItem
{
	name = ""Test - Item"";
	icon = ""a3\ui_f\data\gui\Rsc\RscDisplayArsenal\itemacc_ca.paa"";
	items[] =
	{
		""test_myitem_1"",
		""test_myitem_2""
	};
};

";

		private List<Item> generateItemList()
		{
			var items = new List<Item>();
			var item = new Item("Test", "Item", "test_myitem_1", "My Test Item 1", 25, 1);
			items.Add(item);

			item = new Item("Test", "Item", "test_myitem_2", "My Test Item 2", 50, 2);
			items.Add(item);

			return items;
		}

		[TestMethod()]
		public void formatClassListTest()
		{
			var items = generateItemList();
			var instance = new VendorFormatter();

			var result = instance.formatClassList(items);

			Assert.AreEqual(expectedClassString, result);
		}

		[TestMethod()]
		public void formatVendorListTest()
		{
			var items = generateItemList();
			var instance = new VendorFormatter();

			var result = instance.formatVendorList(items);

			Assert.AreEqual(expectedVendorString, result);
		}
	}
}