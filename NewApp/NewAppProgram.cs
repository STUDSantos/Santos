using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
    {
        internal class NewAppProgram
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Console Calculator in C#");
                Console.WriteLine("------------------------\n");

                // Ask the user to type the first number
                Console.Write("Type a number, and then press Enter: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to type the second number
                Console.Write("Type another number, and then press Enter: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to choose an operator
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                // Perform the calculation
                double result = 0;
                if (op == "a")
                {
                    result = num1 + num2;
                    Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                }
                else if (op == "s")
                {
                    result = num1 - num2;
                    Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                }
                else if (op == "m")
                {
                    result = num1 * num2;
                    Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                }
                else if (op == "d")
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid operator.");
                }

                Console.Write("Press any key to close the console app...");
                Console.ReadKey();
            }
        }
    }
