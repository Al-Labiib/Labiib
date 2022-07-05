using System;
using CLH_ARTISAN_APP.Enums;
using CLH_ARTISAN_APP.Models;
namespace CLH_ARTISAN_APP.Repositories
{
    public class ArtisanRepo
    {
        public static int count = 1;
        private static Artisan[] artisan = new Artisan[500];
        private static int myIndex = 0;
        Service service = new Service[500];
       

        public void Register(string firstName, string lastName, string email, Gender gender, string address, string password, DateTime dob, string nextOfKin, string service)
        {
            int id = count;
            var artisan = new Artisan(id, firstName, lastName, email, gender, address, password, dob, nextOfKin, service);
            artisan[myIndex] = artisan;
            myIndex++;
            count++;
        }
        public ArtisanRepo  Login (string email, string password)
        {
            var artisan = GetArtisan(email);
            if (artisan != null && artisan.password == password)
            {
                return artisan;
            }
            return null;

        }

        private Artisan GetArtisan(string email)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if ((artisans[i] != null) && (artisans[i].email == email))
                {
                    return artisans[i];
                }
            }
            return null;
        }

         public void CashoutFromWallet(Artisan artisan)
        {
            Console.WriteLine("Enter amount to remove from your wallet your wallet : ");
            decimal amount = decimal.Parse(Console.ReadLine());
            artisan.Wallet -= amount;
        }
        



    }
}