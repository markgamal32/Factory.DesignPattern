using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory_Example
{
	// Concrete products
	internal class ExcelDocument :IDocument
	{
		public void Open() => Console.WriteLine("Opening an Excel spreadsheet.");
	}
}
