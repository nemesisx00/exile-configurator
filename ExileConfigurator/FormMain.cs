using ExileConfigurator.Data;
using ExileConfigurator.IO;
using ExileConfigurator.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExileConfigurator
{
	public partial class FormMain : Form
    {
		private const string RegexSplitCapitals = "((?<=\\p{Ll})\\p{Lu}|\\p{Lu}(?=\\p{Ll}))";

		private string currentFilePath;
		private DuplicateDetector detector;
		private List<string> mods;
		private List<string> types;

        public FormMain()
        {
            InitializeComponent();

			this.Text += " " + ConfigurationManager.AppSettings["version"];

			currentFilePath = string.Empty;
			detector = new DuplicateDetector();
			mods = new List<string>();
			types = new List<string>();

			var rgx = new Regex(RegexSplitCapitals);
			var itemTypes = ConfigurationManager.AppSettings["itemTypes"];
			if(!String.Empty.Equals(itemTypes))
			{
				var split = itemTypes.Split(new char[] { ';' });
				foreach(var it in split)
				{
					types.Add(rgx.Replace(it, " $1").Trim());
				}
			}

			itemMod.DataSource = mods;
			itemType.DataSource = types;

			clearItemFields();
			itemList.refreshList();

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
		private void updateItem(Item item, string mod, string type, string className, int price, int quality)
		{
			updateModList(mod);
			updateTypeList(type);

			item.Mod = mod;
			item.Type = type;
			item.Id = className;
			item.Price = price;
			item.Quality = quality;
		}

		private void loadItem(Item item)
		{
			itemClassName.Text = item.Id;
			itemMod.Text = item.Mod;
			itemType.Text = item.Type;
			itemPrice.Value = item.Price;
			itemQuality.Value = item.Quality;
		}

		private void saveCurrentItem(string id)
		{
			var item = itemList.getItemById(id);
			if (item != null)
			{
				updateItem(item, itemMod.Text, itemType.Text, id, (int)itemPrice.Value, (int)itemQuality.Value);
			}
			else
			{
				item = new Item();
				updateItem(item, itemMod.Text, itemType.Text, id, (int)itemPrice.Value, (int)itemQuality.Value);
				itemList.addItem(item);
			}

			clearItemFields();
			itemList.refreshList();
		}

		private void removeCurrentItem(string id)
		{
			var item = itemList.getItemById(id);
			if(item != null)
			{
				itemList.removeItem(item);
				clearItemFields();
			}
		}

		private void clearItemFields()
		{
			itemClassName.Text = String.Empty;
			itemMod.Text = String.Empty;
			itemType.Text = String.Empty;
			itemPrice.Value = 0;
			itemQuality.Value = 0;
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
			string filePath = FileUtil.saveFileDialog();
			if(!String.Empty.Equals(filePath))
			{
				currentFilePath = filePath;
				saveListToFile(filePath);
			}
		}

		private void saveListToFile(string filePath)
		{
			var items = itemList.getList();
			if(items.Count > 0)
			{
				if(!String.Empty.Equals(filePath))
				{
					var s = new Serializer<List<Item>>();
					var output = s.toJson(items);
					FileUtil.writeFile(output, filePath);
				}
			}
		}

		private void loadListFromFile()
		{
			string filePath = FileUtil.readFileDialog();
			var json = FileUtil.readFileFull(filePath);
			if(!String.Empty.Equals(json))
			{
				currentFilePath = filePath;

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

					refreshModsList();
					refreshTypesList();
					itemList.addItems(list);
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
			if(currentFilePath == null || String.Empty.Equals(currentFilePath))
				saveListToFile();
			else
				saveListToFile(currentFilePath);
		}

		private void fileSaveAs_Click(object sender, EventArgs e)
		{
			saveListToFile();
		}

		private void menuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void exportVendor_Click(object sender, EventArgs e)
		{
			string filePath = FileUtil.saveFileDialog(FileUtil.DefaultFileNameExportVendor, FileUtil.FileDialogFilterTextFiles);
			if(!String.Empty.Equals(filePath))
			{
				var vf = new VendorFormatter();
				var output = vf.formatAllList(itemList.getList());

				FileUtil.writeFile(output, filePath);
			}
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
			itemList.CurrentFilter = itemListSearch.Text;
			itemList.refreshList();
		}

		private void itemList_Click(object sender, EventArgs e)
		{
			string id = itemList.GetItemText(itemList.SelectedItem);
			var item = itemList.getItemById(id);
			if(item != null)
				loadItem(item);
		}

		private void itemList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string id = itemList.GetItemText(itemList.SelectedItem);
			var item = itemList.getItemById(id);
			if (item != null)
				loadItem(item);
		}

		private void itemNew_Click(object sender, EventArgs e)
		{
			clearItemFields();
			itemClassName.Focus();
		}

		private void itemSave_Click(object sender, EventArgs e)
		{
			string id = itemClassName.Text;

			if (string.Empty.Equals(id))
				MessageBox.Show("Class Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				saveCurrentItem(id);
		}

		private void itemRemove_Click(object sender, EventArgs e)
		{
			var response = MessageBox.Show("Are you sure you want to remove this item?", "Remove Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(response == DialogResult.Yes)
			{
				string id = itemClassName.Text;
				removeCurrentItem(id);
			}
		}

		#endregion

		#endregion
	}
}
