using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Services;
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp1.Model
{
    public class Order
    {
        private readonly int _id;
        Address _address;
        private readonly DateTime _DateOfCreateOrder;
        List<Item> _Items = new List<Item>();
        OnliID _IdGenerator = new OnliID();
        public OrderStatus Status;
        private double _Price;

        public List<Item> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
        public double Amount
        {
            get
            {
                double sum = 0.0;
                if (_Items == null)
                {
                    return sum;
                }
                foreach (Item item in _Items)
                {
                    sum += item.SetCost;
                }
                return sum;
            }
        }
        public Order ()
        {

        }
        public Order(Address address, List<Item> CartItems, double price)
        {
            _id = _IdGenerator.GetNextId();
            _DateOfCreateOrder = DateTime.Now;
            _address = address;
            _Items = CartItems;
            _Price = price;
            Status = OrderStatus.New;
        }
        public DateTime DateOfCreateOrder { get { return _DateOfCreateOrder; } }
        public OrderStatus GetStatus { get { return Status; } set { Status = value; } }
        public double Price { get { return _Price; } set { _Price = Amount; } }
    }

}
