using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View.Tabs;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class MainForm : Form
    {
        Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            prioretyOrder1.ListItems = _store.Items;
            cartsTab1.Customer = _store.Customers;
            cartsTab1.CurrentCustomer = _store.Customers;
            orderTab1.listcustomer = _store.Customers;

            
        }
        public void RGD()
        {
            if (prioretyOrder1.listcustomer.Count > 0)
            {
                return;
            }
            else
            {
                foreach (var PriorityCustomer in cartsTab1.CurrentCustomer)
                {
                    if (PriorityCustomer.IsPriority == true)
                    {
                        prioretyOrder1.ListCustomer.Add(PriorityCustomer);
                    }
                }
            }

        }
        private void customersTab1_Load(object sender, EventArgs e)
        {

        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {

        }

        private void cartsTab1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach(var customer  in cartsTab1.CurrentCustomer)
            //{
            //    customer.cart.Items.Clear();
            //}
            if (prioretyOrder1.IsClearCalled() == true)
            {
                foreach(var order in cartsTab1.CurrentCustomer)
                {
                    if (order.IsPriority == true)
                    {
                        order.cart.Items.Clear();
                        order.Orders.Clear();
                        orderTab1.TextBoxClear();

                        prioretyOrder1.ClearCalled = false;
                    }
                }
            }
            if (prioretyOrder1.IsAdd() == true || prioretyOrder1.IsRemove() == true)
            {
                foreach (var order in orderTab1.ListCustomer)
                {
                    foreach(var items in prioretyOrder1.ListCustomer)
                    {
                        foreach (var  item in order.Orders)
                        {
                            if (order.IsPriority == true)
                            {
                                order.cart.Items = items.cart.Items;
                                item.Price = items.cart.Amount;
                                prioretyOrder1.Add = false;
                                prioretyOrder1.Remove = false;

                            }
                        }

                    }
                   
                }
            }
            foreach(var time in prioretyOrder1.ListCustomer)
            {
                foreach(var customer in cartsTab1.CurrentCustomer)
                {
                    if (customer.IsPriority == true)
                    {
                        customer.Time = time.Time;
                    }
                }
            }
            cartsTab1.ClearData();
            orderTab1.RefreshData();
            RGD();
            prioretyOrder1.RefreshPriorityData();

        }

        private void prioretyOrder1_Load(object sender, EventArgs e)
        {

        }
    }
}
