namespace GTFysBookingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiérer controller klassen
            GTFysController controller = new GTFysController();

            //--- TEST AF NEW PATIENT ---\\
            // Danner et nyt patient objekt
            Patient tobias = new Patient("Tobias", "Kjær", "20376707", "tobias.kjaer@gmail.com", "Tobbekjaer",
                "gettingUnreal", "12042310949", false, "Dyssegårdsvej 119", "Dyssegård", 2870);
            Patient sebastian = new Patient("Seb", "Riis", "20395098", "seb.riis@gmail.com", "Sebriis",
                "gettingUnreal", "1305425109549", true, "Kløvermarken 3", "Frederiksberg", 2040);
            Patient magnus = new Patient("Magnus", "Maltha", "94920039", "magnus.maltha@gmail.com", "MagnusMaltha",
                "gettingUnreal", "9456902209", true, "Ny Kongevej 2", "Odense", 4050);
            Patient sarah = new Patient("Sarah", "Beckwith", "25935678", "sarah.beckwith@gmail.com", "SarahBeckwith",
               "gettingUnreal", "2301096509", false, "Vigerslev Alle 154", "Valby", 1035);

            // Kalder NewPatient() metoden med patienten
            controller.NewPatient(tobias);
            controller.NewPatient(sebastian);
            controller.NewPatient(magnus);
            controller.NewPatient(sarah);

            //--- TEST AF GET ALL PATIENTS ---\\
            //List<string> patients = controller.GetAllPatients();
            //foreach (string patient in patients) {
            //    Console.WriteLine(patient);
            //}

            //--- TEST AF BOOK CONSULTATIONS ---\\

            // Opretter to fysioterapuet objekter

            Physio henrik = new Physio("Henrik", "Kjær", "59382059", "henrik@gtfys.dk", "henrikGTFys", "gettingUnreal");
            Physio thomas = new Physio("Thomas", "Larsen", "59382059", "thomas@gtfys.dk", "thomasGTFys", "gettingUnreal");

            // Tilføjer henrik og thomas til listen over fysioteraputer
            controller.AddPhysio(henrik);
            controller.AddPhysio(thomas);

            controller.BookConsultation(sarah,TreatmentType.FirstConsultation, henrik, DateOnly.Parse("12-05-2023"), TimeOnly.Parse("9:00"));

            //--- TEST AF DISPLAY CONSULTATIONS ---\\
            // controller.DisplayConsultations(tobias);


        }
    }
}