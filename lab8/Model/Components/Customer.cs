using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Customer
    {
        private List<Order> _orders = new List<Order>();
        private bool _isPriority = false;
        ValueValidator valueValidator = new ValueValidator();
        OnlyID idGenerator = new OnlyID();
        Address Address;
        Cart Cart;
        List<IDiscount> skidos = new List<IDiscount>();
        private string _time;
        List<Order> orders = new List<Order>();
        private readonly int _id;
        private string _fullname;

        public Customer(string fullName, int index, string country, string city, string street, string building, string apartment)
        {
            _id = idGenerator.GetNextId();
            SetFullName = fullName;
            Address = new Address(index, country, city, street, building, apartment);
            Cart = new Cart();
            PointsDiscount pointsDiscount = new PointsDiscount();
            skidos.Add(pointsDiscount);

        }
        public List<IDiscount> Discounts
        {
            get
            {
                return skidos;
            }
            set
            {
                skidos = value;
            }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public bool IsPriority
        {
            get { return _isPriority; }
            set { _isPriority = value; }
        }
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }
        public Cart cart
        {
            get
            {
                return Cart;
            }
            set
            {
                Cart = value;
            }
        }
        public string SetFullName
        {
            get { return _fullname; }
            
            set 
            {
                _fullname = value;
                valueValidator.AssertStringOnLenght(_fullname, 200, "FullName");
            }
            
            
        }
        public Address SetAddress
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }

        public int GetId() { return _id; }
        public override string ToString()
        {
            return $"ID: {GetId()}, Name: {SetFullName}";
        }

    }
}
