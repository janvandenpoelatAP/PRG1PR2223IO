using System;

namespace IndividueleOefeningen
{
    class Taak : IRoosterbaar
    {
        private TimeSpan werktijd;
        public TimeSpan Werktijd
        {
            get { return werktijd; }
        }

        private string omschrijving;
        public string Omschrijving
        {
            get { return omschrijving; }
        }

        public Taak(TimeSpan werktijd, string omschrijving)
        {
            this.werktijd = werktijd;
            this.omschrijving = omschrijving;
        }

        public Taak()
        {

        }

        public TimeSpan Tijdsduur
        {
            get
            {
                return this.Werktijd;
            }
        }

        public void Initialiseer()
        {
            System.Console.WriteLine("Omschrijving?");
            string omschrijving = Console.ReadLine();
            System.Console.WriteLine("Aantal minuten werk?");
            this.werktijd = new TimeSpan(0, Convert.ToInt32(Console.ReadLine()), 0);
        }

        public DateTime RoosterOm(DateTime referentie)
        {
            return referentie;
        }
    }
}