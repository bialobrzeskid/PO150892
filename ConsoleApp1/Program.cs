using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj Swiecie");
            string carName = "Moj zamochod";
            Console.WriteLine(carName);
            Car autko = new Car(2016);  
            Console.WriteLine(autko.RokProdukcji);

        }
    }
}
