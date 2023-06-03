using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    internal abstract class Dier
    {
        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }
        private Geslachten geslacht;
        public Geslachten Geslacht
        {
            get { return geslacht; }
            set { geslacht = value; }
        }
        public abstract ImmutableList<string> Allergieen { get; }
        public abstract void ToonChip();
    }
}
