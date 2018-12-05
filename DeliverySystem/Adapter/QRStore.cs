using DeliverySystem.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class QRStore
    {
        public int idStore { get; set; }
        public string storeName { get; set; }
        public List<Product> products { get; set; }

        public QRStore(int id, string name)
        {
            idStore = id;
            storeName = name;
        }

        public QRStore()
        {

        }
    }
}
