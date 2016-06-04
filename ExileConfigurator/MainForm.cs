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
		List<Item> items;

        public MainForm()
        {
            InitializeComponent();

			items = new List<Item>();
			
			itemList.DataSource = items;
			itemList.ValueMember = "Label";
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
			item.Label = name;
			item.Id = className;
			item.Price = price;
		}

		private void loadItem(Item item)
		{
			itemName.Text = item.Label;
			itemClassName.Text = item.Id;
			itemMod.SelectedItem = item.Mod;
			itemType.SelectedItem = item.Type;
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
			var s = new Serializer<List<Item>>();
			string json = s.serialize(items);
			
			testText.Text = json;
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void itemSave_Click(object sender, EventArgs e)
		{
			string name = itemName.Text;

			var item = items.FirstOrDefault(o => o.Label == name);
			if(item != null)
			{
				updateItem(item, getMod(), getType(), name, itemClassName.Text, (int)itemPrice.Value);
			}
			else
			{
				item = new Item();
				updateItem(item, getMod(), getType(), name, itemClassName.Text, (int)itemPrice.Value);

				items.Add(item);

				itemList.DataSource = null;
				itemList.DataSource = items;
			}
		}

		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = itemList.GetItemText(itemList.SelectedItem);
			var item = items.FirstOrDefault(o => o.Label == name);
			if (item != null)
				loadItem(item);
		}
	}
}
