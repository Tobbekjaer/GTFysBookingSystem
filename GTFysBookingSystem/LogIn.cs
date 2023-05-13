using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    // Login klasse som indeholder alle standard login oplysninger
    // Base class for patient og physio
    public class LogIn
    {
        // Private fields
        private string _firstName;
        private string _lastName;
        private string _phone;
        private string _email;
        private string _username;
        private string _password;


        // Public properties
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                try {
                    // Tjekker at karaktererne i _firstName er bogstaver
                    if (IsStringLetters(value)) {
                        _firstName = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Fornavn kan kun indeholde bogstaver.");
                }

            }
        }
        public string LastName
        {
            get { return _lastName; }
            set {
                try {
                    // Tjekker at karaktererne i _lastName er bogstaver
                    if (IsStringLetters(value)) {
                        _lastName = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Efternavn kan kun indeholde bogstaver.");
                }
               
            }
        }
        public string Phone
        {
            get { return _phone; }
            set {
                try {
                    // Tjekker at alle karakterer i _phone er tal
                    if (IsStringDigits(value)) {
                        _phone = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Telefonnummer skal indeholde bogstaver og tal.");
                }

            }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; } // Bør tjekke om emailen existerer...
        }
        public string Username
        {
            get { return _username; }
            set {
                try {
                    // Tjekker at karaktererne i Username er bogstaver og tal
                    if (ContainsLettersAndDigits(value)) {
                        _username = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Brugernavn skal indeholde bogstaver og tal.");
                }           
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                try {
                    // Tjekker at karaktererne i Password er bogstaver og tal
                    if (ContainsLettersAndDigits(value)) {
                        _password = value;
                    }
                }
                catch (Exception ex) {
                    throw new ArgumentException("Adgangskode skal indeholde bogstaver og tal.");
                }
            }
        }

        private bool IsStringDigits(string input)
        {
            foreach (char c in input) {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private bool IsStringLetters(string input)
        {
            foreach (char c in input) {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private bool ContainsLettersAndDigits(string input)
        {
            bool containsLetters = false;
            bool containsDigits = false;

            foreach (char c in input) {
                if (char.IsLetter(c))
                    containsLetters = true;
                else if (char.IsDigit(c))
                    containsDigits = true;
            }

            return containsLetters && containsDigits;
        }

    }
}
