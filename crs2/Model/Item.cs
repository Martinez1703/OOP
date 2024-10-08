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
        GenericOnlyId idGenerator = new GenericOnlyId();
        private readonly int _id;
        private string _name;
        private double _cost;
        private string _info;
        public Item(string name, string info, double cost, Category category)
        {
            _id = idGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            this.category = category;
        }

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
                valueValidator.AssertStringOnLenght(_name, 200, "Name");
            }
        }
        public double Cost
        {
            get { return _cost; }

            set 
            {
                _cost = value;
                valueValidator.MaxOrMinCost(_cost, 100000, "Cost");
            }
        }
        public string Info
        {
            get { return _info; }

            set
            {
                _info = value;
                valueValidator.AssertStringOnLenght(_info, 1000, "Description");
            }
        } 
        public int GetId() { return _id; }
        public override string ToString()
        {
            return $"ID: {GetId()}, Name: {Name}, Cost: {Cost}";
        }
        public Category category { get; set; }
    }
}
