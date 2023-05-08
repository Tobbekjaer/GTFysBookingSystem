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

        // ToString metode til at repræsentere et physio-objekt hvis vi fx skal skrive den til en fil
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Phone number: {Phone}, Email: {Email}" +
            $" Username: {Username}, Password: {Password}";
        }
    }
}
