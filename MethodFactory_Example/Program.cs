namespace MethodFactory_Example
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Application wordApp = new WordApplication();
			wordApp.NewDocument(); // Output: Opening a Word document.

			Application excelApp = new ExcelApplication();
			excelApp.NewDocument(); // Output: Opening an Excel spreadsheet.

		}
	}
}
