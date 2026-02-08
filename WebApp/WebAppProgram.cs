using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp
{
    internal class WebAppProgram
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Product list: name and price
            string[] products = { "Bread", "Milk", "Soda", "Beef", "Pork", "Coffee", "Beer" };
            int[] prices = { 1, 2, 2, 5, 4, 6, 3 };

            // Shopping cart: store product index and quantity
            int[] cart = new int[products.Length]; // Initialize to zero
            int totalCost = 0;

            Console.WriteLine("🛒 Welcome to the Console E-Commerce Store!");
            Console.WriteLine("Enter product number (1-7) or 'P' to finish shopping.\n");

            // Shopping loop
            while (true)
            {
                Console.WriteLine("Available Products:");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i]} - ${prices[i]}");
                }

                Console.Write("\nEnter product number (1-7) or 'P' to finish: ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "p")
                {
                    break; // Exit loop
                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= products.Length)
                {
                    int index = choice - 1;
                    Console.Write($"How many {products[index]}? ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                    {
                        cart[index] += quantity;
                        totalCost += prices[index] * quantity;
                        Console.WriteLine($"✅ Added {quantity} {products[index]} to cart.\n");
                    }
                    else
                    {
                        Console.WriteLine("❌ Invalid quantity. Please enter a positive number.\n");
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid input. Please enter a number from 1-7 or 'P'.\n");
                }
            }

            // Final receipt
            Console.WriteLine("\n" + "=".PadLeft(40, '='));
            Console.WriteLine("🛒 FINAL RECEIPT");
            Console.WriteLine("=".PadLeft(40, '='));

            int itemCount = 0;
            foreach (var item in cart)
            {
                if (item > 0)
                {
                    itemCount++;
                    Console.WriteLine($"- {products[itemCount - 1]}: {item} x ₱{prices[itemCount - 1]} = ₱{item * prices[itemCount - 1]}");
                }
            }

            if (itemCount == 0)
            {
                Console.WriteLine("No items were purchased.");
            }
            else
            {
                Console.WriteLine("-".PadLeft(40, '-'));
                Console.WriteLine($"Total Amount: ₱{totalCost}");
            }

            Console.WriteLine("=".PadLeft(40, '='));
            Console.WriteLine("Thank you for shopping with us! 🎉");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

