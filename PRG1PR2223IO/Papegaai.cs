using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal class Papegaai : Dier
    {
        private List<string> allergieen = new List<string>();
        public override ImmutableList<string> Allergieen
        {
            get
            {
                return allergieen.ToImmutableList<string>();
            }
        }
        public override void ToonChip()
        {
            Console.WriteLine("Papegaaien worden niet gechipt.");
        }
    }
}
