using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Trucks
{
    class BreadTruck : Truck
    {
        public BreadTruck()
        {
            this.DeliveryProduct = ProductList.GetProductById(ProductList.GetBreadId());
            this.Capacity = 270;
        }
    }
}
