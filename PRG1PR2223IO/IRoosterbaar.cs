using System;

namespace IndividueleOefeningen {
    interface IRoosterbaar {
        public TimeSpan Tijdsduur {
            get;
        }

        public string Omschrijving {
            get;
        }

        public void Initialiseer();

        public DateTime RoosterOm(DateTime referentie);
    }
}