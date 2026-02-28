using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.WriteLine("Enter 5 grades separeted by space:");

            for (int i = 0; i < 5; i++)
            {
                sum += Convert.ToDouble(Console.ReadLine());
            }

            double average = sum / 5;
            int roundedInt = Convert.ToInt32(average);

            Console.WriteLine("=============================================================");
            Console.WriteLine($"The average is: {average} and round off to {roundedInt}");
            Console.WriteLine("=============================================================");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
