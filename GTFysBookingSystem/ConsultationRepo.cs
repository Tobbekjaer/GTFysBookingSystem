using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class ConsultationRepo
    {
        // Privat liste over konsultationer
        private List<Consultation> _consultations = new List<Consultation>();

        // Public liste, der bruges til at tilføje eller hente konsultationer fra den private liste
        public List<Consultation> Consultations
		{
			get { return _consultations; }
			set { _consultations = value; }
		}

        // AddConsultation() metoden tilføjer en ny konsultation til listen 
        public void AddConsultation(Consultation consultation)
        {
            _consultations.Add(consultation);
        }

        // GetAvailableTimes() metoden... skal returnere en liste/oversigt over ledige tider

        // GetAllConsultations() opretter en ny liste og kalder hvert konsultations-objekts ToString()-metode og
        // tilføjer det til listen og returnerer listen over alle konsultationer
        public List<string> GetAll()
        {
            List<string> returnConsultations = new List<string>();
            foreach(Consultation consultation in _consultations) {
                returnConsultations.Add(consultation.ToString());  
            }
            return returnConsultations;
        }
        

	}
}
