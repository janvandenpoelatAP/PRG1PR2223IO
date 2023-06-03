using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    abstract class Ketel
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private int inhoud;

        public int Inhoud
        {
            get { return inhoud; }
            set { inhoud = value; }
        }

        private int temperatuur;

        public int Temperatuur
        {
            get { return temperatuur; }
            set { temperatuur = value; }
        }

        public Ketel(string id, int inhoud)
        {
            this.id = id;
            this.Inhoud = inhoud;
        }
    }

    class StoomKetel : Ketel, IStoomVerwarmen, IAfkoelen, IWaterDoseren
    {
        public StoomKetel(string id, int inhoud) : base(id, inhoud)
        {

        }
        public void Afkoelen(int doelTemperatuur)
        {
            Console.WriteLine("Stoomketel - afkoelen");
        }

        public void WaterDoseren(int doelTemperatuur)
        {
            Console.WriteLine("Stoomketel - waterdoseren");
        }

        public void StoomVerwarmen(int doelTemperatuur)
        {
            Console.WriteLine("Stoomketel - stoomverwarmen");
        }
    }
    class KetelZonderDoseren : Ketel, IVerwarmen
    {
        public KetelZonderDoseren(string id, int inhoud) : base(id, inhoud)
        {

        }
        public void Verwarmen(int doelTemperatuur)
        {
            Console.WriteLine("ketel zonder doseren - verwarmen");
        }
    }
    class KetelMetDoseren : Ketel, IVerwarmen, IWaterDoseren
    {
        public KetelMetDoseren(string id, int inhoud) : base(id, inhoud)
        { 

        }
        public void Verwarmen(int doelTemperatuur)
        {
            Console.WriteLine("ketel met doseren - verwarmen");
        }
        public void WaterDoseren(int hoeveelheid)
        {
            Console.WriteLine("ketel met doseren - waterdoseren");
        }
    }
}
