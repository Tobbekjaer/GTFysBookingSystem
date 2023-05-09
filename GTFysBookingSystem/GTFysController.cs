using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class GTFysController
    {
        // Initialisering af PatientRepo 
        PatientRepo patientRepo = new PatientRepo();

        // NewPatient metode
        public void NewPatient(Patient patient)
        {
            // Kalder AddPatient metoden i PatientRepo
            
            patientRepo.AddPatient(patient);


           
        }

    }
}
