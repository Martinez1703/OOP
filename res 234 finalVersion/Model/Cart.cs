using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.View.Tabs;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Cart
    {
        List<Item> items = new List<Item>();
        public List<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
            }
        }
        public double Amount
        {
            get
            {
                double sum = 0.0;
                if (items == null)
                {
                    return sum;
                }
                foreach (Item item in items)
                {
                    sum += item.SetCost;
                }
                return sum;
            }
        }
    }
}
