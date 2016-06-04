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
			this.aboutAuthorLabel = new System.Windows.Forms.Label();
			this.aboutAuthor = new System.Windows.Forms.Label();
			this.aboutLicense = new System.Windows.Forms.TextBox();
			this.aboutProjectLinkLabel = new System.Windows.Forms.Label();
			this.aboutProjectLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// aboutAuthorLabel
			// 
			this.aboutAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutAuthorLabel.AutoSize = true;
			this.aboutAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutAuthorLabel.Location = new System.Drawing.Point(12, 9);
			this.aboutAuthorLabel.Name = "aboutAuthorLabel";
			this.aboutAuthorLabel.Size = new System.Drawing.Size(80, 15);
			this.aboutAuthorLabel.TabIndex = 0;
			this.aboutAuthorLabel.Text = "Created By:";
			// 
			// aboutAuthor
			// 
			this.aboutAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutAuthor.AutoSize = true;
			this.aboutAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutAuthor.Location = new System.Drawing.Point(111, 9);
			this.aboutAuthor.Name = "aboutAuthor";
			this.aboutAuthor.Size = new System.Drawing.Size(182, 15);
			this.aboutAuthor.TabIndex = 1;
			this.aboutAuthor.Text = "Peter \'Nemesis X00\' Lunneberg";
			// 
			// aboutLicense
			// 
			this.aboutLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutLicense.Location = new System.Drawing.Point(12, 69);
			this.aboutLicense.Multiline = true;
			this.aboutLicense.Name = "aboutLicense";
			this.aboutLicense.ReadOnly = true;
			this.aboutLicense.Size = new System.Drawing.Size(394, 155);
			this.aboutLicense.TabIndex = 2;
			this.aboutLicense.Text = resources.GetString("aboutLicense.Text");
			// 
			// aboutProjectLinkLabel
			// 
			this.aboutProjectLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.aboutProjectLinkLabel.AutoSize = true;
			this.aboutProjectLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutProjectLinkLabel.Location = new System.Drawing.Point(12, 34);
			this.aboutProjectLinkLabel.Name = "aboutProjectLinkLabel";
			this.aboutProjectLinkLabel.Size = new System.Drawing.Size(93, 15);
			this.aboutProjectLinkLabel.TabIndex = 3;
			this.aboutProjectLinkLabel.Text = "Source Code:";
			// 
			// aboutProjectLink
			// 
			this.aboutProjectLink.AutoSize = true;
			this.aboutProjectLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutProjectLink.Location = new System.Drawing.Point(111, 34);
			this.aboutProjectLink.Name = "aboutProjectLink";
			this.aboutProjectLink.Size = new System.Drawing.Size(280, 15);
			this.aboutProjectLink.TabIndex = 4;
			this.aboutProjectLink.TabStop = true;
			this.aboutProjectLink.Text = "https://bitbucket.org/nemesisx00/exile-configurator";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 236);
			this.Controls.Add(this.aboutProjectLink);
			this.Controls.Add(this.aboutProjectLinkLabel);
			this.Controls.Add(this.aboutLicense);
			this.Controls.Add(this.aboutAuthor);
			this.Controls.Add(this.aboutAuthorLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.Text = "AboutForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label aboutAuthorLabel;
		private System.Windows.Forms.Label aboutAuthor;
		private System.Windows.Forms.TextBox aboutLicense;
		private System.Windows.Forms.Label aboutProjectLinkLabel;
		private System.Windows.Forms.LinkLabel aboutProjectLink;
	}
}