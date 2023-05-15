using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class PhysioRepo
    {
        // Privat liste over fysioterapeuter
        private List<Physio> _physios = new List<Physio>();

        // Public liste, der bruges til at tilføje eller hente fysioterapeuter fra den private liste
        public List<Physio> Physios
		{
			get { return _physios; }
			set { _physios = value; }
		}

        // AddPhysio() metoden tilføjer en ny fysioterapuet til listen 
        public void AddPhysio(Physio physio)
        {
            if (physio != null) {
                _physios.Add(physio);
            }
            
        }

        // DeletePhysio() metoden sletter en fysioterapeut fra listen, hvis listen indeholder en person med et matchende fornavn
        public void DeletePhysio(string name)
        {
            foreach (Physio physio in _physios) {
                if(physio.FirstName == name) {
                    _physios.Remove(physio);
                }
            }
        }

        // GetPhysio() kigger listen igennem efter en fysioterapeut med matchende fornavn og returnerer fysioterapeuten
        public Physio GetPhysio(string name)
        {
            Physio returnPhysio = null;
            foreach (Physio physio in _physios) {
                if(physio.FirstName == name) {
                    returnPhysio = physio;
                }
            }
            return returnPhysio;
        }


        // GetAll() opretter en ny liste og kalder hvert fysioterapeut-objekts ToString()-metode og
        // tilføjer det til listen og returnerer listen over alle fysioterapeuter
        public List<string> GetAll()
        {
            List<string> physios = new List<string>();

            foreach (Physio physio in _physios) {
                physios.Add(physio.ToString());
            }
            return physios;
        }

    }
}
