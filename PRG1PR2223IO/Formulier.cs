using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace IndividueleOefeningen
{
    public class Formulier
    {
        private List<FormulierVraag> vragen;
        public ImmutableList<FormulierVraag> Vragen
        {
            get { return vragen.ToImmutableList(); }
        }

        public Formulier(List<FormulierVraag> vragen)
        {
            this.vragen = new List<FormulierVraag>();
            foreach (var vraag in vragen)
            {
                this.vragen.Add(vraag);
            }

        }

        public void VulIn()
        {
            try
            {
                foreach (var vraag in this.vragen)
                {
                    vraag.ToonVraag();
                    vraag.LeesAntwoord();
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Onverwachte fout wordt naar schijf weggeschreven.");
                throw;
            }
        }

        public void Toon()
        {
            Console.WriteLine("Overzicht van de antwoorden:");
            foreach (var item in this.Vragen)
            {
                Console.WriteLine($"Vraag:\t\t{item.Tekst}");
                Console.WriteLine($"Antwoord:\t{item.Antwoord}");
            }
        }
    }
}