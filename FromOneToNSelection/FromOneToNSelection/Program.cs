using System;

namespace FromOneToNSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input;
            do
            {
                Console.Write("Enter number: ");
                input = int.TryParse(Console.ReadLine(), out int n);
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write($"{i} ");
                    }
                }

            } while (!input);
            Console.WriteLine();
        }
    }
}
