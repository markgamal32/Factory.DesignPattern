﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Example
{
	internal class Bike :IVehicle
	{
		public void Drive() => Console.WriteLine("Riding a bike.");
	}
}
