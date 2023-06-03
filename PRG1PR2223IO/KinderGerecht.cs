using System;
using System.Collections.Generic;
using System.Text;

namespace IndividueleOefeningen
{
    class KinderGerecht : Gerecht
    {
        private static Random ranGen = new Random();
        public KinderGerecht(string naam, double prijs) : base(naam, prijs)
        {

        }
        public override void ToonOpMenu()
        {
            ConsoleColor randomColor = (ConsoleColor) ranGen.Next(1, 16);
            Console.ForegroundColor = randomColor;
            base.ToonOpMenu();
            Console.ResetColor();
        }
    }
}
