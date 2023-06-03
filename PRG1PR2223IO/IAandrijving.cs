﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividueleOefeningen
{
    interface IAandrijving
    {
        void EnergieToevoegen();
        void Vertragen(int kmPerUurPerSeconde, int doelSnelheid);
        void Versnellen(int kmPerUurPerSeconde, int doelSnelheid);
    }
}
