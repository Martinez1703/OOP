using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View.Tabs;

namespace WindowsFormsApp1.View.Control
{
    [Serializable]
    public partial class AdressControl : UserControl
    {
       
        Errors toolTipExeptions = new Errors();
        Address _address = new Address();
        public Address address 
        { 
            get 
            { 
                return _address; 
            }
            set 
            {
                _address = address;
            }
        }
        public AdressControl()
        {
            InitializeComponent();
        }
        public void TextBoxColoring(bool color)
        {
            if (color)
            {
                PostIndexBox.BackColor = Color.White;
                CountryBox.BackColor = Color.White;
                CityBox.BackColor = Color.White;
                StreetBox.BackColor = Color.White;
                BuildingBox.BackColor = Color.White;
                ApartamentBox.BackColor = Color.White;
            }
            else
            {
                PostIndexBox.BackColor = Color.Red;
                CountryBox.BackColor = Color.Red;
                CityBox.BackColor = Color.Red;
                StreetBox.BackColor = Color.Red;
                BuildingBox.BackColor = Color.Red;
                ApartamentBox.BackColor = Color.Red;
            }
        }
        public void TextBoxClear()
        {
            PostIndexBox.Clear();
            CountryBox.Clear();
            CityBox.Clear();
            StreetBox.Clear();
            BuildingBox.Clear();
            ApartamentBox.Clear();
        }
        private void PostIndexBox_TextChanged(object sender, EventArgs e)
        {
            int newIndex;
            bool success = int.TryParse(PostIndexBox.Text, out newIndex);
            PostIndexBox.MaxLength = 6;
            System.Windows.Forms.TextBox TB = (System.Windows.Forms.TextBox)sender;
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            
            if (success)
            {
                address.SetIndex = newIndex;
            }
            if (!success && PostIndexBox.TextLength != 0)
            {
                tt.Show("Некорректно введенные данные!", TB, 2500);
                PostIndexBox.BackColor = Color.Red;
                return;
            }
            else PostIndexBox.BackColor = Color.White;
            


        }

        private void CountryBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Country", CountryBox, CountryBox.MaxLength = 50);
            if (CountryBox.TextLength != 0)
            {
                CountryBox.BackColor = Color.White;
            }
            address.SetCountry = CountryBox.Text;   

        }

        private void CityBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "City", CityBox, CityBox.MaxLength = 50);
            if (CityBox.TextLength != 0)
            {
                CityBox.BackColor = Color.White;
            }
            address.SetCity = CityBox.Text;

        }

        private void StreetBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Street", StreetBox, StreetBox.MaxLength = 100);
            if (StreetBox.TextLength != 0)
            {
                StreetBox.BackColor = Color.White;
            }
            address.SetStreet = StreetBox.Text;
        }

        private void BuildingBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Building", BuildingBox, BuildingBox.MaxLength = 10);
            address.SetBuilding = BuildingBox.Text;
            if (BuildingBox.TextLength != 0)
            {
                BuildingBox.BackColor = Color.White;
            }

        }

        private void ApartamentBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Apartament", ApartamentBox, ApartamentBox.MaxLength = 10);
            address.SetApartament = ApartamentBox.Text;
            if (ApartamentBox.TextLength != 0)
            {
                ApartamentBox.BackColor = Color.White;
            }
        }

        private void AdressControl_Load(object sender, EventArgs e)
        {

        }
    }
}
