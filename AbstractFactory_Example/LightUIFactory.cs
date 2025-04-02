using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	// Concrete Factories
	internal class LightUIFactory : IUIFactory
	{
		public IButton CreateButton() => new LightButton();
		public ICheckbox CreateCheckbox() => new LightCheckbox();
	}
}
