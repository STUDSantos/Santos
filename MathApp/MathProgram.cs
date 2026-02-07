using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ MATH CLASSES METHODS -----");

            double negativeNumber = -15.5;
            double absoluteValue = Math.Abs(negativeNumber);
            Console.WriteLine($"\n1. Absolute value of {negativeNumber} is {absoluteValue}");

            double valueToRound = 45.678;
            double roundedValue = Math.Round(valueToRound, 2);
            Console.WriteLine($"\n2. {valueToRound} rounded to 2 decimal places is {roundedValue}");

            double numberForSqrt = 16.0;
            double squareRoot = Math.Sqrt(numberForSqrt);
            Console.WriteLine($"\n3. Square root of {numberForSqrt} is {squareRoot}");

            double baseNumber = 5.0;
            double exponent = 3.0;
            double powerResult = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"\n4. {baseNumber} raised to the power of {exponent} is {powerResult}");

            int num1 = 100;
            int num2 = 350;

            int maxValue = Math.Max(num1, num2);
            Console.WriteLine($"\n5. Maximum of {num1} and {num2} is {maxValue}");

            Console.WriteLine("\n------ END OF MATH CLASSES METHODS -----");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}