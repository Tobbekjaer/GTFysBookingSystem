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

        // Initialisering af PhysioRepo
        PhysioRepo physioRepo = new PhysioRepo();

        // Initialisering af ConsultationRepo
        ConsultationRepo consultationRepo = new ConsultationRepo();

        // NewPatient metode
        public void NewPatient(Patient patient)
        {
            // Initialisering af PatientRepo 
            PatientRepo patientRepo = new PatientRepo();

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

        public void AddPhysio(Physio physio)
        {
            physioRepo.AddPhysio(physio);
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

        public void BookConsultation(Patient patient, TreatmentType treatmentType, Physio physio, DateOnly date, TimeOnly time)
        {
         
            consultationRepo.AddConsultation(patient, treatmentType, physio, date, time);

        }


    }
}
