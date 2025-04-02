using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	internal class LightCheckbox : ICheckbox
	{
		public void Render() => Console.WriteLine("Rendering a light theme checkbox.");
	}
}
