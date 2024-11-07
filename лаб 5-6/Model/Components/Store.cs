using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public Store()
        {
            Items = new List<Item>
            {
                new Item(" ", " ", 0, Category.Еда),
                 new Item("Бутер", "вкусный бутер", 80, Category.Еда),
                  new Item("Шуба", "шуба норковая", 1800, Category.Одежда),
                  new Item("Туфли", "туфли женские", 180, Category.Обувь),
                  new Item("Tide", "бытовая химия", 30, Category.Химия),
                  new Item("Булочка", "булочка с маком", 20, Category.Еда),
                  new Item("Iphone 16", "новая модель", 2000, Category.Техника),
                  new Item("Карачинская", "минеральная вода", 25, Category.Напитки)
            };
            Customers = new List<Customer>
            {
                new Customer("Никита",56, "Timeria", "Novegrad", "Lenina", "23", "100"),
                 new Customer("Никодим",12, "Timeria", "Novegrad", "ПУшкина", "2", "13"),
                  new Customer("Тихон",2, "Росссия", "Томск", "Фрунзе", "102", "56")

            };

        }
    }
    
}
