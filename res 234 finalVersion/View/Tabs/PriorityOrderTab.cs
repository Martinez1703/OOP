using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View.Tabs
{
    public partial class PriorityOrderTab : UserControl
    {
        Random rnd = new Random();
        PriorityOrder prioretyOrder = new PriorityOrder();
        public List<Item> ListItems = new List<Item>();
        public List<Customer> ListCustomer = new List<Customer>();
        public bool ClearCalled = false;
        public bool Add = false;
        public bool Remove = false;
        public List<Customer> listcustomer
        {
            get
            {
                return ListCustomer;
            }
            set
            {
                ListCustomer = value;
            }
        }



        public PriorityOrderTab()
        {
            InitializeComponent();
            DeliveryTimeBox.DataSource = prioretyOrder.DeliveryTime;
            DeliveryTimeBox.Text = null;
            StatusBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusBox.Text = null;
        }
        public bool IsClearCalled()
        {
            return ClearCalled;
        }
        public bool IsAdd()
        {
            return Add;
        }
        public bool IsRemove()
        {
            return Remove;
        }
        public void OrderClear()
        {
            IdBox.Text = null;
            CreatedBox.Text = null;
            StatusBox.Text = null;
            adressControl1.PostIndexBox.Text = null;
            adressControl1.CountryBox.Text = null;
            adressControl1.CityBox.Text = null;
            adressControl1.StreetBox.Text = null;
            adressControl1.BuildingBox.Text = null;
            adressControl1.ApartamentBox.Text = null;
            AmountTextBox.Text = null;
            OrderItemListBox.DataSource = null;
            DeliveryTimeBox.DataSource= null;
        }
        public void RefreshPriorityData()
        {
            if (listcustomer.Count != 0)
            {
                foreach (var customer in listcustomer)
                {
                    if (customer.Orders.Count > 0)
                    {
                        foreach (var order in customer.Orders)
                        {
                            var address = customer.SetAddress;
                            IdBox.Text = customer.GetId().ToString();
                            CreatedBox.Text = order.DateOfCreateOrder.ToString();
                            StatusBox.Text = order.GetStatus.ToString();
                            adressControl1.PostIndexBox.Text = address.SetIndex.ToString();
                            adressControl1.CountryBox.Text = address.SetCountry.ToString();
                            adressControl1.CityBox.Text = address.SetCity.ToString();
                            adressControl1.StreetBox.Text = address.SetStreet.ToString();
                            adressControl1.BuildingBox.Text = address.SetBuilding.ToString();
                            adressControl1.ApartamentBox.Text = address.SetApartament.ToString();
                            AmountTextBox.Text = order.Price.ToString();
                            OrderItemListBox.DataSource = null;
                            OrderItemListBox.DataSource = order.Items;
                            DeliveryTimeBox.Text = customer.Time;

                        }
                    }
                }

            }
            else { return; }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (ListItems.Count != 0)
            {
                Add = true;
                int index = rnd.Next(ListItems.Count);
                foreach (var customer in ListCustomer)
                {
                    foreach (var order in customer.Orders)
                    {
                        order.Items.Add(ListItems[index]);
                        order.Price = customer.cart.Amount;
                        AmountTextBox.Text = order.Amount.ToString();
                    }
                }

            }
            if (ListCustomer.Count == 0)
            {
                MessageBox.Show("В списках нет приоритетного пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshPriorityData();

        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemListBox.SelectedIndex;
            if (index != -1)
            {
                Remove = true;
                if (OrderItemListBox.Items.Count == 1)
                {
                    MessageBox.Show("В заказе должен быть хотя-бы 1 товар!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var customer in ListCustomer)
                {
                    foreach (var order in customer.Orders)
                    {
                        order.Items.RemoveAt(index);
                        order.Price = customer.cart.Amount;
                        AmountTextBox.Text = order.Amount.ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshPriorityData();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (ListCustomer.Count != 0)
            {
                ClearCalled = true;
                ListCustomer.Clear();
                RefreshPriorityData();
            }
            OrderClear();

        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (ListCustomer.Count > 0)
            {
                for (int i = 0; i < ListCustomer.Count; i++)
                {
                    if (ListCustomer[i].Orders.Count == 1)
                    {
                        ListCustomer[i].Orders[0].GetStatus = (OrderStatus)StatusBox.SelectedItem;
                        RefreshPriorityData();
                    }
                }
            }
            else { return; }
        }

        private void DeliveryTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeBox.SelectedItem != null)
            {
                foreach (var time in ListCustomer)
                {
                    time.Time = DeliveryTimeBox.SelectedItem.ToString();
                }
            }
            RefreshPriorityData();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
