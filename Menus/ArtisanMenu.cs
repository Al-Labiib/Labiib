using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Models;
using CLH_ARTISAN_APP.Repositories;
namespace CLH_ARTISAN_APP.Menus
{
    public class ArtisanMenu
    {
        ArtisanRepo artisanRepo = new ArtisanRepo();
        MainMenu mainMenu = new MainMenu();
        int myIndex = 0;

        public void ArtisanOptionMenu()
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
            artisanRepo.Login(email, password);
            var ObjectArtisan = artisanRepo.GetArtisan(email);
            if (ObjectArtisan != null )
             Console.WriteLine("You have successfully login to your account");
            else
            {
                System.Console.WriteLine("Invalid input");
            }
            CheckWalletBalance();
        }

        public void CheckWalletBalance()
        {
            Console.WriteLine("Enter 1 to check your wallet balance");

        }



    }
}
