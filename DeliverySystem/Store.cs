using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Store
    {
        public int idStore { get; set; }
        public string storeName { get; set; }
        public List<Product> products { get; set; }

        public Store(int id, string name)
        {
            idStore = id;
            storeName = name;
            products = new List<Product>();
        }

        public Store()
        {

        }

        public double GetTotalProductsPrice()
        {
            double value = 0;

            foreach (var product in products)
            {
                value += product.quantity * ProductList.GetProductById(product.idProduct).Price;
            }

            return value;
        }
    }
}
