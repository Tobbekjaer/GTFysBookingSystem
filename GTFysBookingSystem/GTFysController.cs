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
        // Initialisering af PatientRepo 
        PatientRepo patientRepo = new PatientRepo();
        // Initialisering af ConsultationRepo
        ConsultationRepo consultationRepo = new ConsultationRepo();
        // Initialisering af PhysioRepo
        PhysioRepo physioRepo = new PhysioRepo();

        // NewPatient metode
        public void NewPatient(Patient patient)
        {
            // Kalder AddPatient metoden i PatientRepo
            patientRepo.AddPatient(patient);

            
            // Send bekræftelses email til patienten

            // Hvis emailen bliver bekræftet bliver patienten tilføjet til repositoriet
            // Det er meningen, at patienten først skal tilføjes

            //// Sætter email properties
            //string fromAddress = "kontakt@gtfys.dk";
            //string toAddress = patient.Email;
            //string subject = "GT Fys bekræftelses email";
            //string body = @$"Bekræft dine login-oplysninger: 
            //{patient.ToString()}";

            //// Sætter SMTP server detaljer
            //string smtpHost = "smtp.office365.com";
            //int smtpPort = 587;
            //string smtpUsername = "your_email@example.com";
            //string smtpPassword = "your_email_password";

            //// Skab en email
            //MailMessage message = new MailMessage(fromAddress, toAddress, subject, body);

            //// Skab en SMTP client
            //SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            //smtpClient.EnableSsl = true;

            //// Send email
            //try {
            //    smtpClient.Send(message);
            //    Console.WriteLine("Email sent successfully.");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine("Failed to send email: " + ex.Message);
            //}

           
        }

        // GetAllPatients() returnerer en ToString() repræsentation af hver patient i patientRepo
        public List<string> GetAllPatients()
        {
            return patientRepo.GetAll();
        }

        // DisplayConsultations metoden tager et patient objekt og returnerer en list over tilknyttede konsultationer
        public List<string> DisplayConsultations(Patient patient) 
        {
            // Kalder ConsultationRepo's GetAll(Patient patient) metode, der tager et patient objekt 
            // og returnerer en string liste over patientens konsultationer
            return consultationRepo.GetAll(patient);
        }

        public string BookConsultation(Patient patient, TreatmentType treatmentType, Physio physio, DateOnly date, TimeOnly time)
        {

            // Konsultations objekt til at holde alle objekter
            Consultation newConsultation = null;

            // Hent det eksiterende patient objekt fra PatientRepo og gemmer det i currentPatient
            Patient currentPatient = patientRepo.GetPatient(patient.Cpr);

            // Gemmer behandlingstypen i et TreatmentType objekt
            TreatmentType type = new TreatmentType();
            type = consultationRepo.GetTreatmentType(treatmentType);

            // Hent det eksiterende physio objekt fra PhysioRepo og gemmer det i currentPhysio
            Physio currentPhysio = physioRepo.GetPhysio(physio.FirstName);


            if (currentPatient != null && currentPhysio != null) {
                newConsultation.Patient = currentPatient;
                newConsultation.TreatmentType = type;
                newConsultation.Physio = currentPhysio;
                newConsultation.Date = date;
                newConsultation.Time = time;
            }

            consultationRepo.AddConsultation(newConsultation);

            return newConsultation.ToString();

        }


    }
}
