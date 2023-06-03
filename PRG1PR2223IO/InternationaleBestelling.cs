using System;
using System.Collections.Generic;
using System.Text;

namespace les7
{
    class InternationaleBestelling : Bestelling
    {
        public InternationaleBestelling(uint aantal, double basisPrijs) : base(aantal, basisPrijs)
        {
        }

        public override double TotaalPrijs
        {
            get
            {
                double resultaat;
                resultaat = Aantal * BasisPrijs * 1.1;
                if (this.Aantal >= 100)
                {
                    resultaat -= 1000;
                }
                return resultaat;
            }
        }
    }
}
