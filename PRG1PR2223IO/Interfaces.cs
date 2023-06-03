using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace IndividueleOefeningen
{
    class Interfaces
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            System.Console.WriteLine("1. h17-zoek-grootste");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    //Interfaces.DemonstreerZoekGrootste();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
        }

        private static IComparable ZoekGrootste(List<IComparable> vergelijkbareObjecten) {
            IComparable grootste = null;
            foreach (var item in vergelijkbareObjecten)
            {
                if (grootste is null || item.CompareTo(grootste) == 1) {
                    grootste = item;
                }
            }
            return grootste;
        }

        private static void DemonstreerZoekGrootste() 
        {
        //    Pizza pizza1 = new Margarita(new string[] {"extra kaas"});
        //    Pizza pizza2 = new Veggie(new string[] {"extra kaas", "extra peper", "kappertjes"});
        //    Pizza pizza3 = new Margarita(new string[0]);
        //    List<IComparable> pizzas = new List<IComparable> { pizza1, pizza2, pizza3 };
        //    IComparable grootste = ZoekGrootste(pizzas);
        //    ((Pizza) grootste).ToonIngredienten();
        }

    }
}
