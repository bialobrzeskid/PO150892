namespace ConsoleApp1
{
    class Car
    {
     
    
        public int RokProdukcji;
        public string Marka;

        private string model;
        private int iloscDrzwi, pojemnoscSilnika;
        public int srednieSpalanie;

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = (srednieSpalanie * dlugoscTrasy) / 100;
            return spalanie;
        }

        public double ObliczKosztprzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double kosztPrzejazdu = ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            return kosztPrzejazdu;
        }

        
    }
}

