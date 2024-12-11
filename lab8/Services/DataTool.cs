using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Services
{/// <summary>
 /// Делегат для определения условия сортировки на основе элемента.
 /// </summary>
 /// <param name="item">Элемент, который будет проверяться.</param>
 /// <returns>Возвращает true, если элемент удовлетворяет условию.</returns>
    public delegate bool NashDel(Item item);

    /// <summary>
    /// Делегат для новой сортировки списка элементов.
    /// </summary>
    /// <param name="items2">Список элементов для сортировки.</param>
    /// <returns>Отсортированный список элементов.</returns>
    public delegate List<Item> newDelegate(List<Item> items2);

    /// <summary>
    /// Класс для работы с данными и сортировкой элементов.
    /// </summary>
    public class DataTool
    {
        /// <summary>
        /// Сортирует элементы по стоимости, превышающей 5000.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> sortStoim(List<Item> items)
        {
            return sort(items, item => item.SetCost > 5000);
        }

        /// <summary>
        /// Сортирует элементы по категории первого элемента в списке.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> sortCat(List<Item> items)
        {
            var cat = items[0].category;
            return sort(items, item => item.category == cat);
        }

        /// <summary>
        /// Сортирует элементы на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="del">Делегат, определяющий условие сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
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

        /// <summary>
        /// Список доступных критериев сортировки.
        /// </summary>
        public List<string> ComboSort = new List<string>()
    {
        "Name",
        "Cost (Ascending)",
        "Cost (Descending)"
    };

        /// <summary>
        /// Сортирует элементы по имени, содержащему заданную строку.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="name">Строка для поиска в имени элемента.</param>
        /// <returns>Список отсортированных элементов.</returns>
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

        /// <summary>
        /// Сортирует элементы по имени в алфавитном порядке.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> SortByName(List<Item> items)
        {
            return items.OrderBy(item => item.SetName).ToList();
        }

        /// <summary>
        /// Сортирует элементы по возрастанию стоимости.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> SortByCostAscending(List<Item> items)
        {
            return items.OrderBy(item => item.SetCost).ToList();
        }

        /// <summary>
        /// Сортирует элементы по убыванию стоимости.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> SortByCostDescending(List<Item> items)
        {
            return items.OrderByDescending(item => item.SetCost).ToList();
        }

        /// <summary>
        /// Выполняет новую сортировку на основе предоставленного делегата.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="sorter">Делегат, который выполняет сортировку.</param>
        /// <returns>Список отсортированных элементов.</returns>
        public List<Item> newSort(List<Item> items, newDelegate sorter)
        {
            return sorter(items);
        }
    }
}
