using System;
using System.Collections.Generic;
using System.Globalization;

namespace IndividueleOefeningen {
    class Kalender {
        private string naam;
        public string Naam
        {
            get { return naam; }
        }
        private Dictionary<DateTime,IRoosterbaar> rooster;
        public Dictionary<DateTime,IRoosterbaar> Rooster
        {
            get { return rooster; }
        }
        public Kalender(string naam) {
            this.rooster = new Dictionary<DateTime, IRoosterbaar>();
        }
        public void VoegToe() {
            System.Console.WriteLine("Om wat voor object gaat het?");
            System.Console.WriteLine("1. Afspraak");
            System.Console.WriteLine("2. Taak");
            IRoosterbaar item;
            DateTime begin;
            int antwoord = Convert.ToInt32(Console.ReadLine());
            if (antwoord == 1) {
                System.Console.WriteLine("Omschrijving?");
                string omschrijving = Console.ReadLine();
                System.Console.WriteLine("Aantal minuten verplaatsing?");
                var verplaatsing = new TimeSpan(0,Convert.ToInt32(Console.ReadLine()),0);
                System.Console.WriteLine("Aantal minuten afspraak zelf?");
                var tijdsduur =  new TimeSpan(0,Convert.ToInt32(Console.ReadLine()),0);
                System.Console.WriteLine("Aantal minuten om terug te keren?");
                var terugkeerTijd =  new TimeSpan(0,Convert.ToInt32(Console.ReadLine()),0);
                item = new Afspraak(verplaatsing,tijdsduur,terugkeerTijd,omschrijving);
                System.Console.WriteLine("Wanneer moet dit geroosterd worden?");
                begin = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("nl-BE")) - verplaatsing;
            }
            else {
                System.Console.WriteLine("Omschrijving?");
                string omschrijving = Console.ReadLine();
                System.Console.WriteLine("Aantal minuten werk?");
                var werktijd = new TimeSpan(0,Convert.ToInt32(Console.ReadLine()),0);
                item = new Taak(werktijd, omschrijving);
                System.Console.WriteLine("Wanneer moet dit geroosterd worden?");
                begin = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("nl-BE"));
            }
            this.Rooster[begin] = item;
        }
        public void VoegToeLosgekoppeld() {
            System.Console.WriteLine("Om wat voor object gaat het?");
            System.Console.WriteLine("1. Afspraak");
            System.Console.WriteLine("2. Taak");
            IRoosterbaar item;
            DateTime begin;
            int antwoord = Convert.ToInt32(Console.ReadLine());
            if (antwoord == 1) {
                item = new Afspraak();
            }
            else {
                item = new Taak();
            }
            item.Initialiseer();
            System.Console.WriteLine("Wanneer moet dit geroosterd worden?");
            begin = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("nl-BE"));
            this.Rooster[item.RoosterOm(begin)] = item;
        }
        public void ToonKalender()
        {
            Console.WriteLine($"Rooster: {Naam}");
            foreach (var item in this.Rooster) 
            {
                Console.WriteLine($"{item.Key} : {item.Value.Omschrijving}");
            }
        }
    }
}