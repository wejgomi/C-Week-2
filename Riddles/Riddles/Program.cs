using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] riddles = new string[] { "What has a foot but no legs?", "Poor people have it. Rich people need it. If you eat it you die. What is it?", "What comes down but never goes up?", "I’m tall when I’m young and I’m short when I’m old. What am I?", "Mary’s father has 5 daughters – Nana, Nene, Nini, Nono. What is the fifth daughters name?" };
            string[] answers = new string[] { "Snail", "snail", "Nothing", "nothing", "Candle", "candle", "Mary", "mary", "Hole", "hole" };
            string[] longanswers = new string[] { "Snail", "Nothing", "Rain", "A candle", "If you answered Nunu, you are wrong. It’s Mary!", "It can have a hole in it." };
            Console.Write("Which version to use(0/1) ? ");
            int version = Convert.ToInt32(Console.ReadLine());
            switch (version) {
                case 0:
                    Riddle(riddles, answers, longanswers);
                    break;
                case 1:
                    RiddleLoopThrough(riddles, answers, longanswers);
                    break;
            }
        }
        public static void Riddle(string[] riddles, string[] answers, string[] longanswers)
        {
            Random rnd = new Random();
            int i = rnd.Next(4);
            Console.WriteLine(riddles[i]);
            Console.Write("What do you think ? ");
            string response = Console.ReadLine();
            if (response == answers[i] || answers.Contains(response))
            {
                Console.WriteLine("You are right !");
            }
            else
            {
                Console.WriteLine("You are wrong, the correct answer was: ");
                Console.WriteLine(longanswers[i]);
            }
            Console.ReadLine();
        }
        public static void RiddleLoopThrough(string[] riddles, string[] answers, string[] longanswers)
        {
            //CultureInfo english = new CultureInfo("en-EN", false);
            int i = 0;
            do
            {
                Console.WriteLine(riddles[i]);
                Console.Write("What do you think ? ");
                string response = Console.ReadLine();
                if (longanswers[i].Contains(response) || longanswers[i].IndexOf(response,StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine("You are right !");
                }
                else
                {
                    Console.WriteLine("You are wrong !");
                    for(int n = 0; n < 2; n++)
                    {
                        Console.Write("Try Again: ");
                        string responsetry = Console.ReadLine();
                        if (longanswers[i].IndexOf(responsetry, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine("You are right !");
                            continue;
                        }
                    }
                    Console.WriteLine("The correct answer was: " + longanswers[i]);
                }
                i++;
            } while (i < riddles.Length);
            Console.WriteLine("That's all for today, folks !");
            Console.ReadLine();
        }
    }
}
