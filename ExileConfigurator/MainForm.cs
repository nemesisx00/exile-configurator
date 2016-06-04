using ExileConfigurator.Data;
using ExileConfigurator.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExileConfigurator
{
	public partial class MainForm : Form
    {
		Dictionary<string, Item> items;

        public MainForm()
        {
            InitializeComponent();

			items = new Dictionary<string, Item>();

			var il = new List<Item>();
			il.AddRange(items.Values);
			itemList.DataSource = il;
			itemList.DisplayMember = "Name";
			itemList.ValueMember = "Name";
			itemMod.DataSource = Enum.GetValues(typeof(Mod));
			itemType.DataSource = Enum.GetValues(typeof(ItemType));
		}

		/// <summary>
		/// Convenience method to update the contents of an Item instance.
		/// </summary>
		/// <param name="item">The item to be updated</param>
		/// <param name="mod"></param>
		/// <param name="type"></param>
		/// <param name="name"></param>
		/// <param name="className"></param>
		/// <param name="price"></param>
		private void updateItem(Item item, Mod mod, ItemType type, string name, string className, int price)
		{
			item.Mod = mod;
			item.Type = type;
			item.Name = name;
			item.ClassName = className;
			item.Price = price;
		}

		private void loadItem(Item item)
		{
			itemName.Text = item.Name;
			itemClassName.Text = item.ClassName;
			itemMod.SelectedValue = item.Mod;
			itemType.SelectedValue = item.Type;
			itemPrice.Value = item.Price;
		}

		private Mod getMod()
		{
			Mod mod;
			Enum.TryParse<Mod>(itemMod.SelectedValue.ToString(), out mod);
			return mod;
		}

		private ItemType getType()
		{
			ItemType type;
			Enum.TryParse<ItemType>(itemType.SelectedValue.ToString(), out type);
			return type;
		}

		private void menuFileTest_Click(object sender, EventArgs e)
		{
			var il = new List<Item>();
			il.AddRange(items.Values);

			var s = new Serializer<List<Item>>();
			string json = s.serialize(il);
			
			testText.Text = json;
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void itemSave_Click(object sender, EventArgs e)
		{
			string name = itemName.Text;

			if(!items.ContainsKey(name))
			{
				var i = new Item();
				updateItem(i, getMod(), getType(), name, itemClassName.Text, (int)itemPrice.Value);

				items.Add(i.Name, i);

				itemList.DataSource = null;
				var il = new List<Item>();
				il.AddRange(items.Values);
				itemList.DataSource = il;
			}
			else
			{
				Item i;
				items.TryGetValue(name, out i);

				if(i != null)
					updateItem(i, getMod(), getType(), name, itemClassName.Text, (int)itemPrice.Value);
			}
		}

		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = itemList.GetItemText(itemList.SelectedItem);
			Item i;
			items.TryGetValue(name, out i);

			if(i != null)
				loadItem(i);
		}
	}
}
