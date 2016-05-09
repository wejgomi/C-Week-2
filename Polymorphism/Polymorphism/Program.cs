using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Vehicle
    {
        public class Car
        {
            public virtual void Show()
            {
                Console.WriteLine("A car has 4 wheels");
            }

            public class Automobile : Car
            {
                public override void Show()
                {
                    Console.WriteLine("The automobile has 4 wheels");
                }
            }

            public class Family : Car
            {
                public override void Show()
                {
                    Console.WriteLine("The family car has 4 wheels");
                }
            }
            
            public class Covini : Car
            {
                public override void Show()
                {
                    Console.WriteLine("A covini has 6 wheels");
                }
            }
        }
        public class Bike
        {
            public virtual void Show()
            {
                Console.WriteLine("A bike has 2 wheels");
            }
            public class Bicycle : Bike
            {
                public override void Show()
                {
                    Console.WriteLine("A bicycle has 2 wheels");
                }
            }
            public class Motorbike : Bike
            {
                public override void Show()
                {
                    Console.WriteLine("A motorbike has 2 wheels");
                }
            }
            public class Tricycle : Bike
            {
                public override void Show()
                {
                    Console.WriteLine("A tricycle has 3 wheels");
                }
            }
        }

        static void Main(string[] args)
        {
            Alternative();
            // Get from the main car class
            Car car;
            car = new Car();
            // Output from main car class
            car.Show();

            // Get from the automobile sublass using main car class
            car = new Car.Automobile();
            // Output from main car class
            car.Show();

            // Get from the automobile subclass
            Car.Automobile car2;
            car2 = new Car.Automobile();
            // Output from automobile subclass
            car2.Show();

            // Get from the covini sublass using main car class
            Car car3;
            car3 = new Car.Covini();
            // Output from main car class
            car3.Show();

            // Get from the main bike class
            Bike bike = new Bike();
            // Output from main bike class
            bike.Show();

            // Get from the bicycle subclass
            Bike.Bicycle bike2 = new Bike.Bicycle();
            // Output from bicycle subclass
            bike2.Show();

            // Get from the motorbike subclass using main bike class
            Bike bike3 = new Bike.Motorbike();
            // Output from main bike class
            bike3.Show();

            // Get from the tricycle subclass
            Bike.Tricycle bike4 = new Bike.Tricycle();
            // Output from tricycle subclass
            bike4.Show();

            Console.ReadLine();
        }

        static void Alternative()
        {
            Car car = new Car();
            //List<Vehicle> vehicles = Car.Automobile.Select(dc => new Vehicle { A = dc.A }).ToList();
            Console.Write("From which class would you like to see(car/motorbike) ?");
            switch(Console.ReadLine().ToLower())
            {
                case "car": case "c":
                    IEnumerable<Vehicle> export = typeof(Vehicle)
    .Assembly.GetTypes()
    .Where(t => t.IsSubclassOf(typeof(Vehicle)) && !t.IsAbstract)
    .Select(t => (Vehicle)Activator.CreateInstance(t));
                    List<Vehicle> cars = export.ToList();
                    Console.WriteLine("List of Cars are: " + string.Join(",", cars));
                    Console.Write("Which class of car would you like to display ? ");
                    Console.ReadLine();
                    Console.Write("Display using class/subclass ? ");
                    break;
            }
        }
    }
}
