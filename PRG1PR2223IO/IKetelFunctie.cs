using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    interface IStoomVerwarmen
    {
        void StoomVerwarmen(int doelTemperatuur);
    }
    interface IVerwarmen
    {
        void Verwarmen(int doelTemperatuur);
    }
    interface IAfkoelen
    {
        void Afkoelen(int doelTemperatuur);
    }
    interface IWaterDoseren
    {
        void WaterDoseren(int hoeveelheid);
    }
}
