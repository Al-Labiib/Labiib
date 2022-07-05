using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Models;
namespace CLH_ARTISAN_APP.Repositories

{
    public class CustomerRepo
    {
        StaffRepo staffRepo = new StaffRepo();
        ArtisanRepo artisanRepo = new ArtisanRepo();
        Artisan artisan = new Artisan();
        private static int count = 1;
        private static Customer[] customers = new Customer[500];

        private static int myIndex = 0;

        public void Register(string firstName, string lastName, string email, Gender gender, string address, string phoneNumber, string password, DateTime dob, string nextOfKin)
        {
            int id = count;
            var customer = new Customer(firstName, lastName, email, gender, address, phoneNumber, password, dob, nextOfKin);
            customers[myIndex] = customer;
            myIndex++;
            count++;
        }
        public Customer Login(string email, string password)
        {
            var customer = GetCustomer(email);
            if (customer != null && customer.Password == password)
            {
                return customer;
            }
            return null;

        }
        private Customer GetCustomer(string email)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if ((customers[i] != null) && (customers[i].Email == email))
                {
                    return customers[i];
                }
            }
            return null;
        }
        public void FundWallet(Customer customer)
        {
            Console.WriteLine("Enter amount to fund your wallet : ");
            decimal amount = decimal.Parse(Console.ReadLine());
            customer.Wallet += amount;
        }

        public void ReqestForService(string serviceName)
        {
            Console.WriteLine("Enter the name of the service you need");
            string nameOfService = Console.ReadLine();
            for (int i = 0; i < myIndex; i++)
            {
                if (nameOfService == ArtisanRepo.Jobs)
                {
                    Console.WriteLine(ArtisanRepo.Jobs);
                }
            }
        }
    }
}