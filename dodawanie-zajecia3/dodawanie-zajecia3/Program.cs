using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodawanie_zajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Obliczenia kalklulator = new Obliczenia();
            kalklulator.a = 5;
            kalklulator.b = 4;

            Console.WriteLine(kalklulator.Dodawanie(kalklulator.a, kalklulator.b));
            Console.WriteLine(kalklulator.Potegowanie(kalklulator.a, kalklulator.b));
        }


    }
}
