using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Rechthoek
    {
		private double breedte;
		public double Breedte
		{
			get 
			{ 
				return breedte; 
			}
			set 
			{
				if (value <= 0)
				{
					Console.WriteLine($"Het is verboden een breedte van {value} in te stellen");
				}
				breedte = value; 
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
				return hoogte * breedte; 
			}
		}
		public Rechthoek(double breedte, double hoogte)
		{
			Breedte = breedte;
			Hoogte = hoogte;
		}
		public Rechthoek()
		{
		}
	}
}
