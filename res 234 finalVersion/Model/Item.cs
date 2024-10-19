using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Item
    {
        ValueValidator valueValidator = new ValueValidator();
        OnliID idGenerator = new OnliID();
        private readonly int _id;
        private string _name;
        private double _cost;
        private string _info;
        public Item(string name, string info, double cost, Category category)
        {
            _id = idGenerator.GetNextId();
            SetName = name;
            SetInfo = info;
            SetCost = cost;
            this.category = category;
        }

        public string SetName
        {
            get { return _name; }

            set
            {
                
                valueValidator.AssertStringOnLenght(SetName, 200, "Name");
                _name = value;
            }
        }
        public double SetCost
        {
            get { return _cost; }

            set 
            {
                valueValidator.MaxOrMinCost(SetCost, 100000, "Cost");

                _cost = value;
            }
        }
        public string SetInfo
        {
            get { return _info; }

            set
            {
                
                valueValidator.AssertStringOnLenght(SetInfo, 1000, "Description");
                _info = value;
            }
        } 
        public int GetId() { return _id; }
        public override string ToString()
        {
            return $"ID: {GetId()}, Name: {SetName}, Cost: {SetCost}";
        }
        public Category category { get; set; }
    }
}
