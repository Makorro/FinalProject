using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace DeliverySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProductList.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fStores());

            //Store store = new Store(5, "VegetablesDrinkStore");
            //store.products.Add(new Product(1, "Vegetable", 8));
            //store.products.Add(new Product(2, "Drink", 2));

            //QRAdapter qRAdapter = new QRAdapter();

            //qRAdapter.CreateQR(store);

        }
    }
}
