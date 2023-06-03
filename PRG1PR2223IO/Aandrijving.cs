using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    class AandrijvingElektrisch : IAandrijving
    {
        public void EnergieToevoegen()
        {
            throw new NotImplementedException();
        }

        public void Versnellen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Versnellen - Elektrisch");
        }

        public void Vertragen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Vertragen - Elektrisch");
        }

        //void IAandrijving.EnergieToevoegen()
        //{
        //    Console.WriteLine("Versnellen - Elektrisch");
        //}
    }
    class AandrijvingBenzine : IAandrijving
    {
        void IAandrijving.Versnellen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Versnellen - Benzine");
        }

        void IAandrijving.Vertragen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Vertragen - Benzine");
        }

        void IAandrijving.EnergieToevoegen()
        {
            Console.WriteLine("Versnellen - Benzine");
        }
    }
    class AandrijvingCNG : IAandrijving
    {
        void IAandrijving.Versnellen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Versnellen - CNG");
        }

        void IAandrijving.Vertragen(int kmPerUurPerSeconde, int doelSnelheid)
        {
            Console.WriteLine("Vertragen - CNG");
        }

        void IAandrijving.EnergieToevoegen()
        {
            Console.WriteLine("Versnellen - CNG");
        }
    }
}
