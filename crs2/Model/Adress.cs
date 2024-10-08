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
    public class Address
    {
        ValueValidator valueValidator = new ValueValidator();
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

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

        public int SetIndex
        {
            get { return _index; }
            set 
            { 
                _index = value;
                valueValidator.MaxOrMinCost(_index, 999999, "PostIndex");
            }
        }
        public string SetCountry
        {
           get { return _country; }
           set 
           {
                _country = value;
                valueValidator.AssertStringOnLenght(_country, 50, "Country");

            }
           
        }

        public string SetCity 
        {
            get { return _city; }
            set 
            {
                _city = value;
                valueValidator.AssertStringOnLenght(_city, 50, "City");
            } 
            
        }

        public string SetStreet
        { 
            get { return _street; }
            set
            {
                _street = value;
                valueValidator.AssertStringOnLenght(_street, 100, "Street");
            }
        }

        public string SetBuilding 
        { 
            get { return _building; }
            set
            {
                _building = value;
                valueValidator.AssertStringOnLenght(_building, 10, "Building");
            }
        }

        public string SetApartament 
        { 
            get { return _apartment; }
            set
            {
                _apartment = value;
                valueValidator.AssertStringOnLenght(_apartment, 10, "Apartament");
            }
        }


    }
}
