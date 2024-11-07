using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{
    public delegate bool NashDel(Item item);
    public delegate List<Item> newDelegate(List<Item> items2);
    public class DataTool
    {
        public List<Item> sortStoim(List<Item> items)
        {
            return sort(items, item => item.SetCost > 5000);
        }

        public List<Item> sortCat(List<Item> items)
        {
            var cat = items[0].category;
            return sort(items, item => item.category == cat);
        }

        public List<Item> sort(List<Item> items, NashDel del)
        {
            List<Item> sortlist = new List<Item>();
            foreach (Item item in items)
            {
                if (del(item))
                {
                    sortlist.Add(item);
                }
            }
            return sortlist;
        }
        public List<string> ComboSort = new List<string>()
        {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"
        };
        public List<Item> sortName(List<Item> items, string name)
        {
            List<Item> sortlist = new List<Item>();
            foreach (var item in items)
            {
                item.SetName.ToLower();
                if (item.SetName.Contains(name))
                {
                    sortlist.Add(item);
                }
            }
            return sortlist;
        }
        public List<Item> SortByName(List<Item> items)
        {
            return items.OrderBy(item => item.SetName).ToList();
        }

        // Метод для сортировки по возрастанию стоимости
        public List<Item> SortByCostAscending(List<Item> items)
        {
            return items.OrderBy(item => item.SetCost).ToList();
        }
        // Метод для сортировки по убыванию стоимости
        public List<Item> SortByCostDescending(List<Item> items)
        {
            return items.OrderByDescending(item => item.SetCost).ToList();
        }
        //Новая сортироовка
        public List<Item> newSort(List<Item> items, newDelegate sorter)
        {
            return sorter(items);
        }

    }
}
