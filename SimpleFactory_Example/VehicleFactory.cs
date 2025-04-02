using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_Example
{
	public static class VehicleFactory
	{
		// Simple Factory
		public static IVehicle CreateVehicle(string type)
		{
			return type.ToLower() switch
			{
				"car" => new Car(),
				"bike" => new Bike(),
				_ => throw new ArgumentException("Invalid vehicle type")
			};
		}
	}
}
