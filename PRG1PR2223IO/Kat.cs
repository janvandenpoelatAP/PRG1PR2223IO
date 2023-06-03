using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Kat
    {
        private byte leeftijd;

        public byte Leeftijd
        {
            get { return leeftijd; }
            private set
            {
                if (value > 25)
                {
                    throw new ArgumentException("Deze kat is te oud!");
                }
                else
                {
                    leeftijd = value;
                }
            }
        }

        public Kat(byte leeftijd)
        {
            this.Leeftijd = leeftijd;
        }
    }
}
