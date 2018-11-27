using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliverySystem.Trucks;

namespace DeliverySystem
{
    class TruckFactory
    {
        public List<Truck> Trucks;

        public TruckFactory()
        {
            Trucks = new List<Truck>();
        }

        public void GetTrucks(int product_id, int qty)
        {
            for(int i = 0; i < qty; i++)
            {
                Trucks.Add(GetTruckType(product_id));
            }
        }

        public void CleanFleet()
        {
            this.Trucks.Clear();
        }

        private Truck GetTruckType(int product_id)
        {
            switch (product_id)
            {
                case 1:     return new VeggieTruck();
                case 2:     return new SodaTruck();
                case 3:     return new BreadTruck();
                default:    return null;
            }
        }
    }
}
