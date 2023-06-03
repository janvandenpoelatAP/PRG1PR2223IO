using System;
using System.Collections.Generic;
using System.Text;

namespace les7
{
    class Bestelling
    {
        private uint aantal;

        public uint Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }

        protected double BasisPrijs;

        public virtual double TotaalPrijs
        {
            get
            {
                return Aantal * BasisPrijs;
            }
        }

        public Bestelling(uint aantal, double basisPrijs)
        {
            this.Aantal = aantal;
            this.BasisPrijs = basisPrijs;
        }

    }
}
