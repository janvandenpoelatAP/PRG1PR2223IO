using System;
using System.Collections.Generic;
using System.Text;

namespace IndividueleOefeningen
{
    abstract class Pizza
    {
        protected List<string> Ingredienten;
        public Pizza(string[] extraToppings)
        {
            this.Ingredienten = new List<string> { "deeg", "tomatensaus", "kaas" };
            foreach (var topping in extraToppings)
            {
                this.Ingredienten.Add(topping);
            }
        }
        public abstract double BasisPrijs
        {
            get;
        }
        public double Prijs
        {
            get
            {
                return this.BasisPrijs + (this.Ingredienten.Count * 0.5);
            }
        }
        public void ToonIngredienten()
        {
            foreach (var ingredient in Ingredienten)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
