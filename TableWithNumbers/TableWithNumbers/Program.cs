using System;

namespace TableWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool input;

            do
            {
                Console.Write("Enter number: ");
                input = int.TryParse(Console.ReadLine(), out number);
            } while (!input);

            for (int i = 0; i < number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    Console.Write($"{j + i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
