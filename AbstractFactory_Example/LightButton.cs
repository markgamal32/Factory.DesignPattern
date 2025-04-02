using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	// Concrete products for Light Theme
	internal class LightButton :IButton
	{
		public void Render() => Console.WriteLine("Rendering a light theme button.");
	}
}
