using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class Patient : LogIn
    {
       
        public string Cpr { get; set; }
        public bool Insurance { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        
        public Patient(string firstName, string lastName, string phone, string email, string username, string password,
            string cpr, bool insurance, string address, string city, int zipCode) 
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



    }
}
