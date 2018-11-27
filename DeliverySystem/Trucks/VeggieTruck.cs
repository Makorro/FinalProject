using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Trucks
{
    class VeggieTruck : Truck
    {
        public VeggieTruck()
        {
            this.DeliveryProduct = ProductList.GetProductById(ProductList.GetVegetablesId());
            this.Capacity = 95;
        }
    }
}
