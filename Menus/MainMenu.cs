using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Menus;
using CLH_ARTISAN_APP.Repositories;
namespace CLH_ARTISAN_APP.Menus
{
    public class MainMenu
    {
         static StaffMenu staffMenu = new StaffMenu();
         static CustomerMenu customerMenu = new CustomerMenu();
         static ArtisanMenu artisanMenu = new ArtisanMenu();
        StaffRepo staffRepo = new StaffRepo();
        CustomerRepo customerRepo =  new CustomerRepo();

        public static void WelcomePage()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>> WELCOME TO CLH  ARTISAN APP >>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");


            Console.WriteLine("Enter 1 to go to Staff Menu:");
            Console.WriteLine("Enter 2 to go to Customer Menu:");
            Console.WriteLine("Enter 3 to go to Artisan Menu: ");
            int option;
            while(int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            switch (option)
            {
                case 1:
                staffMenu.StaffOptionMenu();
                break;
                case 2:
                customerMenu.CustomerOptionMenu();
                break;
                case 3:
                artisanMenu.ArtisanOptionMenu();
                break;
            }
        }


    
    }
}