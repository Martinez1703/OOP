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
        public List<Item> Items = new List<Item>();
        public List<Customer> Customer = new List<Customer>();
        public List<Customer> CurrentCustomer = new List<Customer>();
        private bool _choose = true;
        public CartsTab()
        {
            InitializeComponent();
            AmountTextBox.Text = "0";
            TotalBox.Text = "0";
        }
        public void RefreshData()
        {
            ItemListBox.DataSource = null;
            ItemListBox.DataSource = Items;
            CustomerBox.DataSource = null;
            CustomerBox.DataSource = Customer;
        }
        public bool ChooseFlag(bool choose)
        {
            if (choose)
            {
                return _choose = true;
            }
            else
            {
                return _choose = false;
            }
        }
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            int index = CartBox.SelectedIndex;
            int cindex = CustomerBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                CartBox.Items.RemoveAt(index);
                CurrentCustomer[cindex].cart.Items.RemoveAt(index);
                AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
                double sum = 0;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    CheckState state = checkedListBox1.GetItemCheckState(i);

                    if (state == CheckState.Checked)
                    {
                        sum += CurrentCustomer[cindex].Discounts[i].Calculate(CurrentCustomer[cindex].cart.Items);
                    }
                }
                DiscAmountTextBox.Text = sum.ToString();
                TotalBox.Text = (Convert.ToDouble(AmountTextBox.Text) - sum).ToString();
            }
            
        
        }

        private void CustomerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            CustomerBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (CustomerBox.SelectedItem != null)
            {
                checkedListBox1.Items.Clear();
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
                DiscountRefresh();
                //AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
                //TotalBox.Text = (Convert.ToDouble(AmountTextBox.Text) - Convert.ToDouble(DiscAmountTextBox.Text)).ToString();
            }
            else
            {
                CartBox.Items.Clear();
                checkedListBox1.Items.Clear();
            }
            

        }
        public void DiscountRefresh()
        {
            checkedListBox1.Items.Clear();
            int index = CustomerBox.SelectedIndex;
            foreach(var discount in CurrentCustomer[index].Discounts)
            {
                checkedListBox1.Items.Add(discount.Info);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            double sum = 0.0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                CheckState state = checkedListBox1.GetItemCheckState(i);

                if (state == CheckState.Checked)
                {
                    sum += CurrentCustomer[index].Discounts[i].Calculate(CurrentCustomer[index].cart.Items);
                }
            }
            DiscAmountTextBox.Text = sum.ToString();
            TotalBox.Text = (Convert.ToDouble(AmountTextBox.Text) - sum).ToString();
        }
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
                MessageBox.Show("Выберите покупателя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cindex = CustomerBox.SelectedIndex;
            AmountTextBox.Text = CurrentCustomer[cindex].cart.Amount.ToString();
            if (CartBox.Items.Count > 0)
            {
                double sum = 0.0;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    CheckState state = checkedListBox1.GetItemCheckState(i);

                    if (state == CheckState.Checked)
                    {
                        sum += CurrentCustomer[cindex].Discounts[i].Calculate(CurrentCustomer[cindex].cart.Items);
                    }
                }
                DiscAmountTextBox.Text = sum.ToString();
                TotalBox.Text = (Convert.ToDouble(AmountTextBox.Text) - sum).ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            CartBox.Items.Clear();
            CurrentCustomer[cindex].cart.Items.Clear();
            DiscAmountTextBox.Text = "0";
            TotalBox.Text = "0";
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            int cindex = CustomerBox.SelectedIndex;
            List<Item> orderlist = new List<Item>();
            if (CurrentCustomer[cindex].IsPriority == true)
            {
                PriorityOrder priorityOrder = new PriorityOrder(CurrentCustomer[cindex].SetAddress, orderlist, Convert.ToDouble(CurrentCustomer[cindex].cart.Amount));
                orderlist.AddRange(CurrentCustomer[cindex].cart.Items);
                CurrentCustomer[cindex].Orders.Add(priorityOrder);
                priorityOrder.DiscountAmount = Convert.ToDouble(DiscAmountTextBox.Text);
                if (DiscAmountTextBox.Text != "0")
                {
                    for (int x = 0; x < CurrentCustomer[cindex].Discounts.Count; x++)
                    {
                        CheckState state = checkedListBox1.GetItemCheckState(x);

                        if (state == CheckState.Checked)
                        {
                            CurrentCustomer[cindex].Discounts[x].Apply(CurrentCustomer[cindex].cart.Items);
                        }
                    }
                }
                for (int a = 0; a < CurrentCustomer[cindex].Discounts.Count; a++)
                {
                    CurrentCustomer[cindex].Discounts[a].Update(CurrentCustomer[cindex].cart.Items);
                }
                CartBox.Items.Clear();
                AmountTextBox.Text = "0";
                CurrentCustomer[cindex].cart.Items.Clear();
            }
            else
            {
                Order order = new Order(CurrentCustomer[cindex].SetAddress, orderlist, Convert.ToDouble(CurrentCustomer[cindex].cart.Amount));
                orderlist.AddRange(CurrentCustomer[cindex].cart.Items);
                CurrentCustomer[cindex].Orders.Add(order);
                order.DiscountAmount = Convert.ToDouble(DiscAmountTextBox.Text);
                if (DiscAmountTextBox.Text != "0")
                {
                    for (int x = 0; x < CurrentCustomer[cindex].Discounts.Count; x++)
                    {
                        CheckState state = checkedListBox1.GetItemCheckState(x);

                        if (state == CheckState.Checked)
                        {
                            CurrentCustomer[cindex].Discounts[x].Apply(CurrentCustomer[cindex].cart.Items);
                        }
                    }
                }
                for (int a = 0; a < CurrentCustomer[cindex].Discounts.Count; a++)
                {
                    CurrentCustomer[cindex].Discounts[a].Update(CurrentCustomer[cindex].cart.Items);
                }
                CartBox.Items.Clear();
                AmountTextBox.Text = "0";
                CurrentCustomer[cindex].cart.Items.Clear();
            }
            DiscountRefresh();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int index = CustomerBox.SelectedIndex;
            if (checkedListBox1.Items.Count > 0 && index >= 0)
            {
                double sum = 0.0;

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    CheckState state = (i == e.Index) ? e.NewValue : checkedListBox1.GetItemCheckState(i);

                    if (state == CheckState.Checked)
                    {
                        sum += CurrentCustomer[index].Discounts[i].Calculate(CurrentCustomer[index].cart.Items);
                    }
                }

                DiscAmountTextBox.Text = sum.ToString();
                TotalBox.Text = (Convert.ToDouble(AmountTextBox.Text) - sum).ToString();
            }

        }
        
    }
}
