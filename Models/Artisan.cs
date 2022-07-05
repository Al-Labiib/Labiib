using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Repositories;

namespace CLH_ARTISAN_APP.Models
{
    public class Artisan:Person
    {
        public string ArtisanNumber { get; set; }
        public string Role { get; set; }
        public decimal Wallet { get; set; }
        public int Rating { get; set; }
        public string jobs {get; set;}
        public Artisan(string firstName, string lastName, string email, DateTime dob, Gender gender, string address, string phoneNumber, string password, string nextOfKin, int jobs) : base (firstName, lastName, email, gender,address, phoneNumber, password, dob, nextOfKin)
        {
            ArtisanNumber = $"CU{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
            Rating = 0;    
        }
        public Artisan()
        {

        }
        
    }
}