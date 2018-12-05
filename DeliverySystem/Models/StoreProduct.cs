using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Adapter
{
    public class StoreProduct
    {
        public int idProduct { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }

        public StoreProduct(int id, string name, int quantity)
        {
            idProduct = id;
            this.name = name;
            this.quantity = quantity;
        }

        public StoreProduct(DBProduct dbProduct, int quantity)
        {
            idProduct = dbProduct.Id;
            name = dbProduct.Name;
            this.quantity = quantity;
        }

        public StoreProduct()
        {

        }
    }
}
