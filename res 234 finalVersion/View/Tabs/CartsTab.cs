using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        //Объявление класса и переменных
        public List<Item> Items = new List<Item>();
        public List<Customer> Customer = new List<Customer>();
        public List<Customer> CurrentCustomer = new List<Customer>();

        public CartsTab()
        {
            InitializeComponent();
        }
        //Метод для обновления данных в списках товаров и клиентов.
        public void ClearData()
        {
            ItemListBox.DataSource = null;
            ItemListBox.DataSource = Items;
            CustomerBox.DataSource = null;
            CustomerBox.DataSource = Customer;
            CustomerBox.Text = null;
        }
        //Обработчик события нажатия кнопки для удаления товара из корзины.
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            int index = CartBox.SelectedIndex;
            CartBox.Items.RemoveAt(index);
            CurrentCustomer[cindex].cart.Items.RemoveAt(index);
            AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
        }
        //изменение выбранного клиента.
        private void CustomerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CustomerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (CustomerBox.SelectedItem != null)
            {
               
                CartBox.Items.Clear();
                if (!CurrentCustomer.Contains((Customer)CustomerBox.SelectedItem))
                {
                    CurrentCustomer.Add((Customer)CustomerBox.SelectedItem);
                }

                int index = CustomerBox.SelectedIndex;
                var t = CurrentCustomer[index].cart.Items;

                if (t.Count == 0)
                {
                    CartBox.Items.Clear();
                }
                else
                {
                    foreach (var item in t)
                    {
                        CartBox.Items.Add(item);
                    }
                }
                int cindex = CustomerBox.SelectedIndex;
                AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
            }
            else
            {
                CartBox.Items.Clear();
            }
            

        }
        //кнопка для добавления товара в корзину.
        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (CustomerBox.SelectedItem != null)
            {
                int index = CustomerBox.SelectedIndex;
                CartBox.Items.Add(ItemListBox.SelectedItem);
                int Itemindex = ItemListBox.SelectedIndex;
                Item item = (Item)ItemListBox.Items[Itemindex];
                CurrentCustomer[index].cart.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Выберите покупателя!");
                return;
            }
            int cindex = CustomerBox.SelectedIndex;
            AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            CartBox.Items.Clear();
            CurrentCustomer[cindex].cart.Items.Clear();
        }
        //Создание заказа с проверкой на преоритетность
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            List<Item> orderlist = new List<Item>();
            if (CurrentCustomer[cindex].IsPriority == true)
            {
                PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer[cindex].SetAddress, orderlist, Convert.ToDouble(CurrentCustomer[cindex].cart.Amount));
                orderlist.AddRange(CurrentCustomer[cindex].cart.Items);
                CurrentCustomer[cindex].Orders.Add(priorityOrder);
                CartBox.Items.Clear();
                AmountTextBox.Text = "0";
                CurrentCustomer[cindex].cart.Items.Clear();
            }
            else
            {
                Order order = new Order(CurrentCustomer[cindex].SetAddress, orderlist, Convert.ToDouble(CurrentCustomer[cindex].cart.Amount));
                orderlist.AddRange(CurrentCustomer[cindex].cart.Items);
                CurrentCustomer[cindex].Orders.Add(order);
                CartBox.Items.Clear();
                AmountTextBox.Text = "0";
                CurrentCustomer[cindex].cart.Items.Clear();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
