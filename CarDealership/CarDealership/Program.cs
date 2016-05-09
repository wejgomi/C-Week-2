using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class CarRegister
    {
        public List<string> name = new List<string> { };
        public List<string> model = new List<string> { };
        public List<int> price = new List<int> { };
        public List<string> sold = new List<string> { };
        public List<int> number = new List<int> { };

        public static int no = 0;
        public static int nosold = 0;
        public static int noprice = 0;
        public static string a;

        public CarRegister ()
        {
            model.Add("1980");
            price.Add(10000);
            sold.Add("n");
        }

        static void Main(string[] args)
        {
            CarRegister car1 = new CarRegister();
            Console.Write("Enter the brand of the car: ");
            string brand = Console.ReadLine();
            CarRegister.no++;
            car1.name.Add(brand);
            car1.number.Add(no);
            do {
                Console.Write("Add another car ? ");
                a = Console.ReadLine();
                if(a == "y") {
                    Console.Write("Enter the brand of the car: ");
                    string newbrand = Console.ReadLine();
                    Console.Write("Enter the model of the car: ");
                    string newmodel = Console.ReadLine();
                    Console.Write("Enter the price of the car: ");
                    int newprice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is the car sold ? (y/n) ");
                    car1.AddCar(newbrand, newmodel, newprice, Console.ReadLine(), no);
                    Console.Clear();
                }
            } while (a == "y");
            var attributes = car1.name.Zip(car1.model, (n, m) => new { n, m }).Zip(car1.price, (a,p) => new { a,p }).Zip(car1.sold, (b,s) => new { b,s }).Zip(car1.number, (c, n) => new { Name = c.b.a.n, Model = c.b.a.m, Price = c.b.p, Sold = c.s, Number = n });
            foreach (var z in attributes) {
                Console.WriteLine(String.Format("Car number {0} is a {1} with a model number of {2}, which has a price of {3} and is {4}sold" + "\n", z.Number,z.Name,z.Model,z.Price, ((z.Sold == "y") ? "" : "not ")));
                if (z.Sold == "y") { nosold++; noprice += z.Price; };
            }
            Console.WriteLine(String.Format("Value of sales so far: {0}", noprice));
            Console.Write(String.Format("Stock value: {0} out of {1} cars available !", (car1.number.Count - nosold), car1.number.Count));
            Console.Read();
        }
        public void AddCar(string name, string model, int price, string sold, int no)
        {
            CarRegister.no++;
            this.number.Add(no);
            this.name.Add(name);
            this.model.Add(model);
            this.price.Add(price);
            this.sold.Add(sold);
        }
    }
}
