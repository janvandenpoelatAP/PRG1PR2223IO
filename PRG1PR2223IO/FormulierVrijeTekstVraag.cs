using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    public class FormulierVrijeTekstVraag:FormulierVraag
    {
         public FormulierVrijeTekstVraag(string tekst) : base(tekst)
        {
        }

        public override void LeesAntwoord()
        {
            this.Antwoord = Console.ReadLine();
        }

        public override void ToonVraag()
        {
            Console.WriteLine(this.Tekst);
            Console.WriteLine($"Sluit af met ENTER.");
        }
    }
}