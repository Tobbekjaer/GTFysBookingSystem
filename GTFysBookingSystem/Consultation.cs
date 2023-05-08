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


        public Consultation(Patient patient, Physio physio, TreatmentType treatmentType, DateOnly date, TimeOnly time) 
        { 
            this.Patient = patient;
            this.Physio = physio;
            this.TreatmentType = treatmentType;
            this.Date = date;
            this.Time = time;
        }


    }
}
