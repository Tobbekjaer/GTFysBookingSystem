using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class ConsultationRepo
    {
        // Initialisering af PatientRepo 
        private PatientRepo patientRepo;

        // Initialisering af PhysioRepo
        private PhysioRepo physioRepo;

        // Privat liste over konsultationer
        private List<Consultation> _consultations = new List<Consultation>();

        // Public liste, der bruges til at tilføje eller hente konsultationer fra den private liste
        public List<Consultation> Consultations
		{
			get { return _consultations; }
			set { _consultations = value; }
		}

        public ConsultationRepo(PatientRepo patientRepo, PhysioRepo physioRepo)
        {
            this.patientRepo = patientRepo;
            this.physioRepo = physioRepo;
        }

        // AddConsultation() metoden tilføjer en ny konsultation til listen 
        public void AddConsultation(Patient patient, TreatmentType treatmentType, Physio physio, DateOnly date, TimeOnly time)
        {
            // Konsultations objekt til at holde alle objekter
            Consultation newConsultation = null;

            // Hent det eksiterende patient objekt fra PatientRepo og gemmer det i currentPatient
            Patient currentPatient = patientRepo.GetPatient(patient.Cpr);
            
            // Gemmer behandlingstypen i et TreatmentType objekt
            TreatmentType type = GetTreatmentType(treatmentType);

            // Hent det eksiterende physio objekt fra PhysioRepo og gemmer det i currentPhysio
            Physio currentPhysio = physioRepo.GetPhysio(physio.FirstName);

            if (currentPatient != null && currentPhysio != null) {
                newConsultation = new Consultation(currentPatient, type, currentPhysio, date, time);
            }

            if (newConsultation != null) {
                _consultations.Add(newConsultation);

                // Gem den nye patient i en tekstfil
                using (StreamWriter writer = new StreamWriter("ConsultationRepository.txt", append: true)) {
                    writer.WriteLine(newConsultation.ToString());
                }
            }

        }

        // GetAllConsultations() opretter en ny liste og kalder hvert konsultations-objekts ToString()-metode og
        // tilføjer det til listen og returnerer listen over alle konsultationer
        public List<string> GetAll()
        {
            List<string> returnConsultations = new List<string>();

            using (StreamReader reader = new StreamReader("ConsultationRepository.txt")) {

                string ln;

                while ((ln = reader.ReadLine()) != null) {

                    returnConsultations.Add(ln);

                }
            }

            return returnConsultations;
        }

        // Method overload til at en enkelt patients konsultationer
        public List<string> GetAll(Patient patient)
        {
            List<string> patientConsultations = new List<string>();

            foreach (Consultation consultation in _consultations) {
                if (patient.Cpr == consultation.Patient.Cpr) {
                    patientConsultations.Add(consultation.ToString());
                }
            }

            return patientConsultations;
        }

        public TreatmentType GetTreatmentType(TreatmentType treatmentType)
        {
            // Instantier et TreatmentType objekt
            TreatmentType type = new TreatmentType();

            // Hvis treatmentType parameter er førstegangs konsultation, returnér førstegangs konsultation
            if (treatmentType is TreatmentType.FirstConsultation) {
                type = treatmentType;
            }
            // Hvis treatmentType parameter er trænings instruktion konsultation, returnér trænings instruktion konsultation
            if (treatmentType is TreatmentType.TrainingInstruction) {
                type = treatmentType;
            }
            return type;
        }





    }
}
