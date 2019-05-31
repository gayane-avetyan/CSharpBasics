using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input a number: ");
                int number = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                if (double.IsNaN(result))
                {
                    throw new ArithmeticException();
                }
                Console.WriteLine($"The result is {result}");              
            }
            catch (FormatException)
            {
                Console.WriteLine("Digits required");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Only positive number is allowed");
            }
            finally
            {
                Console.WriteLine("Good by");
            }
        }
    }
}
