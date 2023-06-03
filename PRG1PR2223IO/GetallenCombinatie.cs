using System;

namespace IndividueleOefeningen
{
    internal class GetallenCombinatie
    {
        public int Getal1;
        public int Getal2;
        public double Som()
        {
            return Getal1 + Getal2;
        }
        public double Verschil()
        {
            return Getal1 - Getal2;
        }
        public double Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            if (Getal2 == 0)
            {
                Console.WriteLine("Fout!");
            }
            return Convert.ToDouble(Getal1) / Getal2;
        }
    }
}
