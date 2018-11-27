using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class SodaTruck : Truck
    {
        public SodaTruck()
        {
            this.DeliveryProduct = ProductList.GetProductById(ProductList.GetSodaId());
            this.Capacity = 120;
        }
    }
}
