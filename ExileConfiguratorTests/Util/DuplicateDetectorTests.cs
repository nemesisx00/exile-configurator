using ExileConfigurator.Data;
using ExileConfiguratorTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ExileConfigurator.Util.Tests
{
	[TestClass()]
	public class DuplicateDetectorTests : AbstractItemTest
	{
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

		[TestMethod()]
		public void cleanDuplicatesTest()
		{
			var items = new List<Item>();
			items.Add(generateItem());
			items.Add(generateItem());
			items.Add(generateItem());
			items.Add(generateItem());

			var expected = new List<Item>();
			items.Add(generateItem());

			var instance = new DuplicateDetector();
			var result = instance.cleanDuplicates(items);

			int expectedCount = 1;
			Assert.AreEqual(expectedCount, result.Count);
		}
	}
}