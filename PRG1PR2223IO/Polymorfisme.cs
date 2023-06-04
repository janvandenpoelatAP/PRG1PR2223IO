using IndividueleOefeningen;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Polymorfisme
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1: Demonstreer Autoconstructeur ");
            Console.WriteLine("2: Demonstreer Grootkeuken ");
            Console.WriteLine("3: Demonstreer Rooster");
            Console.WriteLine("4: Demonstreer Kalender 1");
            Console.WriteLine("5: Demonstreer Kalender 2");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Polymorfisme.Autoconstructeur();
                    break;
                case 2:
                    Polymorfisme.Grootkeuken();
                    break;
                case 3:
                    Polymorfisme.Rooster();
                    break;
                case 4:
                    Polymorfisme.DemonsteerKalender1();
                    break;
                case 5:
                    Polymorfisme.DemonsteerKalender2();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
        }
        private static void Autoconstructeur()
        {
            IAandrijving aandrijvingBenzine = new AandrijvingBenzine();
            IAandrijving aandrijvingElektrisch = new AandrijvingElektrisch();

            Auto auto1 = new Auto("ZX300", aandrijvingBenzine);
            auto1.Aandrijving.Versnellen(1, 120);
            auto1.Aandrijving = aandrijvingElektrisch;
            auto1.Aandrijving.Versnellen(1, 120);
        }
        private static void Grootkeuken()
        {
            List<Ketel> ketels = new List<Ketel>();
            var ketel1 = new StoomKetel("K1", 300);
            var ketel2 = new StoomKetel("K2", 300);
            var ketel3 = new KetelZonderDoseren("K3", 300);
            var ketel4 = new KetelZonderDoseren("K4", 300);
            var ketel5 = new KetelMetDoseren("K5", 300);
            var ketel6 = new KetelMetDoseren("K6", 300);

            ketel1.StoomVerwarmen(100);
            ketel1.Afkoelen(50);
            ketel1.WaterDoseren(50);
            ketel5.WaterDoseren(20);

            ketels.Add(ketel1);
            ketels.Add(ketel2);
            ketels.Add(ketel3);
            ketels.Add(ketel4);
            ketels.Add(ketel5);
            ketels.Add(ketel6);
        }
        private static void Rooster()
        {
            IRoosterbaar blok1 = new Afspraak(new TimeSpan(0, 20, 0), new TimeSpan(1, 0, 0), new TimeSpan(0, 20, 0), "tandarts");
            IRoosterbaar blok2 = new Taak(new TimeSpan(2, 0, 0), "dagelijkse oefeningen OOP");
            System.Console.WriteLine($"Totale kalendertijd: {(blok1.Tijdsduur + blok2.Tijdsduur).Hours}u{(blok1.Tijdsduur + blok2.Tijdsduur).Minutes}m");
        }
        private static void DemonsteerKalender1()
        {
            Kalender kalender = new Kalender("DemonstratieKalender");
            string antwoord = string.Empty;
            do
            {
                kalender.VoegToe();
                Console.WriteLine("Wil je nog een item toevoegen?");
                antwoord = Console.ReadLine();
            } while (antwoord.ToUpper() == "JA");
            kalender.ToonKalender();
        }
        public static void DemonsteerKalender2()
        {
            Kalender kalender = new Kalender("DemonstratieKalender");
            string antwoord = string.Empty;
            do
            {
                kalender.VoegToeLosgekoppeld();
                Console.WriteLine("Wil je nog een item toevoegen?");
                antwoord = Console.ReadLine();
            } while (antwoord.ToUpper() == "JA");
            kalender.ToonKalender();
        }
    }
}
