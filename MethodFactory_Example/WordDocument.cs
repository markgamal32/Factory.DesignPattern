using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory_Example
{
	// Concrete products
	internal class WordDocument :IDocument
	{
		public void Open() => Console.WriteLine("Opening a Word document.");
	}
}
