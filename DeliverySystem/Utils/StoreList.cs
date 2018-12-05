using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public static class StoreList
    {
        private static List<Store> _stores;

        public static void Add(Store store)
        {
            _stores.Add(store);
        }

        public static void Init()
        {
            _stores = new List<Store>();
        }

        public static List<Store> GetStores()
        {
            return _stores;
        }

        public static List<Store> GetSortedList()
        {
            return _stores.OrderByDescending(x => x.GetTotalProductsPrice()).ToList();
        }
    }
}
