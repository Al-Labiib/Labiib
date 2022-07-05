using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Models;
using CLH_ARTISAN_APP.Repositories;
namespace CLH_ARTISAN_APP.Menus
{
    public class StaffMenu
    {

        StaffRepo staffRepo = new StaffRepo();
        ArtisanRepo artisanRepo = new ArtisanRepo();
        MainMenu mainMenu = new MainMenu();
        Artisan artisan = new Artisan();
        int myIndex = 0;

        public void Menu()
        {

        }
        public void StaffOptionMenu()
        {
            Console.WriteLine("Enter 1 to login:");
            Console.WriteLine("Enter 0 to go back to Main Menu:");
            int option;
            while (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Wrong Input. Try again");

            }
            switch (option)
            {
                case 1:
                    Login();
                    break;

                case 0:
                    MainMenu.WelcomePage();
                    return;
            }
        }


        public void Login()
        {
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            staffRepo.Login(email, password);
            var ObjectStaff = staffRepo.GetStaff(email);
            if (ObjectStaff != null && ObjectStaff.Role == Role.Manager)
            {
                PrintSubMenu();
            }
            else
            {
                System.Console.WriteLine("Invalid input");
            }
        }

        public void PrintSubMenu()
        {
            Console.WriteLine("Enter 1 to add new staff:");
            Console.WriteLine("Enter 2 to add new Artisans:");
            Console.WriteLine("Enter 0 to go back to main menu:");
            int option;
            while (int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            switch (option)
            {
                case 1:
                    AddNewStaff();
                    break;
                    case 2:
                    AddNewArtisans();
                    break;
                case 0:
                    MainMenu.WelcomePage();
                    break;
            }

        }


        public void AddNewStaff()
        {
            Console.WriteLine("Enter ID");
            int id;
            while (int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input, Try again");
            }
            Console.WriteLine("Enter Staff First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Staff Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Staff Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Staff Date Of Birth :");
            DateTime dob;
            while (DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            Console.WriteLine("Enter Staff Gender:");
            Gender gender;
            while (Gender.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            Console.WriteLine("Enter Staff Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Staff Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter staff  Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter staff Next of Kin");
            string nextOfKin = Console.ReadLine();
            Console.WriteLine("Enter Role");
            int role;
            while (int.TryParse(Console.ReadLine(), out role))
            {
                Console.WriteLine("Invalid input, Try again");
            }
            staffRepo.AddNewStaff(id, fName, lName, email, dob, gender, address, phoneNumber, password, nextOfKin, (Role)role);
        }

          public void AddNewArtisans()
        {
            Console.WriteLine("Enter ID");
            int id;
            while (int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input, Try again");
            }
            Console.WriteLine("Enter Artisan First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Artisan Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Artisan Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Artisan Date Of Birth :");
            DateTime dob;
            while (DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            Console.WriteLine("Enter Artisan Gender:");
            Gender gender;
            while (Gender.TryParse(Console.ReadLine(), out gender))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            Console.WriteLine("Enter Artisan  Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Artisan Phone Number:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Artisan  Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Artisan Next of Kin");
            string nextOfKin = Console.ReadLine();
            Console.WriteLine("Enter Artisan Job");
            int Jobs;
            while (int.TryParse(Console.ReadLine(), out Jobs))
            {
                Console.WriteLine("Invalid input, Try again");
            }
            staffRepo.AddNewArtisan(fName, lName, email, dob, gender, address, phoneNumber, password, nextOfKin, jobs);
        }
        
        public void CreditArtisans()
        {
            Console.WriteLine("Enter the amount you want to credit artisans");
            decimal amount = decimal.Parse(Console.ReadLine());
             artisan.Wallet += amount;
        }
    }
}