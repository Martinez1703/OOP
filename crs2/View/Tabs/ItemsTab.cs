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
using System.Xml.Linq;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.View.Tabs
{
    [Serializable]
    public partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        ToolTipExeptions toolTipExeptions = new ToolTipExeptions();
        private bool ClearCalled = false;

        public ItemsTab()
        {
            InitializeComponent();
            CategoryBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryBox.Text = null;
        }
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public int Index (bool choose)
        {
            if (choose)
            {
                int index = ItemListBox.SelectedIndex;
                return index;
            }
            else
            {
                return -1;
            }
        }
        public void TextBoxClear()
        {
            ClearCalled = true;
            IdBox.Clear();
            NameBox.Clear();
            DescriptionBox.Clear();
            CostBox.Clear();
            CategoryBox.Text = null;
            ClearCalled = false;

        }
        public bool IsClearCalled()
        {
            return ClearCalled;
        }
        public void ItemsListBox_Refresh()
        {
            ItemListBox.DataSource = null;
            ItemListBox.DataSource = _items;
        }
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ItemsListBox_Refresh();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (NameBox.TextLength == 0 || CostBox.TextLength == 0)
            {
                MessageBox.Show("Для добавления заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameBox.BackColor = Color.Red;
                CostBox.BackColor = Color.Red;
            }
            else
            {
                Category category = (Category)CategoryBox.SelectedItem;
                double newCost;
                bool success = double.TryParse(CostBox.Text, out newCost);
                if (!success)
                {
                    throw new Exception("Вы ввели в поле Cost что-то кроме цифр! \nЛибо использовали точку вместо запятой!");
                }
                Item item = new Item(NameBox.Text, DescriptionBox.Text, Convert.ToDouble(CostBox.Text), category);
                _items.Add(item);
                ItemsListBox_Refresh();
                TextBoxClear();
                NameBox.BackColor = Color.White;
                DescriptionBox.BackColor = Color.White;
                CostBox.BackColor = Color.White;
                

            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemListBox.Items.Count == 0 && ItemListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = Index(true);
                _items.RemoveAt(index);
                ItemsListBox_Refresh();
                TextBoxClear();
            }
        }
        

        private void ItemListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = Index(true);
            if (index != -1)
            {
                IdBox.Text = _items[index].GetId().ToString();
                CostBox.Text = _items[index].Cost.ToString();
                NameBox.Text = _items[index].Name;
                DescriptionBox.Text = _items[index].Info;
                CategoryBox.Text = _items[index].category.ToString();
            }
        }


        private void ItemListBox_DoubleClick(object sender, EventArgs e)
        {
            TextBoxClear();
            ItemListBox.SelectedItem = null;
        }
        
        private void CostBox_TextChanged_1(object sender, EventArgs e)
        {
            toolTipExeptions.CostExeption(sender, "Cost", CostBox, CostBox.MaxLength = 8);
            int index = Index(true);
            double newCost;
            bool success = double.TryParse(CostBox.Text, out newCost);
            if (IsClearCalled() == true)
            {
                index = Index(false);
            }
            if (success && index != -1)
            {
                _items[index].Cost = newCost;
                ItemsListBox_Refresh();
            }
            if (CostBox.TextLength == 0 && index != -1)
            {
                _items[index].Cost = 0;
                ItemsListBox_Refresh();
                throw new Exception("Введите цену в поле Cost!");
            }
            else { return; }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Name", NameBox, NameBox.MaxLength = 200);
            int index = Index(true);
            if (IsClearCalled() == true) 
            {
                index = Index(false);
            }
            if (NameBox.TextLength != 0)
            {
                NameBox.BackColor = Color.White;
            }
            if (NameBox.TextLength != 0 && index != -1)
            {
                _items[index].Name = NameBox.Text;
                ItemsListBox_Refresh();
            }
            else 
            {
                return;
            }

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Description", DescriptionBox, DescriptionBox.MaxLength = 1000);
            int index = Index(true);
            if (IsClearCalled() == true)
            {
                index = Index(false);
            }
            if (index != -1)
            {
                _items[index].Info = DescriptionBox.Text;
                ItemsListBox_Refresh();
            }
            else
            {
                return;
            }
        }

      

    }
    
}
