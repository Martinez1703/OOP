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
    //Реализация интерфейсов
    public class Item : ICloneable, IComparable<Item>
    {
        ValueValidator valueValidator = new ValueValidator();
        OnlyID idGenerator = new OnlyID();
        private readonly int _id;
        private string _name;
        private double _cost;
        private string _info;
        //события

        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> CostChanged;
        public event EventHandler<EventArgs> InfoChanged;
        public Item(string name, string info, double cost, Category category)
        {
            _id = idGenerator.GetNextId();
            SetName = name;
            SetInfo = info;
            SetCost = cost;
            this.category = category;
        }
        // Реализация ICloneable вместо конструктора копирования
        public object Clone()
        {
            return new Item(this.SetName, this.SetInfo, this.SetCost, this.category);
        }

        public string SetName
        {
            get { return _name; }

            set
            {
                
                valueValidator.AssertStringOnLenght(SetName, 200, "Name");
                if (_name != value)
                {
                    var args = new EventArgs();
                    _name = value;
                    NameChanged?.Invoke(this, args);
                }
            }
        }
        public double SetCost
        {
            get { return _cost; }

            set 
            {
                valueValidator.MaxOrMinCost(SetCost, 100000, "Cost");
                if (_cost != value)
                {
                    var args = new EventArgs();
                    _cost = value;
                    CostChanged?.Invoke(this, args);
                }
            }
        }
        public string SetInfo
        {
            get { return _info; }

            set
            {

                valueValidator.AssertStringOnLenght(SetInfo, 1000, "Description");
                if (_info != value)
                {
                    var args = new EventArgs();
                    _info = value;
                    InfoChanged?.Invoke(this, args);
                }
            }
        } 
        public int GetId() { return _id; }
        public override string ToString()
        {
            return $"ID: {GetId()}, Name: {SetName}, Cost: {SetCost}";
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            var item2 = (Item)other;

            return (this.SetName == item2.SetName);
        }
        public bool Equals(Item other)
        {
            if (other == null)
                return false;

            if (object.ReferenceEquals(this, other))
                return true;

            return (this.SetName == other.SetName);

        }

        public int CompareTo(Item other)
        {
            if (this.SetCost == other.SetCost) return 0;
            if (this.SetCost < other.SetCost) return -1;
            if (this.SetCost > other.SetCost) return 1;
            else { throw new NotImplementedException(); }

        }

        public Category category { get; set; }
    }
}
