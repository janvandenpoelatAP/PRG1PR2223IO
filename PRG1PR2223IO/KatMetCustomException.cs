using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class KatMetCustomException
    {
        private byte leeftijd;

        public byte Leeftijd
        {
            get { return leeftijd; }
            private set
            {
                if (value > 25)
                {
                    throw new KatLeeftijdException(value, 0, 25);
                }
                else
                {
                    leeftijd = value;
                }
            }
        }
        public KatMetCustomException(byte leeftijd)
        {
            this.Leeftijd = leeftijd;
        }
    }
}
