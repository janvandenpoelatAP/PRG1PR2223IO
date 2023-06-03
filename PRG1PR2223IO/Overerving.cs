using les7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Overerving
    {
        static public void ToonSubMenu()
        {
            int keuze;
            while (true)
            {
                Console.WriteLine("Uit te voeren oefening?");
                Console.WriteLine("1. DemonstreerDieren");
                Console.WriteLine("2. DemonstreerBrieven");
                Console.WriteLine("3. DemonstreerBestellingen");
                Console.WriteLine("4. DemonstreerPizzas");
                Console.WriteLine("5. DemonstreerGerechten");
                keuze = int.Parse(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        DemonstreerDieren();
                        break;
                    case 2:
                        DemonstreerBrieven();
                        break;
                    case 3:
                        DemonstreerBestellingen();
                        break;
                    case 4:
                        DemonstreerPizzas();
                        break;
                    case 5:
                        DemonstreerGerechten();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze!");
                        break;
                }
            }
        }
        public static void DemonstreerDieren()
        {
            var patientjes = new List<Dier>();
            var dier1 = new Hond();
            dier1.IndividueleAllergieen = new List<string> { "vis" };
            dier1.Chip = "ABC123";
            dier1.Geslacht = Geslachten.Vrouwelijk;
            dier1.Naam = "Misty";
            patientjes.Add(dier1);
            var dier2 = new Papegaai();
            dier2.Geslacht = Geslachten.Mannelijk;
            dier2.Naam = "Coco";
            patientjes.Add(dier2);
            foreach (var dier in patientjes)
            {
                Console.WriteLine(dier.Naam);
                Console.WriteLine(dier.Geslacht);
                Console.WriteLine("allergieën:");
                foreach (var allergie in dier.Allergieen)
                {
                    Console.WriteLine(allergie);
                }
                dier.ToonChip();
            }
        }
        public static void DemonstreerBrieven()
        {
            Console.WriteLine("Wil je nog een brief toevoegen (ja/nee)?");
            string antwoord = Console.ReadLine();
            List<AangetekendeBrief> brieven = new List<AangetekendeBrief>();
            while (antwoord.ToLower() == "ja")
            {
                Console.WriteLine("Wat voor brief wil je toevoegen?");
                Console.WriteLine("1. standaard");
                Console.WriteLine("2. internationaal");
                Console.WriteLine(("3. hoge prioriteit "));
                Console.WriteLine("4. geen enkele, we zijn klaar met invoeren");
                string keuze = Console.ReadLine();
                if (keuze == "4")
                {
                    antwoord = "nee";
                }
                else
                {
                    Console.WriteLine("Hoe ver moet deze brief");
                    double afstand = Convert.ToDouble(Console.ReadLine());
                    if (keuze == "1")
                    {
                        AangetekendeBrief brief = new AangetekendeBrief();
                        brief.ReisAfstand = afstand;
                        brieven.Add(brief);
                    }
                    else if (keuze == "2")
                    {
                        InternationaleAangetekendeBrief interBrief = new InternationaleAangetekendeBrief();
                        interBrief.ReisAfstand = afstand;
                        brieven.Add(interBrief);
                    }
                    else if (keuze == "3")
                    {
                        HogePrioriteitsAangetekendeBrief priorBrief = new HogePrioriteitsAangetekendeBrief();
                        priorBrief.ReisAfstand = afstand;
                        brieven.Add(priorBrief);
                    }
                }
            }
            int counter = 1;
            foreach (var brief in brieven)
            {
                Console.WriteLine($"Brief {counter}: {brief.ReisAfstand}km, reistijd {brief.Reistijd} dagen, kostprijs {brief.Kostprijs}");
                counter++;
            }
        }
        public static void DemonstreerBestellingen()
        {
            Console.WriteLine("Aantal stuks?");
            uint aantal = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Basisprijs?");
            double basisPrijs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gewone bestelling (1) of internationale bestelling (2)?");
            int antwoord = Convert.ToInt32(Console.ReadLine());
            Bestelling bestelling = null;
            if (antwoord == 1)
            {
                bestelling = new Bestelling(aantal, basisPrijs);
            }
            else if (antwoord == 2)
            {
                bestelling = new InternationaleBestelling(aantal, basisPrijs);
            }
            Console.WriteLine($"Totaalprijs: {bestelling.TotaalPrijs}");
        }
        public static void DemonstreerPizzas()
        {
            var margarita = new Margarita(new string[0]);
            Console.WriteLine($"Een margarita zonder extra's kost: {margarita.Prijs}");
            Console.WriteLine("De ingrediënten zijn:");
            margarita.ToonIngredienten();
            var veggie = new Veggie(new string[0]);
            Console.WriteLine($"Een veggie zonder extra's kost: {veggie.Prijs}");
            Console.WriteLine("De ingrediënten zijn:");
            veggie.ToonIngredienten();
        }
        public static void DemonstreerGerechten()
        {
            var paling = new Gerecht("Paling in't groen", 22);
            var volauvent = new KinderGerecht("Vol-au-vent", 11);
            var waterzooi = new Gerecht("Waterzooi", 22);
            var kabouterschnitzel = new KinderGerecht("Kabouterschnitzel", 12);
            var gerechten = new List<Gerecht> { paling, volauvent, waterzooi, kabouterschnitzel };
            foreach (var item in gerechten)
            {
                item.ToonOpMenu();
            }
        }
    }
}
