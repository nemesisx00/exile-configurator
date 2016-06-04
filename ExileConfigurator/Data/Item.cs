namespace ExileConfigurator.Data
{
	public class Item
	{
		public Mod Mod { get; set; }
		public ItemType Type { get; set; }
		public string Id { get; set; }
		public string Label { get; set; }
		public int Price { get; set; }
		public int Quality { get; set; }

		public override string ToString() { return Label; }
	}
}
