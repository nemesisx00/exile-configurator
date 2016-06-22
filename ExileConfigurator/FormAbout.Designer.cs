namespace ExileConfigurator
{
	partial class FormAbout
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.aboutAuthor = new System.Windows.Forms.Label();
			this.aboutProjectLink = new System.Windows.Forms.LinkLabel();
			this.aboutLicense = new System.Windows.Forms.RichTextBox();
			this.aboutVersion = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.aboutJsonNetLicense = new System.Windows.Forms.RichTextBox();
			this.aboutJsonNetLink = new System.Windows.Forms.LinkLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// aboutAuthor
			// 
			this.aboutAuthor.AutoSize = true;
			this.aboutAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutAuthor.Location = new System.Drawing.Point(12, 9);
			this.aboutAuthor.Name = "aboutAuthor";
			this.aboutAuthor.Size = new System.Drawing.Size(225, 15);
			this.aboutAuthor.TabIndex = 1;
			this.aboutAuthor.Text = "Author: Peter Lunneberg (Nemesis X00)";
			// 
			// aboutProjectLink
			// 
			this.aboutProjectLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutProjectLink.AutoSize = true;
			this.aboutProjectLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutProjectLink.Location = new System.Drawing.Point(497, 9);
			this.aboutProjectLink.Name = "aboutProjectLink";
			this.aboutProjectLink.Size = new System.Drawing.Size(175, 15);
			this.aboutProjectLink.TabIndex = 4;
			this.aboutProjectLink.TabStop = true;
			this.aboutProjectLink.Text = "Exile Configurator on BitBucket";
			this.aboutProjectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutProjectLink_LinkClicked);
			// 
			// aboutLicense
			// 
			this.aboutLicense.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.aboutLicense.Cursor = System.Windows.Forms.Cursors.Default;
			this.aboutLicense.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aboutLicense.Location = new System.Drawing.Point(3, 3);
			this.aboutLicense.Name = "aboutLicense";
			this.aboutLicense.ReadOnly = true;
			this.aboutLicense.ShortcutsEnabled = false;
			this.aboutLicense.Size = new System.Drawing.Size(643, 236);
			this.aboutLicense.TabIndex = 6;
			this.aboutLicense.Text = resources.GetString("aboutLicense.Text");
			// 
			// aboutVersion
			// 
			this.aboutVersion.AutoSize = true;
			this.aboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutVersion.Location = new System.Drawing.Point(12, 24);
			this.aboutVersion.Name = "aboutVersion";
			this.aboutVersion.Size = new System.Drawing.Size(51, 15);
			this.aboutVersion.TabIndex = 7;
			this.aboutVersion.Text = "Version:";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(15, 49);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(657, 270);
			this.tabControl1.TabIndex = 8;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.aboutLicense);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(649, 242);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "License";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.aboutJsonNetLicense);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(649, 242);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Json.NET License";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// aboutJsonNetLicense
			// 
			this.aboutJsonNetLicense.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.aboutJsonNetLicense.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aboutJsonNetLicense.Location = new System.Drawing.Point(3, 3);
			this.aboutJsonNetLicense.Name = "aboutJsonNetLicense";
			this.aboutJsonNetLicense.ReadOnly = true;
			this.aboutJsonNetLicense.Size = new System.Drawing.Size(643, 236);
			this.aboutJsonNetLicense.TabIndex = 0;
			this.aboutJsonNetLicense.Text = resources.GetString("aboutJsonNetLicense.Text");
			// 
			// aboutJsonNetLink
			// 
			this.aboutJsonNetLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutJsonNetLink.AutoSize = true;
			this.aboutJsonNetLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutJsonNetLink.Location = new System.Drawing.Point(548, 31);
			this.aboutJsonNetLink.Name = "aboutJsonNetLink";
			this.aboutJsonNetLink.Size = new System.Drawing.Size(124, 15);
			this.aboutJsonNetLink.TabIndex = 9;
			this.aboutJsonNetLink.TabStop = true;
			this.aboutJsonNetLink.Text = "Newtonsoft Json.NET";
			this.aboutJsonNetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutJsonNetLink_LinkClicked);
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 331);
			this.Controls.Add(this.aboutJsonNetLink);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.aboutVersion);
			this.Controls.Add(this.aboutProjectLink);
			this.Controls.Add(this.aboutAuthor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 370);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 250);
			this.Name = "FormAbout";
			this.ShowIcon = false;
			this.Text = "About Exile Configurator";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label aboutAuthor;
		private System.Windows.Forms.LinkLabel aboutProjectLink;
		private System.Windows.Forms.RichTextBox aboutLicense;
		private System.Windows.Forms.Label aboutVersion;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox aboutJsonNetLicense;
		private System.Windows.Forms.LinkLabel aboutJsonNetLink;
	}
}