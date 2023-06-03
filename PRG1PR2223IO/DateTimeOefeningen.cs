using System;
using System.Globalization;

namespace IndividueleOefeningen
{
    internal class DateTimeOefeningen
    {
        public static void ToonSubmenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Week programma");
            Console.WriteLine("2. Ticks 2000 programma");
            Console.WriteLine("3. Schrikkeljaar programma");
            Console.WriteLine("4. Array timer programma");
            Console.WriteLine("5. Verjaardag programma");
            int keuze = Convert.ToInt32(Console.ReadLine());

            if (keuze == 1)
            {
                WeekProgramma();
            }
            if (keuze == 2)
            {
                Ticks2000Programma();
            }
            if (keuze == 3)
            {
                SchrikkeljaarProgramma();
            }
            if (keuze == 4)
            {
                ArrayTimerProgramma();
            }
            if (keuze == 5)
            {
                VerjaardagProgramma();
            }
        }
        private static void WeekProgramma()
        {
            Console.WriteLine("Welke dag?");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Welke maand?");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Welk jaar");
            int year = int.Parse(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day);
            CultureInfo belgianCI = new CultureInfo("nl-BE");
            Console.WriteLine($"{dateTime.ToString("dd MMMM yyyy", belgianCI)} is een {dateTime.ToString("dddd", belgianCI)}");
        }
        private static void Ticks2000Programma()
        {
            DateTime year2000 = new DateTime(2000, 1, 1);
            DateTime now = DateTime.Now;
            // optie 1
            TimeSpan difference = now - year2000;
            Console.WriteLine($"Sinds 1 januari 2000 zijn er {difference.Ticks} ticks voorbijgegaan.");
            Console.WriteLine($"Sinds 1 januari 2000 zijn er {now.Ticks - year2000.Ticks} ticks voorbijgegaan.");
        }
        private static void SchrikkeljaarProgramma()
        {
            int counter = 0;
            for (int i = 1799; i <= 2021; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Er zijn {counter} schrikkeljaren tussen 1799 en 2021.");
        }
        private static void ArrayTimerProgramma()
        {
            DateTime start = DateTime.Now;
            int[] myArray = new int[1000000];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }
            DateTime end = DateTime.Now;
            TimeSpan timeSpanDiff = end - start;
            Console.WriteLine($"Het duurt {timeSpanDiff.Milliseconds} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
        }
        private static void VerjaardagProgramma()
        {
            Console.WriteLine("Op welke dag ben je jarig?");
            int dag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In welke maand ben je jarig?");
            int maand = Convert.ToInt32(Console.ReadLine());
            DateTime CurrentDateTime = DateTime.Now;
            int teller = 0;
            while (CurrentDateTime.Day != dag || CurrentDateTime.Month != maand)
            {
                CurrentDateTime = CurrentDateTime.AddDays(1);
                teller++;
            }
            if (teller == 0)
            {
                teller += 1;
            }
            Console.WriteLine($"Er zijn nog {teller} dagen tot je verjaardag.");
        }
    }
}
