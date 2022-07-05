using System;
using CLH_ARTISAN_APP.Enums;

namespace CLH_ARTISAN_APP.Models
{
    public class Staff:Person
    {
        public string StaffNo { get; set; }
        public Role Role { get; set; }
        public decimal Wallet { get; set; }
        public Staff(int id, string firstName, string lastName, string email, DateTime dob, Gender gender, string address, string phoneNumber, string password, string nextOfKin, Role role) : base (firstName, lastName, email, gender, address, phoneNumber, password, dob, nextOfKin)
        {
            Wallet = 100000.00m;
            StaffNo = $"ST{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
            Role = Role;
        }
    }

}