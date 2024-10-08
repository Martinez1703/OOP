using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;
using WindowsFormsApp1.View.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.View.Tabs
{
    [Serializable]
    public partial class CustomersTab : UserControl
    {
        public List<Customer> _customer = new List<Customer>();
        ToolTipExeptions toolTipExeptions = new ToolTipExeptions();

        private bool ClearCalled = false;
        public CustomersTab()
        {
            InitializeComponent();
        }
        public List<Customer> Customers
        {
            get { return _customer; }
            set { _customer = value; }
        }
        public bool IsClearCalled()
        {
            return ClearCalled;
        }
        public void CustomerListBox_Refresh()
        {
            CustomerListBox.DataSource = null;
            CustomerListBox.DataSource = _customer;
        }
        public void TextBoxClear() 
        { 
            ClearCalled = true; 
            IdBox.Clear();
            FullNameBox.Clear();
            adressControl1.TextBoxClear();
            ClearCalled = false;
        }  
        public int Index(bool choose)
        {
            if (choose)
            {
                int index = CustomerListBox.SelectedIndex;
                return index;
            }
            else
            {
                return -1;
            }
        }
        private void CustomersTab_Load(object sender, EventArgs e)
        {
            CustomerListBox_Refresh();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.Items.Count == 0 && CustomerListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                int index = CustomerListBox.SelectedIndex;
                _customer.RemoveAt(index);
                CustomerListBox_Refresh();
                TextBoxClear();

            }   
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameBox.Text) || string.IsNullOrEmpty(adressControl1.PostIndexBox.Text) 
                || string.IsNullOrEmpty(adressControl1.CountryBox.Text) || string.IsNullOrEmpty(adressControl1.CityBox.Text)
                || string.IsNullOrEmpty(adressControl1.StreetBox.Text)  || string.IsNullOrEmpty(adressControl1.BuildingBox.Text)
                || string.IsNullOrEmpty(adressControl1.ApartamentBox.Text))

            {
                MessageBox.Show("Для добавления заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FullNameBox.BackColor = Color.Red;
                adressControl1.TextBoxColoring(false);
                return;
            }
            else
            {
                int Index = Convert.ToInt32(adressControl1.PostIndexBox.Text);
                string Country = adressControl1.CountryBox.Text;
                string City = adressControl1.CityBox.Text;
                string Street = adressControl1.StreetBox.Text;
                string Building = adressControl1.BuildingBox.Text;
                string Apartament = adressControl1.ApartamentBox.Text;
                Customer customer = new Customer(FullNameBox.Text, Index, Country, City, Street, Building, Apartament);
                _customer.Add(customer);
                CustomerListBox_Refresh();
                FullNameBox.BackColor = Color.White;
                TextBoxClear();
            }


        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            int newIndex;
            var Index = int.TryParse(adressControl1.PostIndexBox.Text, out newIndex);
            var Country = adressControl1.CountryBox.Text;
            var City = adressControl1.CityBox.Text;
            var Street = adressControl1.StreetBox.Text;
            var Building = adressControl1.BuildingBox.Text;
            var Apartament = adressControl1.ApartamentBox.Text;
            if (CustomerListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FullNameBox.TextLength == 0)
            {
                MessageBox.Show("Для редактирования заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FullNameBox.BackColor = Color.Red;
                return;
            }

            Customer customer = (Customer)CustomerListBox.SelectedItem;
            int index = _customer.IndexOf(customer);

            _customer[index].SetAddress.SetIndex = Convert.ToInt32(adressControl1.PostIndexBox.Text);
            _customer[index].SetAddress.SetCity = adressControl1.CityBox.Text;
            _customer[index].SetAddress.SetStreet = adressControl1.StreetBox.Text;
            _customer[index].SetAddress.SetBuilding = adressControl1.BuildingBox.Text;
            _customer[index].SetAddress.SetApartament = adressControl1.ApartamentBox.Text;
            _customer[index] = customer;


            CustomerListBox_Refresh();

            FullNameBox.BackColor = Color.White;
            TextBoxClear();

        }

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CustomerListBox.SelectedIndex != -1)
            {
                int index = CustomerListBox.SelectedIndex;
                IdBox.Text = _customer[index].GetId().ToString();
                FullNameBox.Text = _customer[index].SetFullName;
                adressControl1.PostIndexBox.Text = Convert.ToString(_customer[index].SetAddress.SetIndex);
                adressControl1.CountryBox.Text = _customer[index].SetAddress.SetCountry;
                adressControl1.CityBox.Text = _customer[index].SetAddress.SetCity;
                adressControl1.StreetBox.Text = _customer[index].SetAddress.SetStreet;
                adressControl1.BuildingBox.Text = _customer[index].SetAddress.SetBuilding;
                adressControl1.ApartamentBox.Text = _customer[index].SetAddress.SetApartament;
            }
        }

        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            TextBoxClear();
            CustomerListBox.SelectedItem = null;
        }

        private void FullnameBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "FullName", FullNameBox, FullNameBox.MaxLength = 200);
            int index = Index(true);
            if (IsClearCalled() == true)
            {
                index = Index(false);
            }
            if (FullNameBox.TextLength != 0)
            {
                FullNameBox.BackColor = Color.White;
            }
            if (FullNameBox.TextLength != 0 && index != -1)
            {
                _customer[index].SetFullName = FullNameBox.Text;
                CustomerListBox_Refresh();
            }
            else
            {
                return;
            }
        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adressControl1_Load(object sender, EventArgs e)
        {

        }
    }

}
