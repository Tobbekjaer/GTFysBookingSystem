using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class Physio : LogIn
    {
        public Physio(string firstName, string lastName, string phone, string email, string username, string password) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }
    }
}
