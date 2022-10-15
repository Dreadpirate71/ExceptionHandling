using System;

namespace Exception_Handling_Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber >= 0)
                {
                    double inputNumberSqrt = Math.Sqrt(inputNumber);
                    Console.WriteLine(inputNumberSqrt);
                }
                else
                {
                    Console.WriteLine("Please enter a positive number");
                }
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
