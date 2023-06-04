using System;

namespace IndividueleOefeningen
{
    class Afspraak : IRoosterbaar
    {
        private TimeSpan tijdVerplaatsing;
        public TimeSpan TijdVerplaatsing
        {
            get { return tijdVerplaatsing; }
        }
        private TimeSpan duurtijd;
        public TimeSpan Duurtijd
        {
            get { return duurtijd; }
        }
        private TimeSpan terugkeerTijd;
        public TimeSpan TerugkeerTijd
        {
            get { return terugkeerTijd; }
        }
        private string omschrijving;
        public string Omschrijving
        {
            get { return omschrijving; }
            set { omschrijving = value; }
        }
        public Afspraak(TimeSpan tijdVerplaatsing, TimeSpan duurtijd, TimeSpan terugkeerTijd, string omschrijving)
        {
            this.tijdVerplaatsing = tijdVerplaatsing;
            this.duurtijd = duurtijd;
            this.terugkeerTijd = terugkeerTijd;
            this.omschrijving = omschrijving;
        }
        public Afspraak()
        {
            // moet initialiseren via Initialiseer
        }
        public TimeSpan Tijdsduur
        {
            get
            {
                return this.TijdVerplaatsing + this.Duurtijd + this.TerugkeerTijd;
            }
        }
        public void Initialiseer()
        {
            System.Console.WriteLine("Omschrijving?");
            this.omschrijving = Console.ReadLine();
            System.Console.WriteLine("Aantal minuten verplaatsing?");
            this.tijdVerplaatsing = new TimeSpan(0, Convert.ToInt32(Console.ReadLine()), 0);
            System.Console.WriteLine("Aantal minuten afspraak zelf?");
            this.duurtijd = new TimeSpan(0, Convert.ToInt32(Console.ReadLine()), 0);
            System.Console.WriteLine("Aantal minuten om terug te keren?");
            this.terugkeerTijd = new TimeSpan(0, Convert.ToInt32(Console.ReadLine()), 0);
        }
        public DateTime RoosterOm(DateTime referentie)
        {
            return referentie - this.tijdVerplaatsing;
        }
    }
}