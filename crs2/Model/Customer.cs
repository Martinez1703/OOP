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
       
        ValueValidator valueValidator = new ValueValidator();
        GenericOnlyId idGenerator = new GenericOnlyId();
        Address Address;
       
        private readonly int _id;
        private string _fullname;
        public Customer(string fullName, int index, string country, string city, string street, string building, string apartment)
        {
            _id = idGenerator.GetNextId();
            SetFullName = fullName;
            Address = new Address(index, country, city, street, building, apartment);
        

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
