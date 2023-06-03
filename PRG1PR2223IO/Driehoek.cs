using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Driehoek
    {
        private double basis;
        public double Basis
        {
            get
            {
                return basis;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een basis van {value} in te stellen");
                }
                basis = value;
            }
        }
        private double hoogte;
        public double Hoogte
        {
            get
            {
                return hoogte;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Het is verboden een hoogte van {value} in te stellen");
                }
                hoogte = value;
            }
        }
        public double Oppervlakte
        {
            get
            {
                return hoogte * basis / 2;
            }
        }
        public Driehoek(double basis, double hoogte)
        {
            Basis = basis;
            Hoogte = hoogte;
        }

        public Driehoek()
        {
        }
    }
}
