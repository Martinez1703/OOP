using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    //приобретение интерфейса от IDiscount
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private Category _category;
        private double _currentDiscount;
        private double _totalSpentInCategory;
        public PercentDiscount()
        {

        }
        /// <summary>
        /// Конструктор, создающий процентную скидку для указанной категории.
        /// </summary>
        /// <param name="category">Категория, к которой применяется скидка.</param>
        /// <param name="initialDiscount">Начальная ставка скидки (по умолчанию 1).</param>
        /// <exception cref="ArgumentException">Исключение, если начальная ставка скидки не находится в пределах от 1 до 10.</exception>
        public PercentDiscount(Category category, double initialDiscount = 1)
        {
            if (initialDiscount < 1 || initialDiscount > 10)
            {
                throw new ArgumentException("Скидка должна быть от 1 до 10%");
            }

            this._category = category;
            this._currentDiscount = initialDiscount;
            this._totalSpentInCategory = 0;
        }
        /// <summary>
        /// Получает категорию, к которой применяется скидка.
        /// </summary>

        public Category Category
        {
            get { return _category; }
        }
        /// <summary>
        /// Получает текущую процентную ставку скидки.
        /// </summary>
        public double CurrentDiscount
        {
            get { return _currentDiscount; }
        }
        /// <summary>
        /// Получает информацию о скидке в виде строки.
        /// </summary>
        public string Info
        {
            get { return $"Процентная «{Category}» - {CurrentDiscount}%"; }
        }

        /// <summary>
        /// Вычисляет сумму скидки на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCategoryCost = items.Where(item => item.category == _category).Sum(item => item.SetCost);
            return (totalCategoryCost * _currentDiscount) / 100;
        }
        /// <summary>
        /// Применяет скидку к списку товаров и обновляет общую сумму, потраченную в категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма применённой скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            _totalSpentInCategory += items.Where(item => item.category == _category).Sum(item => item.SetCost);
            return discount;
        }
        /// <summary>
        /// Обновляет общую сумму, потраченную в категории, и при необходимости обновляет процентную скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            _totalSpentInCategory += items.Where(item => item.category == _category).Sum(item => item.SetCost);
            UpdateDiscount();
        }
        /// <summary>
        /// Обновляет процентную ставку скидки, если общая сумма, потраченная в категории, превышает 1000.
        /// </summary>
        private void UpdateDiscount()
        {
            if (_totalSpentInCategory >= 1000)
            {
                _currentDiscount = Math.Min(_currentDiscount + 1, 10);
                _totalSpentInCategory -= 1000;
            }
        }
        /// <summary>
        /// Сравнивает текущую скидку с другой скидкой.
        /// </summary>
        /// <param name="other">Другая скидка для сравнения.</param>
        /// <returns>0, если скидки равны; -1, если текущая скидка меньше; 1, если текущая скидка больше.</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (this.CurrentDiscount == other.CurrentDiscount) return 0;
            if (this.CurrentDiscount < other.CurrentDiscount) return -1;
            if (this.CurrentDiscount > other.CurrentDiscount) return 1;
            else { throw new NotImplementedException(); }
        }
    }
}
