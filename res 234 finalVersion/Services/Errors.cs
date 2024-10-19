using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1.Services
{
    [Serializable]
    public class Errors
    {
        private int VisibleTime = 2500;
       //ошибка о длине ввода
        public void Exeption (object sender, string NameOfBox, System.Windows.Forms.TextBox box, int lenght)
        {
            System.Windows.Forms.TextBox TB = (System.Windows.Forms.TextBox)sender;
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            if (box.TextLength == lenght)
            {
                tt.Show($"Достигнута максимальная длина поля {NameOfBox}, равная {lenght} символам", TB, VisibleTime);
            }
        }
        //коректность числа
        public void CostExeption (object sender, string NameOfBox, System.Windows.Forms.TextBox box, int lenght)
        {
            System.Windows.Forms.TextBox TB = (System.Windows.Forms.TextBox)sender;
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            double cost;
            bool success = double.TryParse(box.Text, out cost);
            if (!success && box.Text.Length != 0) 
            {
                tt.Show("Некорректно введенные данные, возможна ошибка!", TB, VisibleTime);
                box.BackColor = Color.Red;
            }
            else box.BackColor = Color.White;
            if (success)
            {
                if (cost == 100000)
                {
                    tt.Show($"Достигнуто максимальное значение целого числа для поля {NameOfBox}", TB, VisibleTime);
                }
                if (cost > 100000)
                {
                    tt.Show($"Превышено максимальное значение целого числа для поля {NameOfBox}!", TB, VisibleTime);
                    box.BackColor = Color.Red;
                }
                else box.BackColor = Color.White;
                if (cost == 99999.99)
                {
                    tt.Show($"Достигнуто максимальное значение десятичного числа для поля {NameOfBox}!", TB, VisibleTime);
                }

            }
            

        }
    }
}
