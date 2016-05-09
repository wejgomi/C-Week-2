using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = rnd.Next(100);
            string response;
            int n = 0;
            Console.WriteLine("People Standing for Presidency in USA: ");
            string[] candidates = new string[] { "Hillary Clinton", "Donald Trump", "Bernie Sanders", "Jeb Bush", "Scott Walker" };
            string[] odds = new string[] { "1/6", "1/33", "1/9", "4/7", "1/4" };
            Console.WriteLine(string.Join(", ", candidates));
            Console.Write("Who do you think will win ? ");
            response = Console.ReadLine();

            switch (response)
            {
                case "Hillary Clinton": case "Clinton": case "clinton": case "Hillary": case "hillary":
                    Console.WriteLine("Hope she doesn't take after her husband !");
                    Console.Write("The odds for her is " + odds[0]);
                    Console.ReadLine();
                    break;
                case "Donald Trump": case "Trump": case "trump": case "Donald": case "donald":
                    Console.WriteLine("Oh God save us !!");
                    Console.Write("The odds for him is " + odds[1]);
                    Console.ReadLine();
                    break;
                case "Bernie Sanders": case "Sanders": case "sanders": case "Bernie": case "bernie":
                    Console.WriteLine("He's the good guy, isn't he ?");
                    Console.Write("The odds for him is " + odds[2]);
                    Console.ReadLine();
                    break;
                case "Jeb Bush": case "Bush": case "bush": case "Jeb": case "jeb":
                    Console.WriteLine("Even the surname gives me the creeps !");
                    Console.Write("The odds for him is " + odds[3]);
                    Console.ReadLine();
                    break;
                case "Scott Walker": case "Walker": case "walker": case "Scott": case "scott":
                    Console.WriteLine("Not a bad choice indeed !");
                    Console.Write("The odds for him is " + odds[4]);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Who's that ?!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
