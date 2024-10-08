using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    [Serializable]
    public class GenericOnlyId
    {
        public int GetNextId() 
        { 
            Random rnd = new Random();
            int id = rnd.Next(100);
            return id;
        }
    }
}
