using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_T40920
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Car, stand by");
            Car c;
            c = new Car();
            c.RegistrationNumber = "ABC123";
            c.HorsePower = 170;
            c.Color = "Black";
            Console.WriteLine("Car created sucessfully");
            Console.ReadLine();
            Console.WriteLine("We have a {0} car with registation {1} and {2}",
                c.Color, c.RegistrationNumber, c.HorsePower);
            Console.ReadLine();

        }
    }
    class Car
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }   
}
