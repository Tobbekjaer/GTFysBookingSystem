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
            Patient tobias = new Patient("Tobias", "Kjær", "20376707", "tobias.hougs.kjaer@gmail.com", "Tobbekjaer",
                "gettingUnreal", "12042310949", false, "Dyssegårdsvej 119", "Dyssegård", 2870);
            Patient sebastian = new Patient("Seb", "Riis", "20395098", "seb.riis@gmail.com", "Sebriis",
                "gettingUnreal", "1305425109549", true, "Kløvermarken 3", "Frederiksberg", 2040);
            Patient magnus = new Patient("Magnus", "Maltha", "946920039", "magnus.maltha@gmail.com", "MagnusMaltha",
                "gettingUnreal", "9456902209", true, "Ny Kongevej 2", "Odense", 4050);

            // Kalder NewPatient() metoden med patienten
            controller.NewPatient(tobias);
            controller.NewPatient(sebastian);
            controller.NewPatient(magnus);


            //--- TEST AF GET ALL PATIENTS ---\\
            List<string> patients = controller.GetAllPatients();
            foreach (string patient in patients) {
                Console.WriteLine(patient);
            }

            //--- TEST AF DISPLAY CONSULTATIONS ---\\
            // controller.DisplayConsultations(tobias);


        }
    }
}