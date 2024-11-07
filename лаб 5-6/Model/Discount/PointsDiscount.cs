using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    //приобретение интерфейса
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int _points;
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
        public int Points { get; private set; }

        public string Info
        {
            get { return $"Накопительная – {Points} баллов"; }
        }
        /// <summary>
        /// Рассчитывает сумму скидки на основе общей стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = items.Sum(item => item.SetCost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            return Math.Min(maxDiscount, totalCost);
        }
        /// <summary>
        /// Применяет скидку к общей стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки.</returns>
        public double Apply(List<Item> items)
        {
            double totalCost = items.Sum(item => item.SetCost);
            double maxDiscount = Math.Min(totalCost * 0.3, Points);
            Points -= (int)maxDiscount;
            return Math.Min(maxDiscount, totalCost);
        }
        /// <summary>
        /// Обновляет количество баллов на основе общей стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalCost = items.Sum(item => item.SetCost);
            Points += (int)Math.Ceiling(totalCost * 0.1);
        }
        /// <summary>
        /// Сравнивает текущий экземпляр с другим экземпляром <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="other">Другой экземпляр <see cref="PointsDiscount"/>.</param>
        /// <returns>Результат сравнения.</returns>
        public int CompareTo(PointsDiscount other)
        {

            if (this.Points == other.Points) return 0;
            if (this.Points < other.Points) return -1;
            if (this.Points > other.Points) return 1;
            else { throw new NotImplementedException(); }
        }
    }
}
