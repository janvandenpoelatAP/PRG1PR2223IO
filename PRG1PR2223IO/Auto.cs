using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    class Auto
    {
        private string  autoType;

        public string AutoType
        {
            get { return autoType; }
            set { autoType = value; }
        }

        private IAandrijving aandrijving;

        public IAandrijving Aandrijving
        {
            get { return aandrijving; }
            set { aandrijving = value; }
        }


        public Auto(string autoType, IAandrijving aandrijving)
        {
            this.AutoType = AutoType;
            this.Aandrijving = aandrijving;
        }
    }
}
