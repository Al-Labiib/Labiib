using System;
using CLH_ARTISAN_APP.Enums;


namespace CLH_ARTISAN_APP.Models
{
    public class Customer : Person
    {
        public decimal Wallet { get; set; }
        public string CustomerId { get; set; }
        public Customer(string firstName, string lastName, string email, Gender gender, string address, string phoneNumber, string passWord, DateTime dob, string nextOfKin) : base(firstName, lastName, email, gender, address, phoneNumber, passWord, dob, nextOfKin)
        {
            Wallet = 1000.00m;
            CustomerId = $"ST{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
        }

        public Customer()
        {
            
        }
    }

}



