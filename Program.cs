using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wejsciowka2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekretarka sekretarka = new Sekretarka("Mati", "Bialek");
            Mechanik mechanik = new Mechanik("Andrzej", "Duda");
            Dyrektor dyrektor = new Dyrektor("Milosz", "Mika");

            Firma uwm = new Firma();
            uwm.pracownicy.Add(sekretarka);
            uwm.pracownicy.Add(mechanik);
            uwm.pracownicy.Add(dyrektor);

            dyrektor.PrzygotujKawe();
            Console.ReadLine(); 



        }
        
        abstract class Osoba
        {
            string imie;
            string nazwisko;

            protected Osoba(string imie, string nazwisko)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;

            }
            void Pracuj()
            {

            }
            public void PrzygotujKawe()
            {
                Console.WriteLine(this.GetType().Name + " " + this.imie + " " + this.nazwisko + "parzy kawe!");
            }
        }
        class Firma
        {
            public List<Osoba> pracownicy = new List<Osoba>();
        }

        class Sekretarka : Osoba
        {
            public Sekretarka(string imie, string nazwisko) : base(imie, nazwisko)
            {

            }
        }

        class Dyrektor : Osoba
        {
            Osoba sekretarka; //pole

            public Dyrektor(string imie, string nazwisko) : base(imie, nazwisko);
            public void PrzypiszSekretarke(Sekretarka sekretarka1)
            {
                this.sekretarka = sekretarka1; //przypisywanie 
            }
            public new void PrzygotujKawe()
            {
                if (this.sekretarka != null)
                {
                    sekretarka.PrzygotujKawe();
                }
                else
                {
                    Console.WriteLine("Dyrektor parzy kawe!");
                }
            }
        }
        class Mechanik : Osoba
        {
            public Mechanik(string imie, string naziwsko): base(imie, naziwsko)
            {

            }
        }

    }
}
