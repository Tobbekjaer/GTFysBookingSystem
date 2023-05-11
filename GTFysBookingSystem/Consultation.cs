using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class Consultation
    {
        public Patient Patient { get; set; }
        public Physio Physio { get; set; }
        public TreatmentType TreatmentType { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }

        public static int FirstConsultationLength = 60;
        public static int TrainingInstructionLength = 45;

        // Constructor til at oprette en konsultation
        // Tager alle et patient-objekt, physio-objekt, behandlingstype, dato og tid
        public Consultation(Patient patient, TreatmentType treatmentType, Physio physio, DateOnly date, TimeOnly time) 
        { 
            this.Patient = patient;
            this.TreatmentType = treatmentType;
            this.Physio = physio;
            this.Date = date;
            this.Time = time;
        }

        // ToString metode til at repræsentere en konsultation hvis vi fx skal skrive den til en fil
        public override string ToString()
        {
            return $"Patient: {Patient.FirstName} {Patient.LastName}, Physio: {Physio.FirstName} {Physio.LastName}" +
                $" Treatment Type: {TreatmentType}, Date: {Date}, Time: {Time}";
        }

        



    }
}
