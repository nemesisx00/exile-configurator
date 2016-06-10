using System.IO;
using System.Windows.Forms;

namespace ExileConfigurator.IO
{
	public class FileUtil
	{
		public const string DefaultFileNameItemList = "ExileItems.json";
		public const string DefaultFileNameExportVendor = "VendorItems.txt";
		public const string FileDialogFilter = "All files (*.*)|*.*";
		public const string FileDialogFilterTextFiles = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

		public static string readFileFull(string filePath)
		{
			string output = string.Empty;
			if(File.Exists(filePath))
				output = File.ReadAllText(filePath);
			return output;
		}

		public static void writeFile(string output, string filePath)
		{
			if(output != null && !string.Empty.Equals(output))
			{
				using(var sw = new StreamWriter(filePath))
				{
					sw.Write(output);
				}
			}
		}

		/// <summary>
		/// Display the OpenFileDialog and get the file path selected by the user.
		/// </summary>
		/// <returns></returns>
		public static string readFileDialog()
		{
			var openFile = new OpenFileDialog();
			openFile.Filter = FileDialogFilter;

			var filePath = string.Empty;
			if(openFile.ShowDialog().Equals(DialogResult.OK) && openFile.FileName != null)
				filePath = openFile.FileName;

			return filePath;
		}

		public static string saveFileDialog()
		{
			return saveFileDialog(DefaultFileNameItemList, FileDialogFilter);
		}

		public static string saveFileDialog(string defaultFileName)
		{
			return saveFileDialog(defaultFileName, FileDialogFilter);
		}

		/// <summary>
		/// Display the SaveFileDialog and get the file path selected by the user.
		/// </summary>
		/// <param name="defaultFileName"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		public static string saveFileDialog(string defaultFileName, string filter)
		{
			var saveFile = new SaveFileDialog();
			saveFile.FileName = defaultFileName;
			saveFile.Filter = filter;

			var filePath = string.Empty;
			if(saveFile.ShowDialog().Equals(DialogResult.OK))
				filePath = saveFile.FileName;

			return filePath;
		}
	}
}
