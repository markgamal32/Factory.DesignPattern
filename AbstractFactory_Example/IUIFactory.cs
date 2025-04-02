using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Example
{
	// Abstract Factory
	internal interface IUIFactory
	{
		IButton CreateButton();
		ICheckbox CreateCheckbox();
	}
}
