using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Car2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList Cars = new System.Collections.ArrayList();
            Car c = new Car();
            c.Model = "V70";
            c.Maker = "Volvo";
            Cars.Add(c);
            Car d = new Car() { Maker = "Audi", Model = "A4", Color = "white" };
            Cars.Add(d);
            Cars.Add(new Car(){ Maker = "BMW" , Model = "f8" , Color = "Red"});
            Cars.Add(new Car() { Maker = "BMW", Model = "5f20", Color = "Blue" });
            Cars.Add(new Car() { Maker = "Volvo", Model = "t8", Color = "White" });
            Console.WriteLine( " Vi har {0} st bilar i lager just nu" , Cars.Count);
            foreach(Car anka in Cars){
                Console.WriteLine("{0} {1} {2}", anka.Maker, anka.Model, anka.Color);
            }
            Console.ReadLine();
        }
    }
}
