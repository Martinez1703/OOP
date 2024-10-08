using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Services
{
    [Serializable]
    public class ValueValidator
    {

        public void AssertStringOnLenght(string value, int maxLenght, string propertyName)
        {
            if (value.Length > maxLenght)
            {
                throw new Exception($"{propertyName} Должен быть меньше {maxLenght} символов");
            }
        }

        public void MaxOrMinCost(double value, double maxCost, string propertyName)
        {
            if (value < 0 || value > maxCost)
            {
                throw new Exception($"{propertyName} должен быть не меньше 0 и не больше {maxCost}");
            }
        }
    }
}
