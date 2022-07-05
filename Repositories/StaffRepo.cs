using System;
using CLH_ARTISAN_APP.Models;
using CLH_ARTISAN_APP.Enums;
namespace CLH_ARTISAN_APP.Repositories
{

    public class StaffRepo
    {

        // public Service[] services = new Service[500];
        private static int count = 0;
        public static Staff[] staffs = new Staff[50];
         private static Artisan[] artisans = new Artisan[500];
        private static int myIndex = 1;
        private static decimal wallet;
        public StaffRepo()
        {
            var staff = new Staff(1, "Boss", "Oga", "boss@gmail.com", DateTime.Parse("1960-07-20"), Gender.Rather_Not_Say, "Abeokuta", "08033660368", "Password", "Bosswife", Role.Manager);
        }
        public void AddNewStaff(int id, string fName, string lName, string email, DateTime dateOfBirth, Gender gender, string address, string phoneNumber, string password, string nextOfKin, Role role)
        {
            var staff = new Staff(count, fName, lName, email, dateOfBirth, gender, address, phoneNumber, password, nextOfKin, role);

            staffs[myIndex] = staff;
            myIndex++;
            count++;

        }
        public void AddNewArtisan(string fName, string lName, string email, DateTime dob, Gender gender, string address, string phoneNumber, string password, string nextOfKin, string jobs)
        {
            var artisan = new Artisan (fName, lName, email, dob, gender, address, phoneNumber, password, nextOfKin, jobs);
            artisans [myIndex] = artisan;
            myIndex++;
        }
        public Staff Login(string email, string password)
        {
            var staff = GetStaff(email);
            if (staff != null && staff.Password == password)
            {
                return staff;
            }
            return null;

        }

        public Staff GetStaff(string email)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if (staffs[i] != null && staffs[i].Email == email)
                {
                    return staffs[i];
                }
            }
            return null;
        }


        public void CreditArtisans(Artisan artisan)
        {
            Console.WriteLine("Enter amount to send to artisan's wallet : ");
            decimal amount = decimal.Parse(Console.ReadLine());
            artisan.Wallet -= amount;
            amount += artisan.Wallet;
        }


    }
}