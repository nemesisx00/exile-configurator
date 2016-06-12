using ExileConfiguratorTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExileConfigurator.Data.Tests
{
	[TestClass()]
	public class ItemTests : AbstractItemTest
	{
		[TestMethod()]
		public void EqualsIdTest_item()
		{
			var item = generateItem();
			var item2 = generateItem();
			item2.Id = item2.Id.ToUpper();

			Assert.IsTrue(item.EqualsId(item2));
		}

		[TestMethod()]
		public void EqualsIdTest_string()
		{
			var item = generateItem();
			var id = item.Id.ToUpper();

			Assert.IsTrue(item.EqualsId(id));
		}
	}
}