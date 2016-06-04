namespace ExileConfigurator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.itemName = new System.Windows.Forms.TextBox();
			this.itemNameLabel = new System.Windows.Forms.Label();
			this.itemClassNameLabel = new System.Windows.Forms.Label();
			this.itemClassName = new System.Windows.Forms.TextBox();
			this.itemMod = new System.Windows.Forms.ComboBox();
			this.itemModLabel = new System.Windows.Forms.Label();
			this.itemType = new System.Windows.Forms.ComboBox();
			this.itemTypeLabel = new System.Windows.Forms.Label();
			this.itemPrice = new System.Windows.Forms.NumericUpDown();
			this.itemPriceLabel = new System.Windows.Forms.Label();
			this.itemSave = new System.Windows.Forms.Button();
			this.itemList = new System.Windows.Forms.ListBox();
			this.itemQuality = new System.Windows.Forms.NumericUpDown();
			this.itemQualityLabel = new System.Windows.Forms.Label();
			this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
			this.exportVendor = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuExport});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(469, 24);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpen,
            this.fileSave,
            this.menuFileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			// 
			// fileOpen
			// 
			this.fileOpen.Name = "fileOpen";
			this.fileOpen.Size = new System.Drawing.Size(152, 22);
			this.fileOpen.Text = "&Open";
			this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
			// 
			// fileSave
			// 
			this.fileSave.Name = "fileSave";
			this.fileSave.Size = new System.Drawing.Size(152, 22);
			this.fileSave.Text = "&Save";
			this.fileSave.Click += new System.EventHandler(this.fileSave_Click);
			// 
			// menuFileExit
			// 
			this.menuFileExit.Name = "menuFileExit";
			this.menuFileExit.Size = new System.Drawing.Size(152, 22);
			this.menuFileExit.Text = "E&xit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// itemName
			// 
			this.itemName.Location = new System.Drawing.Point(194, 33);
			this.itemName.Name = "itemName";
			this.itemName.Size = new System.Drawing.Size(263, 20);
			this.itemName.TabIndex = 2;
			// 
			// itemNameLabel
			// 
			this.itemNameLabel.AutoSize = true;
			this.itemNameLabel.Location = new System.Drawing.Point(125, 36);
			this.itemNameLabel.Name = "itemNameLabel";
			this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
			this.itemNameLabel.TabIndex = 3;
			this.itemNameLabel.Text = "Item Name";
			// 
			// itemClassNameLabel
			// 
			this.itemClassNameLabel.AutoSize = true;
			this.itemClassNameLabel.Location = new System.Drawing.Point(125, 62);
			this.itemClassNameLabel.Name = "itemClassNameLabel";
			this.itemClassNameLabel.Size = new System.Drawing.Size(63, 13);
			this.itemClassNameLabel.TabIndex = 4;
			this.itemClassNameLabel.Text = "Class Name";
			// 
			// itemClassName
			// 
			this.itemClassName.Location = new System.Drawing.Point(194, 59);
			this.itemClassName.Name = "itemClassName";
			this.itemClassName.Size = new System.Drawing.Size(263, 20);
			this.itemClassName.TabIndex = 5;
			// 
			// itemMod
			// 
			this.itemMod.FormattingEnabled = true;
			this.itemMod.Location = new System.Drawing.Point(194, 85);
			this.itemMod.Name = "itemMod";
			this.itemMod.Size = new System.Drawing.Size(121, 21);
			this.itemMod.TabIndex = 6;
			// 
			// itemModLabel
			// 
			this.itemModLabel.AutoSize = true;
			this.itemModLabel.Location = new System.Drawing.Point(125, 88);
			this.itemModLabel.Name = "itemModLabel";
			this.itemModLabel.Size = new System.Drawing.Size(28, 13);
			this.itemModLabel.TabIndex = 7;
			this.itemModLabel.Text = "Mod";
			// 
			// itemType
			// 
			this.itemType.FormattingEnabled = true;
			this.itemType.Location = new System.Drawing.Point(194, 113);
			this.itemType.Name = "itemType";
			this.itemType.Size = new System.Drawing.Size(121, 21);
			this.itemType.TabIndex = 8;
			// 
			// itemTypeLabel
			// 
			this.itemTypeLabel.AutoSize = true;
			this.itemTypeLabel.Location = new System.Drawing.Point(125, 116);
			this.itemTypeLabel.Name = "itemTypeLabel";
			this.itemTypeLabel.Size = new System.Drawing.Size(31, 13);
			this.itemTypeLabel.TabIndex = 9;
			this.itemTypeLabel.Text = "Type";
			// 
			// itemPrice
			// 
			this.itemPrice.Location = new System.Drawing.Point(194, 141);
			this.itemPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.itemPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.itemPrice.Name = "itemPrice";
			this.itemPrice.Size = new System.Drawing.Size(120, 20);
			this.itemPrice.TabIndex = 10;
			this.itemPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemPriceLabel
			// 
			this.itemPriceLabel.AutoSize = true;
			this.itemPriceLabel.Location = new System.Drawing.Point(125, 143);
			this.itemPriceLabel.Name = "itemPriceLabel";
			this.itemPriceLabel.Size = new System.Drawing.Size(31, 13);
			this.itemPriceLabel.TabIndex = 11;
			this.itemPriceLabel.Text = "Price";
			// 
			// itemSave
			// 
			this.itemSave.Location = new System.Drawing.Point(240, 285);
			this.itemSave.Name = "itemSave";
			this.itemSave.Size = new System.Drawing.Size(75, 23);
			this.itemSave.TabIndex = 12;
			this.itemSave.Text = "Save";
			this.itemSave.UseVisualStyleBackColor = true;
			this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
			// 
			// itemList
			// 
			this.itemList.FormattingEnabled = true;
			this.itemList.Location = new System.Drawing.Point(13, 28);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(106, 329);
			this.itemList.TabIndex = 14;
			this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
			// 
			// itemQuality
			// 
			this.itemQuality.Location = new System.Drawing.Point(194, 167);
			this.itemQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.itemQuality.Name = "itemQuality";
			this.itemQuality.Size = new System.Drawing.Size(120, 20);
			this.itemQuality.TabIndex = 15;
			this.itemQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemQualityLabel
			// 
			this.itemQualityLabel.AutoSize = true;
			this.itemQualityLabel.Location = new System.Drawing.Point(125, 169);
			this.itemQualityLabel.Name = "itemQualityLabel";
			this.itemQualityLabel.Size = new System.Drawing.Size(39, 13);
			this.itemQualityLabel.TabIndex = 16;
			this.itemQualityLabel.Text = "Quality";
			// 
			// menuExport
			// 
			this.menuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportVendor});
			this.menuExport.Name = "menuExport";
			this.menuExport.Size = new System.Drawing.Size(52, 20);
			this.menuExport.Text = "&Export";
			// 
			// exportVendor
			// 
			this.exportVendor.Name = "exportVendor";
			this.exportVendor.Size = new System.Drawing.Size(152, 22);
			this.exportVendor.Text = "&Vendor List";
			this.exportVendor.Click += new System.EventHandler(this.exportVendor_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 375);
			this.Controls.Add(this.itemQualityLabel);
			this.Controls.Add(this.itemQuality);
			this.Controls.Add(this.itemList);
			this.Controls.Add(this.itemSave);
			this.Controls.Add(this.itemPriceLabel);
			this.Controls.Add(this.itemPrice);
			this.Controls.Add(this.itemTypeLabel);
			this.Controls.Add(this.itemType);
			this.Controls.Add(this.itemModLabel);
			this.Controls.Add(this.itemMod);
			this.Controls.Add(this.itemClassName);
			this.Controls.Add(this.itemClassNameLabel);
			this.Controls.Add(this.itemNameLabel);
			this.Controls.Add(this.itemName);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "Exile Configurator";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemQuality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.TextBox itemName;
		private System.Windows.Forms.Label itemNameLabel;
		private System.Windows.Forms.Label itemClassNameLabel;
		private System.Windows.Forms.TextBox itemClassName;
		private System.Windows.Forms.ComboBox itemMod;
		private System.Windows.Forms.Label itemModLabel;
		private System.Windows.Forms.ComboBox itemType;
		private System.Windows.Forms.Label itemTypeLabel;
		private System.Windows.Forms.NumericUpDown itemPrice;
		private System.Windows.Forms.Label itemPriceLabel;
		private System.Windows.Forms.Button itemSave;
		private System.Windows.Forms.ListBox itemList;
		private System.Windows.Forms.ToolStripMenuItem fileSave;
		private System.Windows.Forms.ToolStripMenuItem fileOpen;
		private System.Windows.Forms.NumericUpDown itemQuality;
		private System.Windows.Forms.Label itemQualityLabel;
		private System.Windows.Forms.ToolStripMenuItem menuExport;
		private System.Windows.Forms.ToolStripMenuItem exportVendor;
	}
}

