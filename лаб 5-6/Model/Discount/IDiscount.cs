﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    //Интерфейс
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(List<Item> items);
        double Apply(List<Item> items);
        void Update(List<Item> items);

    }
}
