using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Models;
using CLH_ARTISAN_APP.Repositories;
namespace CLH_ARTISAN_APP
{
    public class CustomerMenu
    {
        CustomerRepo customerRepo = new CustomerRepo();
        StaffRepo staffRepo = new StaffRepo();
        Customer customer = new Customer();
        


        public void CustomerOptionMenu()
        {
            Console.WriteLine("1. To login");
            Console.WriteLine("2. To Sign up");
            Console.WriteLine("0. To go back to Main Menu");
            int option;
            while (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input, Try again.");
            }
            switch (option)
            {
                case 1:
                    Login();
                    break;
                case 2:
                    Register();
                    break;
                case 0:
                    
                    break;
                    return;
            }
        }


        public void Login()
        {
            Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Password:");
            string password = Console.ReadLine();
            customerRepo.Login(email, password);
        }



        public void Register()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Date of Birth");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Wrong Input. Try again");
            }
            Console.WriteLine("Enter your Gender:");
            Gender gender;
            while (!Gender.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Wrong Input. Try again");
            }
            Console.WriteLine("Enter Your Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your PassWord:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Your Next of kin :");
            string nextOfKin = Console.ReadLine();
            customerRepo.Register(firstName, lastName, email, gender, address, phoneNumber, password, dob, nextOfKin);
            Console.WriteLine("You have successfully registered an account");
            CustomerOptionMenu();
        
        }

        public void FundWallet()
        {
            Console.WriteLine("Enter the amount to add to your wallet");
            decimal amount = decimal.Parse(Console.ReadLine());
            customer.Wallet += amount;
        }


        

    }
}
