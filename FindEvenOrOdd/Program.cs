using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isValidInput = false;

            


            do
            {
                Console.Write("Please enter a number: ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!isValidInput);


            if (number %2==0)
            {
                Console.WriteLine($"the {number}  is an even number");
            }
            else
            {
                Console.WriteLine($"the {number}  is an odd number");
            }
        }
    }
}

