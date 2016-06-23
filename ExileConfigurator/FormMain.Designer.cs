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
			this.fileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
			this.exportVendor = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpReportIssue = new System.Windows.Forms.ToolStripMenuItem();
			this.itemClassNameLabel = new System.Windows.Forms.Label();
			this.itemClassName = new System.Windows.Forms.TextBox();
			this.itemMod = new System.Windows.Forms.ComboBox();
			this.itemModLabel = new System.Windows.Forms.Label();
			this.itemType = new System.Windows.Forms.ComboBox();
			this.itemTypeLabel = new System.Windows.Forms.Label();
			this.itemPrice = new System.Windows.Forms.NumericUpDown();
			this.itemPriceLabel = new System.Windows.Forms.Label();
			this.itemSave = new System.Windows.Forms.Button();
			this.itemQuality = new System.Windows.Forms.NumericUpDown();
			this.itemQualityLabel = new System.Windows.Forms.Label();
			this.itemNew = new System.Windows.Forms.Button();
			this.itemRemove = new System.Windows.Forms.Button();
			this.itemListSearch = new System.Windows.Forms.TextBox();
			this.itemListSearchLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.itemDescriptionLabel = new System.Windows.Forms.Label();
			this.itemDescription = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.itemList = new ExileConfigurator.UI.ItemList();
			this.mainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemQuality)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.mainMenu.Size = new System.Drawing.Size(674, 24);
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
			// fileSaveAs
			// 
			this.fileSaveAs.Name = "fileSaveAs";
			this.fileSaveAs.Size = new System.Drawing.Size(152, 22);
			this.fileSaveAs.Text = "Save As...";
			this.fileSaveAs.Click += new System.EventHandler(this.fileSaveAs_Click);
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
			// itemClassNameLabel
			// 
			this.itemClassNameLabel.AutoSize = true;
			this.itemClassNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemClassNameLabel.Location = new System.Drawing.Point(3, 0);
			this.itemClassNameLabel.Name = "itemClassNameLabel";
			this.itemClassNameLabel.Size = new System.Drawing.Size(63, 26);
			this.itemClassNameLabel.TabIndex = 4;
			this.itemClassNameLabel.Text = "Class Name";
			this.itemClassNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemClassName
			// 
			this.itemClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemClassName.Location = new System.Drawing.Point(72, 3);
			this.itemClassName.Name = "itemClassName";
			this.itemClassName.Size = new System.Drawing.Size(270, 20);
			this.itemClassName.TabIndex = 2;
			// 
			// itemMod
			// 
			this.itemMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemMod.FormattingEnabled = true;
			this.itemMod.Location = new System.Drawing.Point(72, 29);
			this.itemMod.Name = "itemMod";
			this.itemMod.Size = new System.Drawing.Size(270, 21);
			this.itemMod.TabIndex = 3;
			// 
			// itemModLabel
			// 
			this.itemModLabel.AutoSize = true;
			this.itemModLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemModLabel.Location = new System.Drawing.Point(3, 26);
			this.itemModLabel.Name = "itemModLabel";
			this.itemModLabel.Size = new System.Drawing.Size(63, 27);
			this.itemModLabel.TabIndex = 7;
			this.itemModLabel.Text = "Mod";
			this.itemModLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemType
			// 
			this.itemType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemType.FormattingEnabled = true;
			this.itemType.Location = new System.Drawing.Point(72, 56);
			this.itemType.Name = "itemType";
			this.itemType.Size = new System.Drawing.Size(270, 21);
			this.itemType.TabIndex = 4;
			// 
			// itemTypeLabel
			// 
			this.itemTypeLabel.AutoSize = true;
			this.itemTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemTypeLabel.Location = new System.Drawing.Point(3, 53);
			this.itemTypeLabel.Name = "itemTypeLabel";
			this.itemTypeLabel.Size = new System.Drawing.Size(63, 27);
			this.itemTypeLabel.TabIndex = 9;
			this.itemTypeLabel.Text = "Type";
			this.itemTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemPrice
			// 
			this.itemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemPrice.Location = new System.Drawing.Point(72, 83);
			this.itemPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.itemPrice.Name = "itemPrice";
			this.itemPrice.Size = new System.Drawing.Size(270, 20);
			this.itemPrice.TabIndex = 5;
			this.itemPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemPriceLabel
			// 
			this.itemPriceLabel.AutoSize = true;
			this.itemPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemPriceLabel.Location = new System.Drawing.Point(3, 80);
			this.itemPriceLabel.Name = "itemPriceLabel";
			this.itemPriceLabel.Size = new System.Drawing.Size(63, 26);
			this.itemPriceLabel.TabIndex = 11;
			this.itemPriceLabel.Text = "Price";
			this.itemPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemSave
			// 
			this.itemSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.itemSave.Location = new System.Drawing.Point(389, 253);
			this.itemSave.Name = "itemSave";
			this.itemSave.Size = new System.Drawing.Size(75, 23);
			this.itemSave.TabIndex = 7;
			this.itemSave.Text = "Save";
			this.itemSave.UseVisualStyleBackColor = true;
			this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
			// 
			// itemQuality
			// 
			this.itemQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemQuality.Location = new System.Drawing.Point(72, 109);
			this.itemQuality.Name = "itemQuality";
			this.itemQuality.Size = new System.Drawing.Size(270, 20);
			this.itemQuality.TabIndex = 6;
			this.itemQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// itemQualityLabel
			// 
			this.itemQualityLabel.AutoSize = true;
			this.itemQualityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemQualityLabel.Location = new System.Drawing.Point(3, 106);
			this.itemQualityLabel.Name = "itemQualityLabel";
			this.itemQualityLabel.Size = new System.Drawing.Size(63, 26);
			this.itemQualityLabel.TabIndex = 16;
			this.itemQualityLabel.Text = "Quality";
			this.itemQualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemNew
			// 
			this.itemNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.itemNew.Location = new System.Drawing.Point(506, 253);
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
			this.itemRemove.Location = new System.Drawing.Point(587, 253);
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
			this.itemListSearch.Location = new System.Drawing.Point(53, 3);
			this.itemListSearch.Name = "itemListSearch";
			this.itemListSearch.Size = new System.Drawing.Size(244, 20);
			this.itemListSearch.TabIndex = 19;
			// 
			// itemListSearchLabel
			// 
			this.itemListSearchLabel.AutoSize = true;
			this.itemListSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemListSearchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.itemListSearchLabel.Location = new System.Drawing.Point(3, 0);
			this.itemListSearchLabel.Name = "itemListSearchLabel";
			this.itemListSearchLabel.Size = new System.Drawing.Size(44, 25);
			this.itemListSearchLabel.TabIndex = 20;
			this.itemListSearchLabel.Text = "Search:";
			this.itemListSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Controls.Add(this.itemClassNameLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.itemClassName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.itemModLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.itemMod, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.itemType, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.itemTypeLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.itemQuality, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.itemQualityLabel, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.itemPriceLabel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.itemPrice, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.itemDescriptionLabel, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.itemDescription, 1, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(317, 27);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 220);
			this.tableLayoutPanel1.TabIndex = 22;
			// 
			// itemDescriptionLabel
			// 
			this.itemDescriptionLabel.AutoSize = true;
			this.itemDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemDescriptionLabel.Location = new System.Drawing.Point(3, 132);
			this.itemDescriptionLabel.Name = "itemDescriptionLabel";
			this.itemDescriptionLabel.Size = new System.Drawing.Size(63, 88);
			this.itemDescriptionLabel.TabIndex = 17;
			this.itemDescriptionLabel.Text = "Description";
			this.itemDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// itemDescription
			// 
			this.itemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.itemDescription.Location = new System.Drawing.Point(72, 135);
			this.itemDescription.Multiline = true;
			this.itemDescription.Name = "itemDescription";
			this.itemDescription.Size = new System.Drawing.Size(270, 82);
			this.itemDescription.TabIndex = 18;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.itemListSearchLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.itemListSearch, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.itemList, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 27);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 249);
			this.tableLayoutPanel2.TabIndex = 23;
			// 
			// itemList
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.itemList, 2);
			this.itemList.CurrentFilter = null;
			this.itemList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemList.FormattingEnabled = true;
			this.itemList.Location = new System.Drawing.Point(3, 28);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(294, 218);
			this.itemList.TabIndex = 21;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 288);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.itemRemove);
			this.Controls.Add(this.itemNew);
			this.Controls.Add(this.itemSave);
			this.Controls.Add(this.mainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mainMenu;
			this.MinimumSize = new System.Drawing.Size(690, 327);
			this.Name = "FormMain";
			this.Text = "Exile Configurator";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemQuality)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuFileExit;
		private System.Windows.Forms.Label itemClassNameLabel;
		private System.Windows.Forms.TextBox itemClassName;
		private System.Windows.Forms.ComboBox itemMod;
		private System.Windows.Forms.Label itemModLabel;
		private System.Windows.Forms.ComboBox itemType;
		private System.Windows.Forms.Label itemTypeLabel;
		private System.Windows.Forms.NumericUpDown itemPrice;
		private System.Windows.Forms.Label itemPriceLabel;
		private System.Windows.Forms.Button itemSave;
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
		private UI.ItemList itemList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label itemDescriptionLabel;
		private System.Windows.Forms.TextBox itemDescription;
	}
}

