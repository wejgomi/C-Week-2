using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            string[] meals = new string[50];
            string[] drinks = new string[50];
            for (var i = 0; i < 7; i++)
            {
                Console.Write(dwarves[i] + ", what do you want for dinner ? ");
                string dinner = Console.ReadLine();
                meals[i] = dinner;
            }
            int j = 0;
            foreach(string value in dwarves)
            {
                Console.Write(dwarves[j] + ", what do you want to drink ? ");
                string drink = Console.ReadLine();
                drinks[j] = drink;
                j++;
            }
            //do
            for (var n = 0; n < (meals.Length - 1); n++)
            {
                //int n = 0;
                Console.WriteLine(dwarves[n] + ", your " + meals[n] + " and your " + drinks[n] + " is ready !");
                //n++;
                //} while (meals[n] != null);
            }
        }
    }
}
