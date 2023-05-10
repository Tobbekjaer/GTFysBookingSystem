using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class PatientRepo
    {
		// Privat liste over patienter
		private List<Patient> _patients = new List<Patient>();

		// Public liste, der bruges til at tilføje eller hente patienter fra den private liste
		public List<Patient> Patients
		{
			get { return _patients; }
			set { _patients = value; }
		}

		// AddPatient() metoden tilføjer en ny patient til listen 
		public void AddPatient(Patient patient)
		{
			if (patient != null) {
				_patients.Add(patient);

                // Gem den nye patient i en tekstfil
                using (StreamWriter writer = new StreamWriter("PatientRepository.txt", append:true)) {
                    writer.WriteLine(patient.ToString());
                }
            }
			
		}

        // DeletePatient() metoden sletter en patient fra listen, hvis listen indeholder en person med et matchende cpr
        public void DeletePatient(string cpr)
		{
			foreach (Patient patient in _patients) {
				if(patient.Cpr.Equals(cpr)) {
                    _patients.Remove(patient);
                }
			}
		}

		// GetPatient() kigger listen igennem efter en patient med matchende cpr og returnerer patienten
		public Patient GetPatient(string cpr)
		{
			Patient returnPatient = null;
			foreach (Patient patient in _patients) {
				if (patient.Cpr.Equals(cpr)) {
					returnPatient = patient;
					}
				}
			return returnPatient; 
		}


		// GetAll() opretter en ny liste og kalder hvert patient-objekts ToString()-metode,
		// tilføjer det til listen og returnerer listen over alle patienter
		public List<string> GetAll()
		{
            List <string> patients = new List <string>();

			using (StreamReader reader = new StreamReader("PatientRepository.txt")) {

				string ln;

				while((ln = reader.ReadLine()) != null) {

                    patients.Add(ln);
					
                }	
			}
			return patients;
		}


	}
}
