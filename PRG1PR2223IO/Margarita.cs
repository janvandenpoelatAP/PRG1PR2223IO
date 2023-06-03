using System;
using System.Collections.Generic;
using System.Text;

namespace IndividueleOefeningen
{
    class Margarita : Pizza
    {
        public override double BasisPrijs
        {
            get
            {
                return 5;
            }
        }
        public Margarita(string[] extraToppings) : base(extraToppings)
        {
            this.Ingredienten.Add("mozzarella");
        }
    }
}
