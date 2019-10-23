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
            
            string carName = "Moj zamochod";
            Console.WriteLine(carName);


            Car car1 = new Car();
            Car car2 = new Car();

            car1.RokProdukcji = 2016;
            car1.Marka = "Lamborghini";

            car2.RokProdukcji = 1999;
            car2.Marka = "Renault Meganne";

            //car1 = car2;

            Console.WriteLine(car1.RokProdukcji + "" + car1.Marka);
            Console.WriteLine(car2.RokProdukcji + "" + car2.Marka);
            string tekst = "aa";
            string tekst2 = "bb";
            int cyfra = 3;

            Console.WriteLine(opiszTyp(tekst, tekst2));
            Console.WriteLine(opiszTyp(tekst, cyfra));
            Console.ReadKey();


        }
        static string opiszTyp(string tekst, string tekst2)
        {
            Console.WriteLine(tekst + " " + tekst2);
            return "a";
        }

        static int opiszTyp(string cyfry, int cyferki)
        {
            Console.WriteLine(cyfry + " " + cyferki);
            return 5;
        }



    }
}


//public enum Plec { K, M}