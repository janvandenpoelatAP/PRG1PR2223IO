using System;
using System.Collections.Generic;
using System.Text;

namespace IndividueleOefeningen
{
    class Gerecht
    {
        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        private double prijs;
        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }
        public Gerecht(string naam, double prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }
        public virtual void ToonOpMenu()
        {
            Console.WriteLine($"{this.Naam.PadRight(35,' ')}{this.Prijs:F2}");
        }
    }
}
