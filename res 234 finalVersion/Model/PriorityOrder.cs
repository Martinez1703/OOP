using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class PriorityOrder : Order
    {
        private DateTime DeliveryDay;
        private string Time;
        public List<string> DeliveryTime = new List<string>() 
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };
        public DateTime Day 
        {  
            get { return DeliveryDay; }
                
            set { DeliveryDay = value; }
        }
        public string time
        {
            get { return Time; }
            set { Time = value; }
        }
        public PriorityOrder ()
        {

        }
        public PriorityOrder(Address address, List<Item> CartItems, double price) : base(address, CartItems, price)
        {
            Day = DateTime.Today;
        }
    }
}
