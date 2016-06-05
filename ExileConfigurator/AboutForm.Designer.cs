namespace ExileConfigurator
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.aboutAuthor = new System.Windows.Forms.Label();
			this.aboutProjectLink = new System.Windows.Forms.LinkLabel();
			this.aboutLicense = new System.Windows.Forms.RichTextBox();
			this.aboutVersion = new System.Windows.Forms.Label();
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
			this.aboutProjectLink.Location = new System.Drawing.Point(523, 9);
			this.aboutProjectLink.Name = "aboutProjectLink";
			this.aboutProjectLink.Size = new System.Drawing.Size(149, 15);
			this.aboutProjectLink.TabIndex = 4;
			this.aboutProjectLink.TabStop = true;
			this.aboutProjectLink.Text = "Source Code on BitBucket";
			this.aboutProjectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutProjectLink_LinkClicked);
			// 
			// aboutLicense
			// 
			this.aboutLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutLicense.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.aboutLicense.Cursor = System.Windows.Forms.Cursors.Default;
			this.aboutLicense.Location = new System.Drawing.Point(15, 57);
			this.aboutLicense.Name = "aboutLicense";
			this.aboutLicense.ReadOnly = true;
			this.aboutLicense.ShortcutsEnabled = false;
			this.aboutLicense.Size = new System.Drawing.Size(657, 262);
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
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 331);
			this.Controls.Add(this.aboutVersion);
			this.Controls.Add(this.aboutLicense);
			this.Controls.Add(this.aboutProjectLink);
			this.Controls.Add(this.aboutAuthor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 370);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 250);
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.Text = "About Exile Configurator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label aboutAuthor;
		private System.Windows.Forms.LinkLabel aboutProjectLink;
		private System.Windows.Forms.RichTextBox aboutLicense;
		private System.Windows.Forms.Label aboutVersion;
	}
}