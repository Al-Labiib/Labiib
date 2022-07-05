using System;
using CLH_ARTISAN_APP.Models;
using System.Text;

namespace CLH_ARTISAN_APP.Repositories
{
    public class ServiceRepo
    {
        private static int count = 1;
        private static int myIndex = 0;
        public static Service[] services = new Service[100];
        StaffRepo staffRepo = new StaffRepo();
        ArtisanRepo artisanRepo = new ArtisanRepo();


        public ServiceRepo(ArtisanRepo artisanRepo)
        {
           artisanRepo = artisanRepo;
        }

        public void ReqestForService(Customer customer, string jobName, DateTime date)
        {
            var allAvailable = GetArtisan(jobName, date, duration);
            Console.WriteLine("Please choose an Artisan from the  available artisans listed above");
            do
            {
                choosedArtisan = Console.ReadLine();
            } while (!IsAvailable(allAvailable, choosedArtisan));
            var artisan = artisanRepo.GetArtisan(choosedArtisan);
            var serviceName = StaffRepo.AddService(choosedArtisan);

            Console.WriteLine($"You are about to book a {services}");
            Console.WriteLine("Press 1 to continue or 0 to cancel");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Request(serviceName, date);
                var service = new ServiceRepo(count, customer.FullName(), customer.Id, date, serviceName);
                services[myIndex] = service;
                count++;
                myIndex++;
            }
            
        }

    }
}