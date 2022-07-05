using System;
namespace CLH_ARTISAN_APP.Models
{
    public class Service
    {
        public int Id {get; set;}
        public string ServiceReference {get; set;}
         public string CustomerName { get; set;}
        public string CustomerId {get; set;}
        public DateTime ServiceDate {get; set;}
        public string RoomNo { get; set;}
        public int RoomId {get; set;}
        public DateTime ServiceDay { get; set;}
       
        public Service (int id, string customerName, int customerId, DateTime serviceDate)
        {
            Id = id;
            ServiceReference = $"{Guid.NewGuid().ToString().Replace("-","").Substring(0,6).ToUpper()}";
            CustomerName = customerName;
            CustomerId = CustomerId;
            ServiceDate = serviceDate;
        }


    }
}