using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	// Concrete products for Dark Theme
	internal class DarkCheckbox : ICheckbox
	{
		public void Render() => Console.WriteLine("Rendering a dark theme checkbox.");
	}
}
