using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static List<string> books = new List<string>()
            {
                "Lord of The Rings",
                "Peter Pan",
                "Hobbit",
                "Harry Potter",
                "Life of Pi"
            };
        static void Main()
        {
            Console.Write("Please state the action to execute(Add,Delete,List,Sort,Find,Quit): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "Add": case "add": case "a": case "A":
                    Add(books);
                    break;
                case "Delete": case "delete": case "d": case "D":
                    Remove(books);
                    break;
                case "List": case "list": case "l": case "L":
                    List(books);
                    break;
                case "Sort": case "sort": case "s": case "S":
                    Sort(books);
                    break;
                case "Find": case "find": case "f": case "F":
                    Find(books);
                    break;
                case "Quit": case "quit": case "q": case "Q":
                    break;
            }
        }
        static void List(List<string> books)
        {
            Console.WriteLine("Here's the list of all books:");
            //books.ForEach(Console.Write);
            Console.WriteLine(string.Join(", ", books));
            Restart();
        }
        static void Add(List<string> books)
        {
            Console.Write("Enter the name of the new book: ");
            string newbook = Console.ReadLine();
            books.Add(newbook);
            Console.WriteLine(newbook + " added to list of books !");
            Restart();
        }
        static void Remove(List<string> books)
        {
            Console.Write("Enter the name of the book to remove: ");
            string newbook = Console.ReadLine();
            if (books.Contains(newbook))
            {
                books.Remove(newbook);
                Console.WriteLine("Removed " + newbook + " from the book list !");
                Restart();
            }
            else
            {
                Console.WriteLine("Book not found inside the book list !");
                Restart();
            }
        }
        static void Sort(List<string> books)
        {
            books.Sort();
            Console.WriteLine("Book list sorted successfully !");
            Restart();
        }
        static void Find(List<string> books)
        {
            Console.Write("Please enter the string to search: ");
            string searchstring = Console.ReadLine();
            string found = books.Find(a => a.Equals(searchstring));
            if (found == searchstring)
            {
                Console.WriteLine("Book found inside the book list !");
            }
            else { Console.WriteLine("Sorry, no such book exists !"); }
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
