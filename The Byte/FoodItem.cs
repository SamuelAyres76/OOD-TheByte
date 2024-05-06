using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Byte
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FoodItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
