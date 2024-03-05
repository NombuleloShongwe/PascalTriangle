using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows for Pascal's triangle:");
            int numRows = Convert.ToInt32(Console.ReadLine());

            PrintPascalTriangle(numRows);

            Console.WriteLine("Press the spacebar to exit...");
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar) { }
        }

        static void PrintPascalTriangle(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                // Print leading spaces to align triangle
                for (int space = 0; space < rows - i - 1; space++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalculateBinomialCoefficient(i, j) + " ");
                }
                Console.WriteLine();
            }
        }

        static int CalculateBinomialCoefficient(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
