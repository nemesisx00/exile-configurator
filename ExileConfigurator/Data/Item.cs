namespace ExileConfigurator.Data
{
	public class Item
	{
		public string Mod { get; set; }
		public string Type { get; set; }
		public string Id { get; set; }
		public string Label { get; set; }
		public int Price { get; set; }
		public int Quality { get; set; }

		public override string ToString() { return Label; }
	}
}
