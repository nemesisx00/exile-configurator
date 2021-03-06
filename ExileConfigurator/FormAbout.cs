using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExileConfigurator
{
	public partial class FormAbout : Form
	{
		private const string JsonNetUrl = "http://www.newtonsoft.com/json";

		public FormAbout()
		{
			InitializeComponent();

			aboutVersion.Text += " " + ConfigurationManager.AppSettings["version"];
			aboutLicense.SelectionChanged += new System.EventHandler(aboutLicense_SelectionChanged);
		}

		public void aboutLicense_SelectionChanged(object sender, EventArgs e)
		{
			aboutLicense.SelectionLength = 0;
		}

		private void aboutProjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var projectUrl = ConfigurationManager.AppSettings["projectUrl"];
			Process.Start(projectUrl);
		}

		private void aboutJsonNetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(JsonNetUrl);
		}
	}
}
