using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactory_Example
{
	// Creator abstract class
	public abstract class Application
	{ 
		// The factory method
		public abstract IDocument CreateDocument();
		public void NewDocument()
		{
			var doc = CreateDocument();
			doc.Open();
		}
	}
}
