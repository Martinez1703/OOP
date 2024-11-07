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
        List<Item> _DisplayItems = new List<Item>();

        Errors toolTipExeptions = new Errors();
        Services.Label toolTipDescription = new Services.Label();

        DataTool DataTool = new DataTool();

        public event EventHandler<EventArgs> ItemsChanged;

        private bool ClearCalled = false;
        private bool RefreshCalled = false;

        public ItemsTab()
        {
            InitializeComponent();
            CategoryBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryBox.Text = null;
            comboBox1.DataSource = DataTool.ComboSort;
        }

        public List<Item> Items
        {
            get { return _items; }
            set {  _items = value; }

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
        private void CostChanged(object sender, EventArgs args)
        {
            toolTipDescription.TipTextBox(CostBox, "Цена изменилась");
        }
        private void NameChanged(object sender, EventArgs args)
        {
            toolTipDescription.TipTextBox(NameBox, "Название изменилось");
        }
        private void InfoChanged(object sender, EventArgs args)
        {
            toolTipDescription.TipTextBox(DescriptionBox, "Описание изменилось");
        }
        private void ItemsListChanged(object sender, EventArgs args)
        {
            MessageBox.Show("Список товаров обновлен", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public bool IsRefreshCalled()
        {
            return RefreshCalled;
        }
        public void ItemsListBox_Refresh()
        {
            RefreshCalled = true;
            if (textBox1.TextLength > 0)
            { 
                ItemListBox.DataSource = null;
                ItemListBox.DataSource = _DisplayItems;
                
            }
            else
            {
                ItemListBox.DataSource = null;
                ItemListBox.DataSource = _items;
            }
            RefreshCalled = false;
        }
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ItemsListBox_Refresh();
            ItemListBox.SelectedItem = null;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (NameBox.TextLength == 0 || CostBox.TextLength == 0 || CategoryBox.Text == "")
            {
                MessageBox.Show("Для добавления заполните все необходимые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NameBox.BackColor = Color.Red;
                CostBox.BackColor = Color.Red;
                CategoryBox.BackColor = Color.Red;
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
                ItemListBox.SelectedIndex = -1;
                MessageBox.Show($"Товар {item.SetName} добавлен в список товаров", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (textBox1.TextLength > 0)
                {
                    _DisplayItems.RemoveAt(index);
                    int t = _items.IndexOf((Item)ItemListBox.SelectedItem);
                    MessageBox.Show($"Товар {_items[t].SetName} удален из списка товаров", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _items.RemoveAt(t);
                }
                else
                {
                    MessageBox.Show($"Товар {_items[index].SetName} удален из списка товаров", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _items.RemoveAt(index);
                }
                ItemsListBox_Refresh();
                TextBoxClear();

            }
        }
        

        private void ItemListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (IsRefreshCalled() == true)
            {
                return;
            }
            else
            {
                if (ItemListBox.SelectedIndex != -1)
                {
                    int index = Index(true);
                    if (textBox1.TextLength > 0)
                    {
                        int index1 = Index(true);
                        IdBox.Text = _items[index1].GetId().ToString();
                        CostBox.Text = _items[index1].SetCost.ToString();
                        NameBox.Text = _items[index1].SetName;
                        DescriptionBox.Text = _items[index1].SetInfo;
                        CategoryBox.Text = _items[index1].category.ToString();
                    }
                    else
                    {
                        if (comboBox1.SelectedItem != null)
                        {
                            int index2 = Index(true);
                            IdBox.Text = _items[index2].GetId().ToString();
                            CostBox.Text = _items[index2].SetCost.ToString();
                            NameBox.Text = _items[index2].SetName;
                            DescriptionBox.Text = _items[index2].SetInfo;
                            CategoryBox.Text = _items[index2].category.ToString();
                        }
                        else
                        {
                            IdBox.Text = _items[index].GetId().ToString();
                            CostBox.Text = _items[index].SetCost.ToString();
                            NameBox.Text = _items[index].SetName;
                            DescriptionBox.Text = _items[index].SetInfo;
                            CategoryBox.Text = _items[index].category.ToString();
                        }
                    }
                }
            } 
        }


        private void ItemListBox_DoubleClick(object sender, EventArgs e)
        {
            ItemListBox.SelectedIndex = -1;
            TextBoxClear();
        }
        
        private void CostBox_TextChanged_1(object sender, EventArgs e)
        {
            toolTipExeptions.CostExeption(sender, "Cost", CostBox, CostBox.MaxLength = 8);

            double newCost;
            if (textBox1.TextLength > 0)
            {
                int index = Index(true);
                bool success = double.TryParse(CostBox.Text, out newCost);
                if (IsClearCalled() == true)
                {
                    index = Index(false);
                }
                if (success && index != -1)
                {
                    _DisplayItems[index].SetCost = newCost;
                }
                if (CostBox.TextLength == 0 && index != -1)
                {
                    _DisplayItems[index].SetCost = 0;
                    CostBox.Text = "0";
                    MessageBox.Show("Введите цену в поле Cost!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (index != -1)
                {
                    _items[index].CostChanged -= CostChanged;
                    _items[index].CostChanged += CostChanged;
                }
            }
            else
            {
                int index = Index(true);
                bool success = double.TryParse(CostBox.Text, out newCost);
                if (IsClearCalled() == true)
                {
                    index = Index(false);
                }
                if (success && index != -1)
                {
                    _items[index].SetCost = newCost;

                }
                if (CostBox.TextLength == 0 && index != -1)
                {
                    _items[index].SetCost = 0;
                    CostBox.Text = "0";
                    MessageBox.Show("Введите цену в поле Cost!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (index != -1)
                {
                    _items[index].CostChanged -= CostChanged;
                    _items[index].CostChanged += CostChanged;
                }
            }
            
            ItemsListBox_Refresh();
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Name", NameBox, NameBox.MaxLength = 200);
            if (textBox1.TextLength > 0)
            {
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
                    _DisplayItems[index].SetName = NameBox.Text;
                    
                }
                if (index != -1)
                {
                    _items[index].NameChanged -= NameChanged;
                    _items[index].NameChanged += NameChanged;
                }

            }
            else
            {
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
                    _items[index].SetName = NameBox.Text;
                }
                if (index != -1)
                {
                    _items[index].NameChanged -= NameChanged;
                    _items[index].NameChanged += NameChanged;
                }

            }
            ItemsListBox_Refresh();

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            toolTipExeptions.Exeption(sender, "Description", DescriptionBox, DescriptionBox.MaxLength = 1000);
            if (textBox1.TextLength > 0)
            {
                int index = Index(true);
                if (IsClearCalled() == true)
                {
                    index = Index(false);
                }
                if (index != -1)
                {
                    _DisplayItems[index].SetInfo = DescriptionBox.Text;
                }
                if (index != -1)
                {
                    _items[index].InfoChanged -= InfoChanged;
                    _items[index].InfoChanged += InfoChanged;
                }

            }
            else
            {
                int index = Index(true);
                if (IsClearCalled() == true)
                {
                    index = Index(false);
                }
                if (index != -1)
                {
                    _items[index].SetInfo = DescriptionBox.Text;
                }
                if (index != -1)
                {
                    _items[index].InfoChanged -= InfoChanged;
                    _items[index].InfoChanged += InfoChanged;
                }
            }
            ItemsListBox_Refresh();
        }

        private void IdBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Айди товара");
        }

        private void CostBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Цена товара " +
                "\nМаксимальная цена товара равна 100000" +
                "\nПоле, обязательное к заполнению!");          
        }

        private void NameBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Название товара " +
                "\nМаксимальное число элементов поля Name равно 200 символам" +
                "\nПоле, обязательное к заполнению!");
        }

        private void DescriptionBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipTextBox(sender, "Описание товара" +
                "\nМаксимальное число элементов поля Description равно 1000 символам");
        }

        private void ItemListBox_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipListBox(sender, "Список товаров");
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Добавить товар");
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Удалить выбранный товар");
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            toolTipDescription.TipButton(sender, "Отредактировать выбранный товар");
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolTipDescription.TipComboBox(sender, "Выбрать категорию товара");
            CategoryBox.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBoxClear();
            string name = textBox1.Text;
            if (textBox1.Text.Length > 0 )
            {
                TextBoxClear();
                _DisplayItems.Clear();
                _DisplayItems.AddRange(DataTool.sortName(_items, name));
                ItemListBox.DataSource = null;
                ItemListBox.DataSource = _DisplayItems;
            }
            else
            {
                TextBoxClear();
                _DisplayItems.Clear();
                ItemListBox.DataSource = null;
                ItemListBox.DataSource = _items;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
                ItemListBox.SelectedItem = null; 
                TextBoxClear();
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                _DisplayItems.Clear();
                if (comboBox1.Text == "Cost (Ascending)")
                {
                    _DisplayItems = DataTool.newSort(_items, DataTool.SortByCostAscending);
                    ItemListBox.DataSource = null;
                    ItemListBox.DataSource = _DisplayItems;
                }
                if (comboBox1.Text == "Cost (Descending)")
                {
                    _DisplayItems = DataTool.newSort(_items, DataTool.SortByCostDescending);
                    ItemListBox.DataSource = null;
                    ItemListBox.DataSource = _DisplayItems;
                }
                if (comboBox1.Text == "Name")
                {
                    _DisplayItems = DataTool.newSort(_items, DataTool.SortByName);
                    ItemListBox.DataSource = null;
                    ItemListBox.DataSource = _DisplayItems;
                }
                _items.Clear();
                _items.AddRange(_DisplayItems);
                ItemsListBox_Refresh();
            }
        }
    }
    
}
