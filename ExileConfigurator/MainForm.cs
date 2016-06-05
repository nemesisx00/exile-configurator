using ExileConfigurator.Data;
using ExileConfigurator.IO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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

			this.Text += " " + ConfigurationManager.AppSettings["version"];

			items = new List<Item>();
			
			itemMod.DataSource = Enum.GetValues(typeof(Mod));
			itemType.DataSource = Enum.GetValues(typeof(ItemType));

			clearItemFields();
			refreshList();
		}

		#region Private Methods
		/// <summary>
		/// Convenience method to update the contents of an Item instance.
		/// </summary>
		/// <param name="item">The item to be updated</param>
		/// <param name="mod"></param>
		/// <param name="type"></param>
		/// <param name="name"></param>
		/// <param name="className"></param>
		/// <param name="price"></param>
		private void updateItem(Item item, Mod mod, ItemType type, string name, string className, int price, int quality)
		{
			item.Mod = mod;
			item.Type = type;
			item.Label = name;
			item.Id = className;
			item.Price = price;
			item.Quality = quality;
		}

		private void loadItem(Item item)
		{
			itemName.Text = item.Label;
			itemClassName.Text = item.Id;
			itemMod.SelectedItem = item.Mod;
			itemType.SelectedItem = item.Type;
			itemPrice.Value = item.Price;
			itemQuality.Value = item.Quality;
		}

		private void saveCurrentItem(string label)
		{
			var item = items.FirstOrDefault(o => o.Label == label);
			if (item != null)
			{
				updateItem(item, getMod(), getType(), label, itemClassName.Text, (int)itemPrice.Value, (int)itemQuality.Value);
			}
			else
			{
				item = new Item();
				updateItem(item, getMod(), getType(), label, itemClassName.Text, (int)itemPrice.Value, (int)itemQuality.Value);
				items.Add(item);
				refreshList();
			}
		}

		private void removeCurrentItem(string label)
		{
			var item = items.FirstOrDefault(o => o.Label == label);
			if(item != null)
			{
				items.Remove(item);
				clearItemFields();
				refreshList();
			}
		}

		private void clearItemFields()
		{
			itemName.Text = string.Empty;
			itemClassName.Text = string.Empty;
			itemMod.SelectedItem = null;
			itemType.SelectedItem = null;
			itemPrice.Value = 0;
			itemQuality.Value = 0;
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

		private void refreshList()
		{
			items = items.OrderBy(o => o.Mod).ThenBy(o => o.Type).ThenBy(o => o.Label).ToList();

			fileSave.Enabled = items.Count > 0;
			itemList.DataSource = null;
			itemList.DataSource = items;
		}

		private void saveListToFile()
		{
			if(items.Count > 0)
			{
				var s = new Serializer<List<Item>>();
				var output = s.toJson(items);
				FileUtil.writeFileDialog(output);
			}
		}

		private void loadListFromFile()
		{
			var json = FileUtil.readFileDialog();
			if(json != null && !string.Empty.Equals(json))
			{
				var s = new Serializer<List<Item>>();
				var list = s.fromJson(json);
				if (list != null && list.Count > 0)
				{
					items = list;
					refreshList();
				}
			}
		}
		#endregion

		#region Event Handlers

		#region Menu Items
		private void fileOpen_Click(object sender, EventArgs e)
		{
			loadListFromFile();
		}

		private void fileSave_Click(object sender, EventArgs e)
		{
			saveListToFile();
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void exportVendor_Click(object sender, EventArgs e)
		{
			var vf = new VendorFormatter();
			string output = vf.formatClassList(items);
			output += Environment.NewLine + Environment.NewLine;
			output += vf.formatVendorList(items);

			FileUtil.writeFileDialog(output, FileUtil.DefaultFileNameExportVendor, FileUtil.FileDialogFilterTextFiles);
		}

		private void helpAbout_Click(object sender, EventArgs e)
		{
			var about = new AboutForm();
			about.Show();
		}

		private void helpReportIssue_Click(object sender, EventArgs e)
		{
			var supportUrl = ConfigurationManager.AppSettings["supportUrl"];
			Process.Start(supportUrl);
		}
		#endregion

		#region Controls
		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = itemList.GetItemText(itemList.SelectedItem);
			var item = items.FirstOrDefault(o => o.Label == name);
			if (item != null)
				loadItem(item);
		}

		private void itemNew_Click(object sender, EventArgs e)
		{
			clearItemFields();
			itemName.Focus();
		}

		private void itemSave_Click(object sender, EventArgs e)
		{
			string label = itemName.Text;
			string id = itemClassName.Text;

			if (string.Empty.Equals(label))
				MessageBox.Show("Item Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (string.Empty.Equals(id))
				MessageBox.Show("Class Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				saveCurrentItem(label);
		}

		private void itemRemove_Click(object sender, EventArgs e)
		{
			var response = MessageBox.Show("Are you sure you want to remove this item?", "Remove Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(response == DialogResult.Yes)
			{
				string label = itemName.Text;
				removeCurrentItem(label);
			}
		}
		#endregion

		#endregion
	}
}
