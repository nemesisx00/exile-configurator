namespace ExileConfigurator
{
    partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
			this.exportVendor = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
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
			this.itemNew = new System.Windows.Forms.Button();
			this.itemRemove = new System.Windows.Forms.Button();
			this.itemListSearch = new System.Windows.Forms.TextBox();
			this.itemListSearchLabel = new System.Windows.Forms.Label();
			this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuExport,
            this.menuHelp});
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
            this.fileSaveAs,
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
			this.exportVendor.Size = new System.Drawing.Size(132, 22);
			this.exportVendor.Text = "&Vendor List";
			this.exportVendor.Click += new System.EventHandler(this.exportVendor_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbout,
            this.toolStripSeparator1,
            this.helpReportIssue});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 20);
			this.menuHelp.Text = "&Help";
			// 
			// helpAbout
			// 
			this.helpAbout.Name = "helpAbout";
			this.helpAbout.Size = new System.Drawing.Size(204, 22);
			this.helpAbout.Text = "&About Exile Configurator";
			this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
			// 
			// helpReportIssue
			// 
			this.helpReportIssue.Name = "helpReportIssue";
			this.helpReportIssue.Size = new System.Drawing.Size(204, 22);
			this.helpReportIssue.Text = "Report Issue";
			this.helpReportIssue.Click += new System.EventHandler(this.helpReportIssue_Click);
			// 
			// itemName
			// 
			this.itemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemName.Location = new System.Drawing.Point(278, 28);
			this.itemName.Name = "itemName";
			this.itemName.Size = new System.Drawing.Size(179, 20);
			this.itemName.TabIndex = 1;
			// 
			// itemNameLabel
			// 
			this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemNameLabel.AutoSize = true;
			this.itemNameLabel.Location = new System.Drawing.Point(209, 31);
			this.itemNameLabel.Name = "itemNameLabel";
			this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
			this.itemNameLabel.TabIndex = 3;
			this.itemNameLabel.Text = "Item Name";
			// 
			// itemClassNameLabel
			// 
			this.itemClassNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemClassNameLabel.AutoSize = true;
			this.itemClassNameLabel.Location = new System.Drawing.Point(209, 57);
			this.itemClassNameLabel.Name = "itemClassNameLabel";
			this.itemClassNameLabel.Size = new System.Drawing.Size(63, 13);
			this.itemClassNameLabel.TabIndex = 4;
			this.itemClassNameLabel.Text = "Class Name";
			// 
			// itemClassName
			// 
			this.itemClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemClassName.Location = new System.Drawing.Point(278, 54);
			this.itemClassName.Name = "itemClassName";
			this.itemClassName.Size = new System.Drawing.Size(179, 20);
			this.itemClassName.TabIndex = 2;
			// 
			// itemMod
			// 
			this.itemMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemMod.FormattingEnabled = true;
			this.itemMod.Location = new System.Drawing.Point(278, 80);
			this.itemMod.Name = "itemMod";
			this.itemMod.Size = new System.Drawing.Size(179, 21);
			this.itemMod.TabIndex = 3;
			// 
			// itemModLabel
			// 
			this.itemModLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemModLabel.AutoSize = true;
			this.itemModLabel.Location = new System.Drawing.Point(209, 83);
			this.itemModLabel.Name = "itemModLabel";
			this.itemModLabel.Size = new System.Drawing.Size(28, 13);
			this.itemModLabel.TabIndex = 7;
			this.itemModLabel.Text = "Mod";
			// 
			// itemType
			// 
			this.itemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemType.FormattingEnabled = true;
			this.itemType.Location = new System.Drawing.Point(278, 108);
			this.itemType.Name = "itemType";
			this.itemType.Size = new System.Drawing.Size(179, 21);
			this.itemType.TabIndex = 4;
			// 
			// itemTypeLabel
			// 
			this.itemTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemTypeLabel.AutoSize = true;
			this.itemTypeLabel.Location = new System.Drawing.Point(209, 111);
			this.itemTypeLabel.Name = "itemTypeLabel";
			this.itemTypeLabel.Size = new System.Drawing.Size(31, 13);
			this.itemTypeLabel.TabIndex = 9;
			this.itemTypeLabel.Text = "Type";
			// 
			// itemPrice
			// 
			this.itemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemPrice.Location = new System.Drawing.Point(278, 136);
			this.itemPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.itemPrice.Name = "itemPrice";
			this.itemPrice.Size = new System.Drawing.Size(178, 20);
			this.itemPrice.TabIndex = 5;
			this.itemPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemPriceLabel
			// 
			this.itemPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemPriceLabel.AutoSize = true;
			this.itemPriceLabel.Location = new System.Drawing.Point(209, 138);
			this.itemPriceLabel.Name = "itemPriceLabel";
			this.itemPriceLabel.Size = new System.Drawing.Size(31, 13);
			this.itemPriceLabel.TabIndex = 11;
			this.itemPriceLabel.Text = "Price";
			// 
			// itemSave
			// 
			this.itemSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.itemSave.Location = new System.Drawing.Point(301, 188);
			this.itemSave.Name = "itemSave";
			this.itemSave.Size = new System.Drawing.Size(75, 23);
			this.itemSave.TabIndex = 7;
			this.itemSave.Text = "Save";
			this.itemSave.UseVisualStyleBackColor = true;
			this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
			// 
			// itemList
			// 
			this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemList.FormattingEnabled = true;
			this.itemList.Location = new System.Drawing.Point(13, 54);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(190, 160);
			this.itemList.TabIndex = 8;
			this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
			// 
			// itemQuality
			// 
			this.itemQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemQuality.Location = new System.Drawing.Point(278, 162);
			this.itemQuality.Name = "itemQuality";
			this.itemQuality.Size = new System.Drawing.Size(178, 20);
			this.itemQuality.TabIndex = 6;
			this.itemQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemQualityLabel
			// 
			this.itemQualityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemQualityLabel.AutoSize = true;
			this.itemQualityLabel.Location = new System.Drawing.Point(209, 164);
			this.itemQualityLabel.Name = "itemQualityLabel";
			this.itemQualityLabel.Size = new System.Drawing.Size(39, 13);
			this.itemQualityLabel.TabIndex = 16;
			this.itemQualityLabel.Text = "Quality";
			// 
			// itemNew
			// 
			this.itemNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.itemNew.Location = new System.Drawing.Point(220, 188);
			this.itemNew.Name = "itemNew";
			this.itemNew.Size = new System.Drawing.Size(75, 23);
			this.itemNew.TabIndex = 17;
			this.itemNew.Text = "New";
			this.itemNew.UseVisualStyleBackColor = true;
			this.itemNew.Click += new System.EventHandler(this.itemNew_Click);
			// 
			// itemRemove
			// 
			this.itemRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.itemRemove.Location = new System.Drawing.Point(382, 188);
			this.itemRemove.Name = "itemRemove";
			this.itemRemove.Size = new System.Drawing.Size(75, 23);
			this.itemRemove.TabIndex = 18;
			this.itemRemove.Text = "Remove";
			this.itemRemove.UseVisualStyleBackColor = true;
			this.itemRemove.Click += new System.EventHandler(this.itemRemove_Click);
			// 
			// itemListSearch
			// 
			this.itemListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemListSearch.Location = new System.Drawing.Point(62, 27);
			this.itemListSearch.Name = "itemListSearch";
			this.itemListSearch.Size = new System.Drawing.Size(141, 20);
			this.itemListSearch.TabIndex = 19;
			// 
			// itemListSearchLabel
			// 
			this.itemListSearchLabel.AutoSize = true;
			this.itemListSearchLabel.Location = new System.Drawing.Point(12, 30);
			this.itemListSearchLabel.Name = "itemListSearchLabel";
			this.itemListSearchLabel.Size = new System.Drawing.Size(44, 13);
			this.itemListSearchLabel.TabIndex = 20;
			this.itemListSearchLabel.Text = "Search:";
			// 
			// fileSaveAs
			// 
			this.fileSaveAs.Name = "fileSaveAs";
			this.fileSaveAs.Size = new System.Drawing.Size(152, 22);
			this.fileSaveAs.Text = "Save As...";
			this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 226);
			this.Controls.Add(this.itemListSearchLabel);
			this.Controls.Add(this.itemListSearch);
			this.Controls.Add(this.itemRemove);
			this.Controls.Add(this.itemNew);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(485, 265);
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
		private System.Windows.Forms.Button itemNew;
		private System.Windows.Forms.Button itemRemove;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem helpAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem helpReportIssue;
		private System.Windows.Forms.TextBox itemListSearch;
		private System.Windows.Forms.Label itemListSearchLabel;
		private System.Windows.Forms.ToolStripMenuItem fileSaveAs;
	}
}

