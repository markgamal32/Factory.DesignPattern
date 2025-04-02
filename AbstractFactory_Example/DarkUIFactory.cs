using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	internal class DarkUIFactory : IUIFactory
	{
		public IButton CreateButton() => new DarkButton();
		public ICheckbox CreateCheckbox() => new DarkCheckbox();
	}
}
