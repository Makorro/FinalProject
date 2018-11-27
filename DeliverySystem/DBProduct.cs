using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class DBProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public DBProduct()
        {

        }

        public DBProduct(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
