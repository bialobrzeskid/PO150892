using System;

namespace dodawanie_zajecia3
{
    class Obliczenia
    {
        public double wynik;
        public double a;
        public double b;


        public double Dodawanie (double a, double b)
        {
            wynik = a + b;
            return wynik;
        }
        public double Odejmowanie (double a, double b)
        {
            wynik = a - b;
            return wynik;
        }
        public double Mnozenie(double a, double b)
        {
            wynik = a * b;
            return wynik;
        }
        public double Dzielenie(double a, double b)
        {
            try
            {
                wynik = a / b;
               
            }
            catch
            {
                Console.WriteLine("Nie mozna dzielic przez zero");
            }
            return wynik;
        }
        public double Potegowanie(double a, double b)
        {

            return Math.Pow(a, b);
        }
        public double Pierwiastkowanie(double a)
        {
            wynik = Math.Sqrt(a);
            return wynik;
        }
    }
}
