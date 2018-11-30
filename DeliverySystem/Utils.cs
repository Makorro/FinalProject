using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public static class Utils
    {
        private static string _storesPath = System.AppDomain.CurrentDomain.BaseDirectory + "/Stores/";
        private static string _logPath = System.AppDomain.CurrentDomain.BaseDirectory + "/Log/log.txt";

        public const int number_bread_trucks = 3;
        public const int number_vegetables_trucks = 3;
        public const int number_drinks_trucks = 3;
        public const int number_delivery_trucks_at_same_time = 5;

        public static string GetStoresPath()
        {
            return _storesPath;
        }

        public static string GetLogPath()
        {
            return _logPath;
        }

        public static void SetStoresPath(string storesPath)
        {
            _storesPath = storesPath;
        }
    }
}
