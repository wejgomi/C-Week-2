using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the dimensions of the square array: ");
            int dimensions = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the dimensions to fill: ");
            int filldimensions = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[dimensions, dimensions];
            FillArray(numbers, filldimensions);
        }
        static void FillArray(int[,] numbers, int d)
        {
            Random rnd = new Random();
            int total = 0;
            try
            {
                int a = rnd.Next(0, 10) / d;
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine();
                System.Console.WriteLine(e.Message);
                throw new System.ArgumentOutOfRangeException("Arithmetic exception occured in specified parameter.", e);
            }
            try
            {
                for (var i = 0; i < d; i++)
                {
                    for (var j = 0; j < d; j++)
                    {
                        int n = rnd.Next(0, 10);
                        numbers[i, j] = n;
                        Console.Write(string.Format("{0} ", numbers[i, j]));

                    }
                    Console.Write(Environment.NewLine + Environment.NewLine);
                }
                Console.ReadLine();
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine();
                System.Console.WriteLine(e.Message);
                throw new System.ArgumentOutOfRangeException("Index parameter specified is out of range.", e);
            }
        }
    }
}
