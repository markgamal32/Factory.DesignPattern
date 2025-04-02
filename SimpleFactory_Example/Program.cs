namespace SimpleFactory_Example
{
	/*1. Simple Factory (Static Factory)
	 * A Simple Factory is not a “formal” design pattern from the Gang of Four, but it’s a common idiom.
	It typically uses a static method to create and return objects based on input parameters.
	This centralizes object creation in one place.

	When to use:
    When you want to hide the creation logic.
	When object creation is complex or might change.
	When the client code should work with a common interface.

	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			IVehicle vehicle = VehicleFactory.CreateVehicle("car");
			vehicle.Drive(); // Output: Driving a car.
		}
	}
}
