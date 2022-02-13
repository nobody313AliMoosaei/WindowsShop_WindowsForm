using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsShop.Data_Class
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public double Price { set; get; }
        public int Number { set; get; } = 1;
        public int Entity { set; get; }


        public Product(int id, string name, string des, double pri , int entity)
        {
            Id = id;
            Name = name;
            Description = des;
            Price = pri;
            Entity = entity;
        }
        public Product(string name, string des, double pri, int entity)
        {
            Name = name;
            Description = des;
            Price = pri;
            Entity = entity;
        }
        public double TotalPrice()
        {
            return Number * Price;
        }
    }
}
