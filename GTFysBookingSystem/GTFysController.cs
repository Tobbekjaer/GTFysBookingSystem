using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class GTFysController
    {

        //// Initialisering af PatientRepo 
        //PatientRepo patientRepo = new PatientRepo();

        //// Initialisering af PhysioRepo
        //PhysioRepo physioRepo = new PhysioRepo();

        //// Initialisering af ConsultationRepo
        //ConsultationRepo consultationRepo = new ConsultationRepo(patientRepo, physioRepo);

        // Erklærer vores repositories som felter 
        private PatientRepo patientRepo;
        private PhysioRepo physioRepo;
        private ConsultationRepo consultationRepo;

        public GTFysController()
        {
            // Initialiserer vores repositories i vores constructor
            patientRepo = new PatientRepo();
            physioRepo = new PhysioRepo();
            consultationRepo = new ConsultationRepo(patientRepo, physioRepo);
        }

        // NewPatient metode
        public void NewPatient(Patient patient)
        {
            // Kalder AddPatient metoden i PatientRepo
            patientRepo.AddPatient(patient);

            
            // Send bekræftelses email til patienten

            // Hvis emailen bliver bekræftet bliver patienten tilføjet til repositoriet
           

        }

        public void AddPhysio(Physio physio)
        {
            physioRepo.AddPhysio(physio);
        }

        // GetAllPatients() returnerer en ToString() repræsentation af hver patient i patientRepo
        public List<string> GetAllPatients()
        {
            return patientRepo.GetAll();
        }

        public List<string> DisplayConsultations()
        {
            // Kalder ConsultationRepo's GetAll(Patient patient) metode, der tager et patient objekt 
            // og returnerer en string liste over patientens konsultationer
            return consultationRepo.GetAll();
        }
        // DisplayConsultations metoden tager et patient objekt og returnerer en list over tilknyttede konsultationer
        public List<string> DisplayConsultations(Patient patient) 
        {          
            // Kalder ConsultationRepo's GetAll(Patient patient) metode, der tager et patient objekt 
            // og returnerer en string liste over patientens konsultationer
            return consultationRepo.GetAll(patient);
        }

        public void BookConsultation(Patient patient, TreatmentType treatmentType, Physio physio, DateOnly date, TimeOnly time)
        {
        
            consultationRepo.AddConsultation(patient, treatmentType, physio, date, time);

        }


    }
}
