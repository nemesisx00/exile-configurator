using ExileConfigurator.Data;
using ExileConfigurator.IO;
using ExileConfigurator.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExileConfigurator
{
	public partial class FormMain : Form
    {
		private const string RegexSplitCapitals = "((?<=\\p{Ll})\\p{Lu}|\\p{Lu}(?=\\p{Ll}))";

		private DuplicateDetector detector;
		private List<Item> items;
		private List<Item> listItems;
		private List<string> mods;
		private List<string> types;

        public FormMain()
        {
            InitializeComponent();

			this.Text += " " + ConfigurationManager.AppSettings["version"];

			detector = new DuplicateDetector();
			items = new List<Item>();
			listItems = new List<Item>();
			mods = new List<string>();
			types = new List<string>();

			var rgx = new Regex(RegexSplitCapitals);
			foreach(ItemType it in Enum.GetValues(typeof(ItemType)))
			{
				types.Add(rgx.Replace(it.ToString(), " $1").Trim());
			}

			itemMod.DataSource = mods;
			itemType.DataSource = types;

			clearItemFields();
			refreshList();

			attachEventListeners();
		}

		#region Private Methods

		/// <summary>
		/// 
		/// </summary>
		/// <param name="mod"></param>
		private void updateModList(string mod)
		{
			if(!mods.Contains(mod))
			{
				mods.Add(mod);
				refreshModsList();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		private void updateTypeList(string type)
		{
			if(!types.Contains(type))
			{
				types.Add(type);
				refreshTypesList();
			}
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
		private void updateItem(Item item, string mod, string type, string name, string className, int price, int quality)
		{
			updateModList(mod);
			updateTypeList(type);

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
			itemMod.Text = item.Mod;
			itemType.Text = item.Type;
			itemPrice.Value = item.Price;
			itemQuality.Value = item.Quality;
		}

		private void saveCurrentItem(string id)
		{
			var item = detector.detect(items, id);
			if (item != null)
			{
				updateItem(item, itemMod.Text, itemType.Text, itemName.Text, id, (int)itemPrice.Value, (int)itemQuality.Value);
			}
			else
			{
				item = new Item();
				updateItem(item, itemMod.Text, itemType.Text, itemName.Text, id, (int)itemPrice.Value, (int)itemQuality.Value);
				items.Add(item);
			}

			clearItemFields();
			updateList(items);
			refreshList();
		}

		private void removeCurrentItem(string label)
		{
			var item = items.FirstOrDefault(o => o.Label == label);
			if(item != null)
			{
				items.Remove(item);
				clearItemFields();
				updateList(items);
				refreshList();
			}
		}

		private void clearItemFields()
		{
			itemName.Text = string.Empty;
			itemClassName.Text = string.Empty;
			itemMod.Text = string.Empty;
			itemType.Text = string.Empty;
			itemPrice.Value = 0;
			itemQuality.Value = 0;
		}

		private void updateList(List<Item> il)
		{
			if(il != null)
				listItems = il;
		}

		private void refreshList()
		{
			listItems = listItems.OrderBy(o => o.Mod).ThenBy(o => o.Type).ThenBy(o => o.Label).ToList();

			fileSave.Enabled = listItems.Count > 0;
			itemList.DataSource = null;
			itemList.DataSource = listItems;
		}

		private void refreshModsList()
		{
			mods.Sort();

			itemMod.DataSource = null;
			itemMod.DataSource = mods;
		}

		private void refreshTypesList()
		{
			types.Sort();
			
			itemType.DataSource = null;
			itemType.DataSource = types;
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

				if(list != null && list.Count > 0)
				{
					foreach(var i in list)
					{
						if(!mods.Contains(i.Mod))
							mods.Add(i.Mod);
						if(!types.Contains(i.Type))
							types.Add(i.Type);
					}
					
					items = detector.cleanDuplicates(list);

					updateList(items);
					refreshModsList();
					refreshTypesList();
					refreshList();
				}
			}
		}
		#endregion

		#region Event Handlers

		/// <summary>
		/// 
		/// </summary>
		private void attachEventListeners()
		{
			itemListSearch.TextChanged += itemListSearch_TextChanged;
			itemList.Click += itemList_Click;
		}

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
			var about = new FormAbout();
			about.Show();
		}

		private void helpReportIssue_Click(object sender, EventArgs e)
		{
			var supportUrl = ConfigurationManager.AppSettings["supportUrl"];
			Process.Start(supportUrl);
		}
		#endregion

		#region Controls
		private void itemListSearch_TextChanged(object sender, EventArgs e)
		{
			if(itemListSearch.Text.Length > 0)
			{
				List<Item> filtered = items.FindAll(delegate (Item i) { return i.Label.ToLower().Contains(itemListSearch.Text.ToLower()); }).ToList();
				updateList(filtered);
			}
			else
				updateList(items);

			refreshList();
		}

		private void itemList_Click(object sender, EventArgs e)
		{
			string name = itemList.GetItemText(itemList.SelectedItem);
			var item = items.FirstOrDefault(o => o.Label == name);
			if(item != null)
				loadItem(item);
		}

		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string id = itemList.GetItemText(itemList.SelectedItem);
			var item = detector.detect(items, id);
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
