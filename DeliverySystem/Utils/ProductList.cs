using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public static class ProductList
    {
        private static List<DBProduct> _list = new List<DBProduct>();

        public static void Init()
        {
            if(_list.Count == 0)
            {
                Add("Frozen vegetables", 20.36);
                Add("Sodas", 8.50);
                Add("Bread", 11.50);
            }
        }

        public static void Add(string name, double price)
        {
            _list.Add(new DBProduct(_list.Count + 1, name, price));
        }

        public static List<DBProduct> GetList()
        {
            return _list;
        }

        public static int GetSodaId()
        {
            return 2;
        }

        public static int GetVegetablesId()
        {
            return 1;
        }

        public static int GetBreadId()
        {
            return 3;
        }

        public static DBProduct GetProductById(int id)
        {
            return _list.Find(x => x.Id == id);
        }
    }
}
