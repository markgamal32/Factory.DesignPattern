namespace AbstractFactory_Example
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*The Abstract Factory pattern provides an interface for creating families of 
			related or dependent objects without specifying their concrete classes.
			This pattern is useful when your system should be independent 
			of how its products are created, composed, and represented.*/

			// When to use:
			// When your code needs to work with various families of related products.
			// When you want to enforce that certain products are used together (a family of products).
			// When you want to provide a level of abstraction for object creation across different platforms or environments

			/* Example:
            Suppose you’re building a UI framework that supports different themes. 
			You have factories for creating themed UI components like buttons and check-boxes */

			// Assume the theme is determined at runtime
			IUIFactory uiFactory = new DarkUIFactory();


			IButton button = uiFactory.CreateButton();
			ICheckbox checkbox = uiFactory.CreateCheckbox();

			button.Render();   // Output: Rendering a dark theme button.
			checkbox.Render(); // Output: Rendering a dark theme checkbox.
		}
	}
}
