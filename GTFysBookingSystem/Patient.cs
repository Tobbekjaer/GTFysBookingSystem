using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    // Nedarver fra login klassen
    // Patient er derived class til login
    public class Patient : LogIn
    {
        // Private fields
        private string _cpr;
        private bool _insurance;
        private string _address;
        private string _city;
        private int _zipCode;

        // Public properties
        public string Cpr
        {
            get { return _cpr; }
            set {
                _cpr = value;
                // Tjekker at alle karakterer i _cpr er tal
                try {
                    if (_cpr.All(char.IsDigit)) {
                        _cpr = value;
                    }
                }
                // Kaster en exeption, hvis input ikke er indtastet korrekt
                catch (Exception ex) {
                    throw new ArgumentException("Cpr-nummer kan kun indeholde tal.");
                }
               
            }
        }
        public bool Insurance
        {
            get { return _insurance; }
            set { _insurance = value; }
        }
        public string Address
        {
            get { return _address; }
            set {
                _address = value;
                try {
                    // Tjekker at karaktererne i _address er enten bogstaver eller tal
                    if (_address.All(char.IsLetterOrDigit)) {
                        _address = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Adresse skal indeholde bogstaver og tal.");
                }
            }
        }
        public string City
        {
            get { return _city; }
            set {

                _city = value;
                // Tjekker at alle karakterer i _city er bogstaver
                try {
                    if (_city.All(char.IsLetter)) {
                        _city = value;
                    }
                }
                // Kaster en exeption, hvis input ikke er indtastet korrekt
                catch (Exception ex) {
                    throw new ArgumentException("By kan kun indeholde bogstaver.");
                }
                
            }
        }
        public int ZipCode
        {
            get { return _zipCode; }
            set {
                // Tjekker at alle karakterer i _phone er tal
                try {
                        _zipCode = value;
                }
                // Kaster en exeption, hvis input ikke er indtastet korrekt
                catch (Exception ex) {
                    throw new ArgumentException("Postnummer kan kun indeholde tal.");
                }
                
            }
        }


        // Constructor til at oprette en patient
        // Tager alle login informationer plus resten af parametrene
        public Patient(string firstName, string lastName, string phone, string email, string username, string password, string cpr, bool insurance, string address, string city, int zipCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Cpr = cpr;
            this.Insurance = insurance;
            this.Address = address;
            this.City = city;
            this.ZipCode = zipCode;
        }
        public Patient(LogIn login, string cpr, bool insurance, string address, string city, int zipCode) 
        {
            this.FirstName = login.FirstName;
            this.LastName = login.LastName;
            this.Phone = login.Phone;
            this.Email = login.Email;
            this.Username = login.Username;
            this.Password = login.Password;
            this.Cpr = cpr;
            this.Insurance = insurance;
            this.Address = address;
            this.City = city;
            this.ZipCode = zipCode;
        }
        


        // ToString metode til at repræsentere et patient-objekt hvis vi fx skal skrive den til en fil
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Phone number: {Phone}, Email: {Email}" +
                $" Username: {Username}, Password: {Password}, CPR: {Cpr}, Insurance: {Insurance}, Address: {Address}," +
                $" City: {City}, Zip Code: {ZipCode}";
        }





    }
}
