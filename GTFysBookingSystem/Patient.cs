using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFysBookingSystem
{
    public class Patient : LogIn
    {
        // Public properties
        public string Cpr { get; set; }
        public bool Insurance { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        
        // Constructor til at oprette en patient
        // Tager alle login informationer plus resten af parametrene
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
                $" Username: {Username}, Password: {Password}, CPR: {Cpr}, Insurance: {Insurance}, Address: {Address}" +
                $" City: {City}, Zip Code: {ZipCode}";
        }



    }
}
