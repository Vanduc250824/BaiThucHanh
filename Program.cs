using KeThua1;
using System;
public class KeThua
{
    
    public static void Main(string[] args)
    {
        Electronic laptop = new Electronic("Laptop", 1000f, "A powerful gaming laptop", 1, 24);
        Clothing tshirt = new Clothing("T-Shirt", 20f, "Comfortable cotton t-shirt", 3, "L", "Blue");
        Food apple = new Food("Apple", 1f, "Fresh green apple", 10, DateTime.Now.AddDays(7));

        // Create shopping cart
        ShoppingCart cart = new ShoppingCart();

        // Add products to the cart
        cart.AddProduct(laptop);
        cart.AddProduct(tshirt);
        cart.AddProduct(apple);

        
        //Remove
        cart.RemoveProduct(tshirt); 
        // Display cart products
        Console.WriteLine("Products in your cart:");
        cart.onDisplay();

        // Display total price
        Console.WriteLine($"Total price: {cart.Tinh()}");
    }
}