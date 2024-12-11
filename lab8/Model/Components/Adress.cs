using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Address : ICloneable, IEquatable<Address>
    {
        ValueValidator valueValidator = new ValueValidator();
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;
       
        //событие на изменение объекта
        public event EventHandler<EventArgs> AddressChanged;
        public Address()
        {

        }
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            SetIndex = index;
            SetCountry = country;
            SetCity = city;
            SetStreet = street;
            SetBuilding = building;
            SetApartament = apartment;
        }
        public object Clone()
        {
            return new Address(this.SetIndex, this.SetCountry, this.SetCity, this.SetStreet,this.SetBuilding ,this.SetApartament);
        }
        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            var address2 = (Address)other;

            return (this.SetIndex == address2.SetIndex);
        }
        public bool Equals(Address other)
        {
            throw new NotImplementedException();
        }

        public int SetIndex
        {
            get { return _index; }
            set 
            {
                valueValidator.MaxOrMinCost(SetIndex, 999999, "PostIndex");
                if (_index != value)
                {
                    var args = new EventArgs();
                    _index = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }
        public string SetCountry
        {
           get { return _country; }
           set 
           {
               
                valueValidator.AssertStringOnLenght(SetCountry, 50, "Country");
                if (_country != value)
                {
                    var args = new EventArgs();
                    _country = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
           
        }

        public string SetCity 
        {
            get { return _city; }
            set 
            {
                valueValidator.AssertStringOnLenght(SetCity, 50, "City");
                if (_city != value)
                {
                    var args = new EventArgs();
                    _city = value;
                    AddressChanged?.Invoke(this, args);
                }
            } 
            
        }

        public string SetStreet
        { 
            get { return _street; }
            set
            {
                valueValidator.AssertStringOnLenght(SetStreet, 100, "Street");
                if (_street != value)
                {
                    var args = new EventArgs();
                    _street = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        public string SetBuilding 
        { 
            get { return _building; }
            set
            {
                valueValidator.AssertStringOnLenght(SetBuilding, 10, "Building");
                if (_building != value)
                {
                    var args = new EventArgs();
                    _building = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        public string SetApartament 
        { 
            get { return _apartment; }
            set
            {
                valueValidator.AssertStringOnLenght(SetApartament, 10, "Apartament");
                if (_apartment != value)
                {
                    var args = new EventArgs();
                    _apartment = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }


    }
}
