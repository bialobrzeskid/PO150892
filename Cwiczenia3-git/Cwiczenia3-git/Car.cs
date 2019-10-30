using System.Windows.Forms;

namespace Cwiczenia3_git
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        static int iloscKol;

        private Car()
        {

        }

        private Car(double pojemnosc, string marka)
        {
            this.pojemnoscSilnika = 2;
            this.marka = "Jakas marka ";

        }

        static Car() //statyczny konstruktor 
        {
            iloscKol = 4;
        }

        public static Car Create()
        {
            Car obCar = new Car();
            return obCar;
        }

        ~Car()
        {
            MessageBox.Show("zwalniam pamiec");
        }
    }
}
