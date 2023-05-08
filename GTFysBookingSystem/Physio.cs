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
        public Physio(LogIn login) 
        {
            this.FirstName = login.FirstName;
            this.LastName = login.LastName;
            this.Phone = login.Phone;
            this.Email = login.Email;
            this.Username = login.Username;
            this.Password = login.Password;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Phone number: {Phone}, Email: {Email}" +
            $" Username: {Username}, Password: {Password}";
        }
    }
}
