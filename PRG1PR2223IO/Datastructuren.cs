using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Datastructuren
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Uit te voeren oefening?");
            Console.WriteLine("1. H13-boodschappen");
            Console.WriteLine("2. H13-telefoonboek met naam en nummer");
            Console.WriteLine("3. H13-telefoonboek met gemeente, naam en nummer");
            Console.WriteLine("4. H13-telefoonboek met naam en nummer en builder");
            int keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Datastructuren.Boodschappen();
                    break;
                case 2:
                    Datastructuren.TelefoonboekNaamNummer();
                    break;
                case 3:
                    Datastructuren.TelefoonboekGemeenteNaamNummer();
                    break;
                case 4:
                    Datastructuren.TelefoonboekNaamNummerMetBuilder();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze!");
                    break;
            }
        }
        public static void Boodschappen()
        {
            Console.WriteLine("We gaan de boodschappenlijst samenstellen.");
            var items = new List<string>();
            string volgendItem;
            do
            {
                Console.WriteLine($"Wat is item {items.Count + 1} op je lijst? Geef een lege regel in om te stoppen.");
                volgendItem = Console.ReadLine();
                if (volgendItem != "")
                {
                    items.Add(volgendItem);
                }
            } while (volgendItem != "");
            items.Sort();
            Console.WriteLine("Dit is je gesorteerde lijst: ");
            // hier moet een klassieke for omdat de indexen meespelen
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i]}");
            }
            Console.WriteLine("Op naar de winkel!");
            string nogWinkelen = "Ja";
            while (nogWinkelen.ToUpper() == "JA")
            {
                Console.WriteLine("Welk item heb je gekocht? Geef de naam exact zoals hij op het lijstje staat.");
                string item = Console.ReadLine();
                if (!items.Contains(item))
                {
                    Console.WriteLine("Dit item bevindt zich niet op de lijst!");
                }
                else
                {
                    items.Remove(item);
                }
                Console.WriteLine("Nog winkelen? (Ja of Nee)");
                nogWinkelen = Console.ReadLine();
            }
            Console.WriteLine("Naar huis met de boodschappen!");
            Console.WriteLine("Volgende items van je lijst ben je vergeten te kopen: ");
            foreach (var item in items)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void TelefoonboekNaamNummer()
        {
            var telefoonboek = new Dictionary<string, string>();
            bool doorgaan;
            do
            {
                Console.WriteLine("Wil je (nog) een naam en nummer inlezen?");
                doorgaan = Console.ReadLine().ToLower() == "ja";
                if (doorgaan)
                {
                    System.Console.WriteLine("Naam?");
                    string naam = Console.ReadLine();
                    System.Console.WriteLine("Nummer?");
                    string nummer = Console.ReadLine();
                    telefoonboek[naam] = nummer;
                }
            } while (doorgaan);
            foreach (var paar in telefoonboek)
            {
                System.Console.WriteLine($"{paar.Key}: {paar.Value}");
            }
        }
        public static void TelefoonboekGemeenteNaamNummer()
        {
            var telefoonboek = new
            Dictionary<string, Dictionary<string, string>>();
            bool doorgaan;
            do
            {
                Console.WriteLine("Wil je (nog) een gemeente, naam en nummer inlezen?");
                doorgaan = Console.ReadLine().ToLower() == "ja";
                if (doorgaan)
                {
                    System.Console.WriteLine("Gemeente?");
                    string gemeente = Console.ReadLine();
                    if (!telefoonboek.ContainsKey(gemeente))
                    {
                        telefoonboek.Add(gemeente, new Dictionary<string,
                        string>());
                    }
                    System.Console.WriteLine("Naam?");
                    string naam = Console.ReadLine();
                    System.Console.WriteLine("Nummer?");
                    string nummer = Console.ReadLine();
                    var gemeenteDeel = telefoonboek[gemeente];
                    gemeenteDeel[naam] = nummer;
                }
            } while (doorgaan);
            foreach (var paar in telefoonboek)
            {
                System.Console.WriteLine($"Gemeente: {paar.Key}");
                foreach (var genestPaar in paar.Value)
                {
                    System.Console.WriteLine($"{genestPaar.Key}: {genestPaar.Value}");
                }
            }
        }
        public static void TelefoonboekNaamNummerMetBuilder()
        {
            var builder = ImmutableDictionary.CreateBuilder<string, string>();
            bool doorgaan;
            do
            {
                Console.WriteLine("Wil je (nog) een naam en nummer inlezen?");
                doorgaan = Console.ReadLine().ToLower() == "ja";
                if (doorgaan)
                {
                    System.Console.WriteLine("Naam?");
                    string naam = Console.ReadLine();
                    System.Console.WriteLine("Nummer?");
                    string nummer = Console.ReadLine();
                    builder[naam] = nummer;
                }
            } while (doorgaan);
            var telefoonboek = builder.ToImmutableDictionary<string, string>();
            foreach (var paar in telefoonboek)
            {
                System.Console.WriteLine($"{paar.Key}: {paar.Value}");
            }
        }
    }
}
