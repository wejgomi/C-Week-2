using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[5, 5];
            FillArray(numbers);

        }
        static void FillArray(int[,] numbers)
        {
            Random rnd = new Random();
            int total = 0;
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    int n = rnd.Next(0, 10);
                    numbers[i, j] = n;
                    Console.Write(string.Format("{0} ", numbers[i, j]));
                    total += n;
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            //Console.WriteLine("The randomly generated new array is: " + numbers);
            //Console.ReadLine();
            Console.WriteLine("Total: " + total);
            Console.WriteLine("The average is: " + total / (numbers.GetLength(0) * numbers.GetLength(1)));
            Console.ReadLine();
            SumArray(numbers);
        }
        static void SumArray(int[,] numbers)
        {
            int[] rows = new int[numbers.GetLength(0)];
            int[] columns = new int[numbers.GetLength(1)];
            int totalrows = 0;
            int totalcolumns = 0;
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    totalrows += numbers[i, j];
                    totalcolumns += numbers[j, i];
                }
                rows[i] = totalrows;
                columns[i] = totalcolumns;
                totalrows = 0;
                totalcolumns = 0;
            }
            Console.WriteLine("Sum of Rows: " + string.Join(" ", rows));
            Console.WriteLine("Sum of Rows: " + string.Join(" ", columns));
            Console.ReadLine();
        }
    }
}
