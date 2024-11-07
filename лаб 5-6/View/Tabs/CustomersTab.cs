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
        /// <summary>
        /// Объект для работы со скидками.
        /// </summary>
        DiscountTab DiscountTab = new DiscountTab();
        public PercentDiscount newPer { get; set; }
        public List<Customer> _customer = new List<Customer>();
        Errors toolTipExeptions = new Errors();
        Services.Label toolTipDescription = new Services.Label();
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
        
        public void AdressRefresh()
        {
            adressControl1.address.AddressChanged -= adressControl1.AdressChanged;
            adressControl1.address.AddressChanged += adressControl1.AdressChanged;
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
            DiscountlistBox.DataSource = null;
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
            CustomerListBox.SelectedItem = null;
        } /// <summary>
          /// Обработчик нажатия кнопки удаления клиента.
          /// </summary>
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
                IsPriority.Checked = false;
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
                var Index = Convert.ToInt32(adressControl1.PostIndexBox.Text);
                var Country = adressControl1.CountryBox.Text;
                var City = adressControl1.CityBox.Text;
                var Street = adressControl1.StreetBox.Text;
                var Building = adressControl1.BuildingBox.Text;
                var Apartament = adressControl1.ApartamentBox.Text;
                Customer customer = new Customer(FullNameBox.Text, Index, Country, City, Street, Building, Apartament);
                if (IsPriority.Checked == true)
                {
                    customer.IsPriority = true;
                }
                _customer.Add(customer);
                CustomerListBox_Refresh();
                FullNameBox.BackColor = Color.White;
                TextBoxClear();
                CustomerListBox.SelectedIndex = -1;
                IsPriority.Checked = false;
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
            _customer[index].IsPriority = IsPriority.Checked;
            _customer[index] = customer;


            CustomerListBox_Refresh();

            FullNameBox.BackColor = Color.White;
            TextBoxClear();
            CustomerListBox.SelectedIndex = -1;
            IsPriority.Checked = false;
            MessageBox.Show("Успешно отредактированно!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                IsPriority.Checked = _customer[index].IsPriority;
                DiscountlistBox.DataSource = null;
                DiscountlistBox.DataSource = _customer[index].Discounts;
                DiscountlistBox.DisplayMember = "Info";
            }
        }

        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            CustomerListBox.SelectedIndex = -1;

            TextBoxClear();
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


        private void IdBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Айди пользователя");
        }

        private void FullNameBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Имя пользователя " +
                "\nМаксимальная длина поля FullName равна 200 символам " +
                "\nПоле, обязательное к заполнению!");
        }

        private void CustomerListBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipListBox(sender, "Список пользователей");
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Добавить пользователя");
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Удалить выбранного пользователя");
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Отредактировать выбранный товар");
        }
        /// <summary>
        /// Обработчик нажатия кнопки добавления скидки.
        /// </summary>
        private void DaddButton_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedIndex != -1)
            {
                DiscountTab discountTab = new DiscountTab();
                discountTab.CustomersTabForm = this;
                int index = CustomerListBox.SelectedIndex;
                if (!discountTab.Visible)
                {
                    discountTab.ShowDialog();
                }
                if (newPer != null)
                {
                    for (int i = 0; i < _customer[index].Discounts.Count; i++)
                    {
                        if (newPer == null)
                        {
                            break;
                        }

                        if (newPer.Info == _customer[index].Discounts[i].Info)
                        {
                            newPer = null;
                            continue;
                        }

                    }
                    if (newPer == null)
                    {
                        return;
                    }
                    else
                    {
                        _customer[index].Discounts.Add(newPer);
                        DiscountlistBox.DataSource = null;
                        DiscountlistBox.DataSource = _customer[index].Discounts;
                        DiscountlistBox.DisplayMember = "Info";
                        newPer = null;
                    }

                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Выберите покупателя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Обработчик нажатия кнопки удаления скидки.
        /// </summary>
        private void DremoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomerListBox.SelectedIndex;
            int index2 = DiscountlistBox.SelectedIndex;
            if (DiscountlistBox.SelectedIndex == 0)
            {
                MessageBox.Show("Накопительную скидку удалить нельзя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (index2 > 0)
            {
                var del = _customer[index].Discounts[index2];
                _customer[index].Discounts.Remove(del);
                DiscountlistBox.DataSource = null;
                DiscountlistBox.DataSource = _customer[index].Discounts;
                DiscountlistBox.DisplayMember = "Info";
            }

        }

    }

}
