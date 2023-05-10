using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    // Nedarver fra login klassen
    // Physio er derived class til login
    public class Physio : LogIn
    {
        // Constructor til at oprette en physio
        // Tager alle login informationer 
        public Physio(LogIn login) 
        {
            this.FirstName = login.FirstName;
            this.LastName = login.LastName;
            this.Phone = login.Phone;
            this.Email = login.Email;
            this.Username = login.Username;
            this.Password = login.Password;
        }
        // Constructor overloading
        public Physio(string firstName, string lastName, string phone, string email, string username, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }

        // ToString metode til at repræsentere et physio-objekt hvis vi fx skal skrive den til en fil
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Phone number: {Phone}, Email: {Email}" +
            $" Username: {Username}, Password: {Password}";
        }
    }
}
