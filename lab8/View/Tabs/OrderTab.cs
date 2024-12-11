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
using WindowsFormsApp1.View.Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.View.Tabs
{
    public partial class OrderTab : UserControl
    {
        PriorityOrder prioretyOrder = new PriorityOrder();
        Customer customer;
        public List<Customer> ListCustomer = new List<Customer>();
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
        public OrderTab()
        {
            InitializeComponent();
            StatusBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusBox.Text = null;
            DataPanel.Visible = false;
            DeliveryTimeBox.DataSource = prioretyOrder.DeliveryTime;
            DeliveryTimeBox.Text = null;
        }
        public void TextBoxClear()
        {
            IdBox.Text = null;
            CreatedBox.Text = null;
            StatusBox.Text = null;
            AmountBox.Text = null;
            ItemListBox.DataSource = null;
            DeliveryTimeBox.DataSource = null;
        }
        public void RefreshData()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listcustomer.Count; i++)
            {
                if (listcustomer[i].Orders.Count > 0)
                {
                    var address = listcustomer[i].SetAddress;
                    if (listcustomer[i].Orders.Count > 1)
                    {
                        for (int j = 0; j < listcustomer[i].Orders.Count; j++)
                        {
                            dataGridView1.Rows.Add(listcustomer[i].GetId(), listcustomer[i].Orders[j].DateOfCreateOrder, listcustomer[i].Orders[j].Price, listcustomer[i].Orders[j].Total, $"{address.SetIndex}, {address.SetCountry}, {address.SetCity}, {address.SetStreet}, {address.SetBuilding}, {address.SetApartament}", listcustomer[i].Orders[j].GetStatus, listcustomer[i].SetFullName);
                            DeliveryTimeBox.Text = listcustomer[i].Time;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(listcustomer[i].GetId(), listcustomer[i].Orders[0].DateOfCreateOrder, listcustomer[i].Orders[0].Price, listcustomer[i].Orders[0].Total, $"{address.SetIndex}, {address.SetCountry}, {address.SetCity}, {address.SetStreet}, {address.SetBuilding}, {address.SetApartament}", listcustomer[i].Orders[0].GetStatus, listcustomer[i].SetFullName);
                        DeliveryTimeBox.Text = listcustomer[i].Time;
                    }
                }
            }

        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (dataGridView1.RowCount > 0 && StatusBox.SelectedItem != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                var date = dataGridView1.Rows[index].Cells[1].Value;
                DateTime dateTime = (DateTime)date;
                for (int i = 0; i < listcustomer.Count; i++)
                {
                    if (listcustomer[i].Orders.Count > 1)
                    {
                        for (int j = 0; j < listcustomer[i].Orders.Count; j++)
                        {
                            if (listcustomer[i].Orders[j].DateOfCreateOrder == dateTime)
                            {
                                listcustomer[i].Orders[j].GetStatus = (OrderStatus)StatusBox.SelectedItem;
                                RefreshData();
                                break;
                            }
                        }
                    }
                    if (listcustomer[i].Orders.Count == 1)
                    {
                        if (listcustomer[i].Orders[0].DateOfCreateOrder == dateTime)
                        {
                            listcustomer[i].Orders[0].GetStatus = (OrderStatus)StatusBox.SelectedItem;
                            RefreshData();
                            break;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IdBox.Text = row.Cells["Id"].Value.ToString();
                CreatedBox.Text = row.Cells["Created"].Value.ToString();
                AmountBox.Text = row.Cells["Price"].Value.ToString();
                TotalTextBox.Text = row.Cells["total"].Value.ToString();
                StatusBox.Text = row.Cells["OrderStatus"].Value.ToString();
                string address = row.Cells[4].Value.ToString();
                var individualStrings = address.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                adressControl1.PostIndexBox.Text = individualStrings[0];
                adressControl1.CountryBox.Text = individualStrings[1];
                adressControl1.CityBox.Text = individualStrings[2];
                adressControl1.StreetBox.Text = individualStrings[3];
                adressControl1.BuildingBox.Text = individualStrings[4];
                adressControl1.ApartamentBox.Text = individualStrings[5];
                var i = row.Cells[0].Value;
                var da = row.Cells[1].Value;
                DateTime date = (DateTime)da;
                int id = Convert.ToInt32(i);

                for (int j = 0; j < ListCustomer.Count; j++)
                {
                    if (ListCustomer[j].GetId() == id)
                    {
                        if (ListCustomer[j].IsPriority == true)
                        {
                            DataPanel.Visible = true;
                        }
                        else
                        {
                            DataPanel.Visible = false;
                        }
                        if (ListCustomer[j].Orders.Count > 1)
                        {
                            for (int k = 0; k < ListCustomer[j].Orders.Count; k++)
                            {
                                if (ListCustomer[j].Orders[k].DateOfCreateOrder == date)
                                {
                                    ItemListBox.DataSource = null;
                                    ItemListBox.DataSource = ListCustomer[j].Orders[k].Items;
                                    break;
                                }
                            }
                            break;
                        }
                        if (ListCustomer[j].Orders.Count == 1)
                        {
                            ItemListBox.DataSource = null;
                            ItemListBox.DataSource = ListCustomer[j].Orders[0].Items;
                            break;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            RefreshData();
        }
    }
}
