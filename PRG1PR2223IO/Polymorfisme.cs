using IndividueleOefeningen;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG1PR2223IO
{
    internal class Polymorfisme
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1: Autoconstructeur ");
            Console.WriteLine("2: Grootkeuken ");
            Console.WriteLine("3: DemonstreerFoutafhandelingOverflowZonderException ");
            Console.WriteLine("4: DemonstreerFoutafhandelingOverflowMetException ");
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
                    //Polymorfisme.DemonstreerFoutafhandelingOverflowZonderException();
                    break;
                case 4:
                    //Polymorfisme.DemonstreerFoutafhandelingOverflowMetException();
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
    }
}
