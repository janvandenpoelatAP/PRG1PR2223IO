using System;
using System.Collections.Generic;
using System.Text;

namespace IndividueleOefeningen
{
    class Veggie : Pizza
    {
        public override double BasisPrijs
        {
            get
            {
                return 6;
            }
        }
        public Veggie(string[] extraToppings) : base(extraToppings)
        {
            this.Ingredienten.Add("spinazie");
            this.Ingredienten.Add("tofu");
            this.Ingredienten.Remove("kaas");
        }
    }
}
