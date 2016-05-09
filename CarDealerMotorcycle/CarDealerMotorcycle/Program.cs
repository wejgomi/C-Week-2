using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealerMotorcycle
{
    class Vehicle
    {
        public List<string> type = new List<string> { };
        public List<string> name = new List<string> { };
        public List<string> model = new List<string> { };
        public List<int> price = new List<int> { };
        public List<string> sold = new List<string> { };
        public List<int> number = new List<int> { };

        public static Dictionary<string, int> stock = new Dictionary<string, int>
        {
            {"carsold", 0},
            {"carprice", 0},
            {"bikesold", 0},
            {"bikeprice", 0}
        };

        //public class Car : Vehicle
        //{
        //    type.Add("car");
        //    model.Add("1980");
        //    price.Add(10000);
        //    sold.Add("n");
        //}

        //class Motorbike : Vehicle
        //{
        //    type.Add("bike");
        //    model.Add("2013");
        //    price.Add(5000);
        //    sold.Add("n");
        //}

        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            string response = "";
            do
            {
                Console.Write(String.Format("Add {0} vehicle ? ", (string.IsNullOrEmpty(response) ? "new" : "another")));
                response = Console.ReadLine();
                int i = 0;
                if (response == "y")
                {
                    Console.Write("Which type of vehicle would you like to add (car/motorbike): ");
                    switch (Console.ReadLine().ToLower())
                    {
                        case "car": case "c":
                            Console.Write("Enter the brand of the car: ");
                            string newbrandcar = Console.ReadLine();
                            Console.Write("Enter the model of the car: ");
                            string newmodelcar = Console.ReadLine();
                            Console.Write("Enter the price of the car: ");
                            int newpricecar = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Is the car sold ? (y/n) ");
                            vehicle.AddVehicle("car", newbrandcar, newmodelcar, newpricecar, Console.ReadLine(),i++);
                            break;
                        case "motorbike": case "m":
                            Console.Write("Enter the brand of the motorbike: ");
                            string newbrandbike = Console.ReadLine();
                            Console.Write("Enter the model of the motorbike: ");
                            string newmodelbike = Console.ReadLine();
                            Console.Write("Enter the price of the motorbike: ");
                            int newpricebike = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Is the bike sold ? (y/n) ");
                            vehicle.AddVehicle("bike", newbrandbike, newmodelbike, newpricebike, Console.ReadLine(),i++);
                            break;
                    }
                    Console.Clear();
                }
            } while (response == "y");
            var attributes = vehicle.type.Zip(vehicle.name, (t, n) => new { t, n }).Zip(vehicle.model, (a, m) => new { a, m }).Zip(vehicle.price, (b, p) => new { b, p }).Zip(vehicle.sold, (c, s) => new { c, s }).Zip(vehicle.number, (d, n) => new { Type = d.c.b.a.t, Name = d.c.b.a.n, Model = d.c.b.m, Price = d.c.p, Sold = d.s, Number = n });
            foreach (var z in attributes)
            {
                Console.WriteLine(String.Format("The {0} number {1} is a {2} with a model number of {3}, which has a price of {4} and is {5}sold" + "\n", z.Type, z.Number, z.Name, z.Model, z.Price, ((z.Sold == "y") ? "" : "not ")));
                if (z.Sold == "y") { switch (z.Type) { case "car": stock["carsold"]++; stock["carprice"] += z.Price; break; case "bike": stock["bikesold"]++; stock["bikeprice"] += z.Price; break; } }
            }
            foreach (string value in vehicle.type.OrderBy(x => x).ToList().Take(2))
            {
                Console.WriteLine(String.Format("Value of {0} sales so far: {1}", value, stock[value + "price"]));
                Console.WriteLine(String.Format("Stock value: {0} out of {1} {2}s available !", (vehicle.type.Count(s => s == value) - stock[value + "sold"]), vehicle.type.Count(s => s == value), value));
            }
            Console.Read();
        }

        public void AddVehicle(string type, string name, string model, int price, string sold, int no)
        {
            this.type.Add(type);
            this.number.Add(no);
            this.name.Add(name);
            this.model.Add(model);
            this.price.Add(price);
            this.sold.Add(sold);
        }
    }
}