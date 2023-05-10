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
                _firstName = value;
                // Tjekker at alle karakterer i _firstName er bogstaver
                try {
                    if (_firstName.All(char.IsLetter)) {
                        _firstName = value;
                    }
                    // Kaster en exeption, hvis input ikke er indtastet korrekt
                }
                catch (Exception ex) {
                    throw new ArgumentException("Fornavnet kan kun indeholde bogstaver.");
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set {
                _lastName = value;
                // Tjekker at alle karakterer i _lastName er bogstaver
                try {
                    if (_lastName.All(char.IsLetter)) {
                        _lastName = value;
                    }
                }
                // Kaster en exeption, hvis input ikke er indtastet korrekt
                catch (Exception ex) {
                    throw new ArgumentException("Efternavnet kan kun indeholde bogstaver.");
                }
            }
        }
        public string Phone
        {
            get { return _phone; }
            set {
                _phone = value;
                // Tjekker at alle karakterer i _phone er tal
                try {
                    if (_phone.All(char.IsDigit)) {
                        _phone = value;
                    }
                }
                // Kaster en exeption, hvis input ikke er indtastet korrekt
                catch (Exception ex) {
                    throw new ArgumentException("Telefonnummer kan kun indeholde tal.");
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
                _username = value;
                //try {
                //    // Tjekker at karaktererne i _username er enten bogstaver eller tal
                //    if (_username.All(char.IsLetterOrDigit)) {
                //        _username = value;
                //    }
                //}
                //catch (Exception ex) {
                //    throw new ArgumentException("Brugernavn skal indeholde bogstaver og tal.");
                //}

            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                //try {
                //    // Tjekker om _password ikke kun er bogstaver eller tal, at input enten er bogstaver eller tal
                //    // og at længden på _password er minimum 8 karakterer
                //    if (!_password.All(char.IsLetter) && !_password.All(char.IsDigit) && _password.All(char.IsLetterOrDigit)
                //        && _password.Length >= 8) {
                //        _username = value;
                //    }
                //}
                //catch (Exception ex) {
                //    throw new ArgumentException("Adgangskoden skal indeholde bogstaver, tal og bestå af minimum 8 karakterer.");
                //}

            }
        }

        
    }
}
