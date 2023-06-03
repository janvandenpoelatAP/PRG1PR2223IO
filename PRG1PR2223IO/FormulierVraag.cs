using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    abstract public class FormulierVraag
    {
          private string tekst;
        public string Tekst
        {
            get { return tekst; }
             set
            {
                if (value is null || value == "")
                {
                    throw new ArgumentException("Vraag mag niet leeg zijn.");
                }
                else
                {
                    tekst = value;

                }
            }
        }

        private string antwoord;
        public string Antwoord
        {
            get { return antwoord; }
             set
            {
                if (value is null)
                {
                    throw new ArgumentException("Antwoord mag nooit volledig ontbreken, moet minstens lege string zijn.");
                }
                this.antwoord = value;
            }
        }

        public FormulierVraag(string tekst)
        {
            this.Tekst = tekst;
        }

        public abstract void ToonVraag();
        public abstract void LeesAntwoord();
    }
}