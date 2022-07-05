using System;
using  CLH_ARTISAN_APP.Enums;
using  CLH_ARTISAN_APP.Models;
using CLH_ARTISAN_APP.Repositories;

namespace CLH_ARTISAN_APP.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string NextOfKin { get; set; }

        protected Person(string firstName, string lastName, string email, Gender gender, string address, string phoneNumber, string password, DateTime dob, string nextOfKin)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Dob = dob;
            Gender = gender;
            Address = address;
            PhoneNumber = phoneNumber;
            Password = password;
            NextOfKin = nextOfKin;

        }
        public string FullName()
        {
            return $"{FirstName}{LastName}";
        }
        public Person()
        {
            
        }

    }
}