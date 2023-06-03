using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    public class FormulierGetalVraag:FormulierVraag
    {
        private int onderGrens;
        public int OnderGrens
        {
            get { return onderGrens; }
        }

        private int bovenGrens;
        public int BovenGrens
        {
            get { return bovenGrens; }
        }

        public FormulierGetalVraag(string tekst, int onderGrens, int bovenGrens) : base(tekst)
        {
            if (onderGrens > bovenGrens)
            {
                throw new ArgumentException("Ondergrens kan niet hoger zijn dan bovengrens!");
            }
            this.onderGrens = onderGrens;
            this.bovenGrens = bovenGrens;
        }

        public override void LeesAntwoord()
        {
            int? antwoord = null;
            do
            {
                if (!(antwoord is null))
                {
                    Console.WriteLine($"Je antwoord moet tussen {this.OnderGrens} en {this.BovenGrens} liggen.");
                }
                antwoord = Convert.ToInt32(Console.ReadLine());
            } while (antwoord < onderGrens || antwoord > bovenGrens);
            this.Antwoord = antwoord.ToString();



            //int? antwoord = Convert.ToInt32(Console.ReadLine());
            //while(antwoord < onderGrens || antwoord > bovenGrens)
            //{
            //    Console.WriteLine($"Je antwoord moet tussen {this.OnderGrens} en {this.BovenGrens} liggen.");
            //    antwoord = Convert.ToInt32(Console.ReadLine());
            //}
            //this.Antwoord = antwoord.ToString();
        }

        public override void ToonVraag()
        {
            Console.WriteLine(this.Tekst);
            Console.WriteLine($"Dit is een getal tussen {this.OnderGrens} en {this.BovenGrens}");
        }
    }
}