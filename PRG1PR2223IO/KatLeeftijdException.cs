using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    public class KatLeeftijdException:ArgumentException
    {
        private byte meegegevenWaarde;
        public byte MeegegevenWaarde
        {
            get { return meegegevenWaarde; }
        }

        private byte laagstMogelijkeWaarde;
        public byte LaagstMogelijkeWaarde
        {
            get { return laagstMogelijkeWaarde; }
        }

        private byte hoogstMogelijkeWaarde;
        public byte HoogstMogelijkeWaarde
        {
            get { return hoogstMogelijkeWaarde; }
        }

        public KatLeeftijdException(byte meegegeven, byte laagst, byte hoogst)
        {
            this.meegegevenWaarde = meegegeven;
            this.laagstMogelijkeWaarde = laagst;
            this.hoogstMogelijkeWaarde = hoogst;
        }
    }
}