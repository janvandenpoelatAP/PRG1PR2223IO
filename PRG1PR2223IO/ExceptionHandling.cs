using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class ExceptionHandling
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1: DemonstreerFoutafhandelingWeekdagenZonderException ");
            Console.WriteLine("2: DemonstreerFoutafhandelingWeekdagenMetException ");
            Console.WriteLine("3: DemonstreerFoutafhandelingOverflowZonderException ");
            Console.WriteLine("4: DemonstreerFoutafhandelingOverflowMetException ");
            Console.WriteLine("5: DemonstreerKeuzeElement ");
            Console.WriteLine("6: DemonstreerKeuzeElementExtraVoorzichtig ");
            Console.WriteLine("7: DemonstreerLeeftijdKat ");
            Console.WriteLine("8: DemonstreerLeeftijdKatMetResourceCleanup ");
            Console.WriteLine("9: DemonstreerFileHelper ");
            Console.WriteLine("10: DemonstreerLeeftijdKatMetCustomException ");
            Console.WriteLine("11: DemonstreerFormulieren ");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    ExceptionHandling.DemonstreerFoutafhandelingWeekdagenZonderException();
                    break;
                case 2:
                    ExceptionHandling.DemonstreerFoutafhandelingWeekdagenMetException();
                    break;
                case 3:
                    ExceptionHandling.DemonstreerFoutafhandelingOverflowZonderException();
                    break;
                case 4:
                    ExceptionHandling.DemonstreerFoutafhandelingOverflowMetException();
                    break;
                case 5:
                    ExceptionHandling.DemonstreerKeuzeElement();
                    break;
                case 6:
                    ExceptionHandling.DemonstreerKeuzeElementExtraVoorzichtig();
                    break;
                case 7:
                    ExceptionHandling.DemonstreerLeeftijdKat();
                    break;
                case 8:
                    ExceptionHandling.DemonstreerLeeftijdKatMetResourceCleanup();
                    break;
                case 9:
                    ExceptionHandling.FileHelper();
                    break;
                case 10:
                    ExceptionHandling.DemonstreerLeeftijdKatMetCustomException();
                    break;
                case 11:
                    ExceptionHandling.DemonstreerFormulieren();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
        }

        private static void DemonstreerFoutafhandelingWeekdagenZonderException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
        private static void DemonstreerFoutafhandelingWeekdagenMetException()
        {
            string[] arr = new string[5];
            arr[0] = "Vrijdag";
            arr[1] = "Maandag";
            arr[2] = "Dinsdag";
            arr[3] = "Woensdag";
            arr[4] = "Donderdag";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(arr[i].ToString());
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("De index gaat buiten de grenzen van de array.");
            }

        }
        private static void DemonstreerFoutafhandelingOverflowZonderException()
        {
            int num1, num2;
            // uint of int is ook oké
            ushort resultaat;
            num1 = 30;
            num2 = 60;
            resultaat = Convert.ToUInt16(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
        }
        private static void DemonstreerFoutafhandelingOverflowMetException()
        {
            int num1, num2;
            byte resultaat;
            num1 = 30;
            num2 = 60;
            try
            {
                resultaat = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, resultaat);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Het getal is te groot om te converteren naar het gewenste formaat.");
            }
        }
        private static void DemonstreerKeuzeElement()
        {
            Random ranGen = new Random();
            int[] getallen = { ranGen.Next(1, 11), ranGen.Next(1, 11), ranGen.Next(1, 11) };
            do
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                try
                {
                    Console.WriteLine($"Het getal is {getallen[Convert.ToInt32(Console.ReadLine())]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Die index hebben we niet!");
                }
                finally
                {
                    Console.WriteLine("Wil je doorgaan?");
                }
            } while (Console.ReadLine().ToLower() == "ja");
        }
        private static void DemonstreerKeuzeElementExtraVoorzichtig()
        {
            Random ranGen = new Random();
            int[] getallen = { ranGen.Next(1, 11), ranGen.Next(1, 11), ranGen.Next(1, 11) };
            do
            {
                Console.WriteLine("Geef de index van het getal dat je wil zien");
                try
                {
                    Console.WriteLine($"Het getal is {getallen[Convert.ToInt32(Console.ReadLine())]}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Die index hebben we niet!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Daar kan ik geen getal van maken.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Dat getal is te groot om te verwerken.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Er is iets misgelopen, meer kan ik niet zeggen.");
                }
                finally
                {
                    Console.WriteLine("Wil je doorgaan?");
                }
            } while (Console.ReadLine().ToLower() == "ja");
        }
        private static void DemonstreerLeeftijdKat()
        {
            try
            {
                Kat kat = new Kat(27);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static void DemonstreerLeeftijdKatMetResourceCleanup()
        {
            Random ranGen = new Random();
            List<Kat> katten = new List<Kat>();
            try
            {
                for (int i = 1; i <= 20; i++)
                {
                    Kat kat = new Kat((byte)ranGen.Next(0, 31));
                    katten.Add(kat);
                }
                Console.WriteLine("De volledige lijst met katten is aangemaakt!");
            }
            catch (ArgumentException e)
            {
                //Console.WriteLine(e.Message);
                Console.WriteLine("Het is niet gelukt :-(");
            }
            finally
            {
                katten.Clear();
            }
        }
        private static void DemonstreerLeeftijdKatMetCustomException()
        {
            try
            {
                KatMetCustomException kat = new KatMetCustomException(37);
            }
            catch (KatLeeftijdException exc)
            {
                Console.WriteLine($"{exc.MeegegevenWaarde} is geen geldige leeftijd. De laagst mogelijke leeftijd is {exc.LaagstMogelijkeWaarde} " +
                    $"jaar, de hoogst mogelijke leeftijd is {exc.HoogstMogelijkeWaarde} jaar.");
            }
        }
        private static void FileHelper()
        {
            string data = "";
            Console.WriteLine("Welke file wil je lezen?");
            string pad = Console.ReadLine();
            try
            {
                data = File.ReadAllText(pad);
            }
            catch (FileNotFoundException)
            {
                data = "File kon niet gevonden worden.";
            }
            catch (UnauthorizedAccessException)
            {
                data = "File bestaat, maar kon niet gelezen worden. Mogelijk heb je geen toegangsrechten.";
            }
            catch (Exception)
            {
                data = "Er is iets misgelopen. Neem een screenshot van wat je aan het doen was en contacteer de helpdesk.";
            }
            finally
            {
                Console.WriteLine(data);
            }
        }
        private static void DemonstreerFormulieren()
        {
            var vraag1 = new FormulierGetalVraag("Hoe oud ben je?", 18, 130);
            var vraag2 = new FormulierVrijeTekstVraag("Hoe ziet jouw ideale dag eruit?");
            var vraag3 = new FormulierGetalVraag("Hoe veel personen heb je ten laste?", 0, 10);
            var vraag4 = new FormulierVrijeTekstVraag("Wie is je idool?");
            Formulier f1 = new Formulier(new List<FormulierVraag> { vraag1, vraag2 });
            Formulier f2 = new Formulier(new List<FormulierVraag> { vraag3, vraag4 });
            try
            {
                f1.VulIn();
                f1.Toon();
            }
            catch (Exception)
            {
                Console.WriteLine("We zullen dit formulier weggooien.");
                f1 = null;
            }
            try
            {
                f2.VulIn();
                f2.Toon();
            }
            catch (Exception)
            {
                Console.WriteLine("We zullen dit formulier weggooien.");
                f2 = null;
            }
        }
    }
}
