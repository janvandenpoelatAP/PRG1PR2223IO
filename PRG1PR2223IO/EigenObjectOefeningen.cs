using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class EigenObjectOefeningen
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Demonstreer getallen combinatie");
            Console.WriteLine("2. Demonstreer figuren");
            Console.WriteLine("3. Demonstreer figuren met constructor");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                EigenObjectOefeningen.DemonstreerOperaties();
            }
            if (keuze == 2)
            {
                EigenObjectOefeningen.DemonstreerFiguren();
            }
            if (keuze == 3)
            {
                EigenObjectOefeningen.DemonstreerFigurenMetConstructor();
            }
        }
        public static void DemonstreerOperaties()
        {
            GetallenCombinatie paar1 = new GetallenCombinatie();
            paar1.Getal1 = 12;
            paar1.Getal2 = 34;
            Console.WriteLine("Paar:" + paar1.Getal1 + ", " + paar1.Getal2);
            Console.WriteLine("Som = " + paar1.Som());
            Console.WriteLine("Verschil = " + paar1.Verschil());
            Console.WriteLine("Product = " + paar1.Product());
            Console.WriteLine("Quotient = " + paar1.Quotient());
        }
        private static void DemonstreerFiguren()
        {
            Rechthoek rechthoek1 = new Rechthoek(); 
            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek1.Breedte = -1;
            rechthoek1.Breedte = 0;
            rechthoek1.Breedte = 2.2;
            rechthoek1.Hoogte = 1.5;
            rechthoek2.Breedte = 3;
            rechthoek2.Hoogte = 1;
            Console.WriteLine($"Een rechthoek met breedte {rechthoek1.Breedte:F1} en hoogte {rechthoek1.Hoogte:F1} heeft een oppervlakte van {rechthoek1.Oppervlakte:F1}");
            Console.WriteLine($"Een rechthoek met breedte {rechthoek2.Breedte:F1} en hoogte {rechthoek2.Hoogte:F1} heeft een oppervlakte van {rechthoek2.Oppervlakte:F1}");   
            Driehoek driehoek1 = new Driehoek();
            Driehoek driehoek2 = new Driehoek();
            driehoek1.Basis = 3;
            driehoek1.Hoogte = 1;
            driehoek2.Basis = 2;
            driehoek2.Hoogte = 2;
            Console.WriteLine($"Een driehoek met breedte {driehoek1.Basis:F1} en hoogte {driehoek1.Hoogte:F1} heeft een oppervlakte van {driehoek1.Oppervlakte:F1}");
            Console.WriteLine($"Een driehoek met breedte {driehoek2.Basis:F1} en hoogte {driehoek2.Hoogte:F1} heeft een oppervlakte van {driehoek2.Oppervlakte:F1}");
        }
        private static void DemonstreerFigurenMetConstructor()
        {
            Rechthoek rechthoek3 = new Rechthoek(-1, 2);
            Rechthoek rechthoek4 = new Rechthoek(0, 2);
            Rechthoek rechthoek1 = new Rechthoek(2.2, 1.5);
            Rechthoek rechthoek2 = new Rechthoek(3, 1);
            Console.WriteLine($"Een rechthoek met breedte {rechthoek1.Breedte:F1} en hoogte {rechthoek1.Hoogte:F1} heeft een oppervlakte van {rechthoek1.Oppervlakte:F1}");
            Console.WriteLine($"Een rechthoek met breedte {rechthoek2.Breedte:F1} en hoogte {rechthoek2.Hoogte:F1} heeft een oppervlakte van {rechthoek2.Oppervlakte:F1}");
            Driehoek driehoek1 = new Driehoek(3, 1);
            Driehoek driehoek2 = new Driehoek(2, 2);
            Console.WriteLine($"Een driehoek met breedte {driehoek1.Basis:F1} en hoogte {driehoek1.Hoogte:F1} heeft een oppervlakte van {driehoek1.Oppervlakte:F1}");
            Console.WriteLine($"Een driehoek met breedte {driehoek2.Basis:F1} en hoogte {driehoek2.Hoogte:F1} heeft een oppervlakte van {driehoek2.Oppervlakte:F1}");
        }
    }
}
