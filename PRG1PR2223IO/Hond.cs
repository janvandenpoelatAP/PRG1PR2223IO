using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Hond : Dier
    {
        private string chip;
        public string Chip
        {
            get { return chip; }
            set { chip = value; }
        }
        private List<string> individueleAllergieen = new List<string>();
        public List<string> IndividueleAllergieen
        {
            get { return individueleAllergieen; }
            set { individueleAllergieen = value; }
        }
        private List<string> allergieen = new List<string>();
        public override ImmutableList<string> Allergieen
        {
            get
            {
                var tijdelijkeLijst = new List<string>();
                foreach (var allergie in individueleAllergieen)
                {
                    tijdelijkeLijst.Add(allergie);
                }
                tijdelijkeLijst.Add("druiven");
                tijdelijkeLijst.Add("noten");
                tijdelijkeLijst.Add("chocolade");
                tijdelijkeLijst.Add("avocado");
                return tijdelijkeLijst.ToImmutableList<string>();
            }
        }
        public override void ToonChip()
        {
            Console.WriteLine($"De chip is: {Chip}");
        }
    }
}
