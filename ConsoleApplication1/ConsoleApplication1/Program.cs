using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int i = rnd.Next(100);
            int response;
            int n = 0;
            do {
                if (n == 0)
                {
                    Console.Write("Enter a number between 1-100: ");
                }
                else { Console.Write("Try again: "); }
                response = Convert.ToInt32(Console.ReadLine());
                if ((response - i) > -5 && (response - i) < 0) {
                    Console.WriteLine("Too hot but go higher");
                    n++;
                }
                else if ((response - i) < 5 && (response - i) > 0) {
                    Console.WriteLine("Too hot but go smaller");
                    n++;
                }
                else if ((response - i) > -10 && (response - i) < 0) {
                    Console.WriteLine("Hot but go higher");
                    n++;
                }
                else if ((response - i) < 10 && (response - i) > 0) {
                    Console.WriteLine("Hot but go smaller");
                    n++;
                }
                else if (response < i) {
                    Console.WriteLine("Go higher !");
                    n++;
                }
                else if (response > i) {
                    Console.WriteLine("Go smaller !");
                    n++;
                }
            } while (response != i);
            n++;
            Console.WriteLine("That's it !");
            Console.WriteLine("Correct number was: " + i);
            Console.WriteLine("Number of guesses: " + n);
            Console.WriteLine("Retry ?");
            string retry;
            retry = Console.ReadLine();
            if (retry == "yes" || retry == "Yes")
            {
                Console.Clear();
                Main();
            }
        }
    }
}
