using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> languages = new Dictionary<string, string>
        {
            {"MATLAB", "array"},
            {"javascript", "object-oriented"},
            {"dBase","data-oriented"},
            {"Pascal","educational"},
            {"Python","embeddable"},
            {"Analytica","declarative"}
        };
        static void Main()
        {
            Console.Write("Please state the action to execute(Add,Delete,List,Edit,Search,Quit): ");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "add": case "a":
                    Add(languages);
                    break;
                case "delete": case "d":
                    Remove(languages);
                    break;
                case "list": case "l":
                    List(languages);
                    break;
                case "edit": case "e":
                    Edit(languages);
                    break;
                case "search": case "s":
                    Find(languages);
                    break;
                case "quit": case "q":
                    break;
            }
        }
        static void List(Dictionary<string,string> languages)
        {
            Console.WriteLine("Here's the list of all programming languages:");
            //languages.ForEach(Console.Write);
            Console.WriteLine(string.Join("\n", languages));
            Restart();
        }
        static void Add(Dictionary<string,string> languages)
        {
            Console.Write("Enter the name of the new programming language: ");
            string newlanguage = Console.ReadLine();
            Console.Write("Enter the type of the new programming language: ");
            string newtype = Console.ReadLine();
            languages.Add(newlanguage,newtype);
            Console.WriteLine(newlanguage + ", which is a " + newtype + " type of programming language is added to list");
            Restart();
        }
        static void Remove(Dictionary<string,string> languages)
        {
            Console.Write("Enter the name of the programming language to remove: ");
            string newlanguage = Console.ReadLine();
            if (languages.ContainsKey(newlanguage))
            {
                languages.Remove(newlanguage);
                Console.WriteLine("Removed " + newlanguage + " from the programming languages list !");
                Restart();
            }
            else
            {
                Console.WriteLine("Language not found inside the programming languages list !");
                Restart();
            }
        }
        static void Edit(Dictionary<string,string> languages)
        {
            Console.WriteLine("Here's the list of all programming languages:");
            Console.WriteLine(string.Join("\n", languages));
            Console.Write("Please select a programming language to edit: ");
            string editlanguage = Console.ReadLine();
            if (languages.ContainsKey(editlanguage))
            {
                Console.Write("Enter the new type for the programming language: ");
                string edittype = Console.ReadLine();
                languages[editlanguage] = edittype;
                Console.WriteLine("Programming language type changed successfully !");
            }
            else { Console.WriteLine("Sorry, no such programming language exists !"); }
            Restart();
        }
        static void Find(Dictionary<string,string> languages)
        {
            Console.Write("Search the dictionary by key/value ? ");
            string searchtype = Console.ReadLine().ToLower();
            switch (searchtype)
            {
                case "key": case "k":
                    Console.Write("Please enter the key to search: ");
                    string searchkey = Console.ReadLine();
                    if (languages.ContainsKey(searchkey))
                    {
                        Console.WriteLine("Language found inside the programming languages list !");
                        Console.WriteLine("Value for the key was: " + languages[searchkey]);
                    }
                    else { Console.WriteLine("Sorry, no such programming language exists !"); }
                    break;
                case "value": case "v":
                    Console.Write("Please enter the value to search: ");
                    string searchvalue = Console.ReadLine();
                    if (languages.ContainsValue(searchvalue))
                    {
                        Console.WriteLine("Type found inside the programming languages list !");
                        Console.WriteLine("Key for the value was: " + languages.FirstOrDefault(a => a.Value == searchvalue).Key);
                    }
                    else { Console.WriteLine("Sorry, no such programming language type exists !"); }
                    break;
            }
            Restart();
        }
        static void Restart()
        {
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }
}
