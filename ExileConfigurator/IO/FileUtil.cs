using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExileConfigurator.IO
{
	public class FileUtil
	{
		public const string DefaultFileNameItemList = "ExileItems.json";
		public const string DefaultFileNameExportVendor = "VendorItems.txt";
		public const string FileDialogFilter = "All files (*.*)|*.*";
		public const string FileDialogFilterTextFiles = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

		public static void writeFileDialog(string output)
		{
			writeFileDialog(output, DefaultFileNameItemList, FileDialogFilter);
		}

		public static void writeFileDialog(string output, string defaultFileName)
		{
			writeFileDialog(output, defaultFileName, FileDialogFilter);
		}

		public static void writeFileDialog(string output, string defaultFileName, string filter)
		{
			if(output != null && output.Length > 0)
			{
				var savefile = new SaveFileDialog();
				savefile.FileName = defaultFileName;
				savefile.Filter = filter;

				switch(savefile.ShowDialog())
				{
					case DialogResult.OK:
						using (var sw = new StreamWriter(savefile.FileName))
						{
							sw.Write(output);
						}
						break;
					default:
						break;
				}
			}
		}

		public static string readFileDialog()
		{
			string output = null;
			var openFile = new OpenFileDialog();
			openFile.Filter = FileDialogFilter;

			switch (openFile.ShowDialog())
			{
				case DialogResult.OK:
					if (openFile.FileName != null)
						output = File.ReadAllText(openFile.FileName);
					break;
				default:
					break;
			}

			return output;
		}
	}
}
