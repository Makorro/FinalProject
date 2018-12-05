using DeliverySystem.Adapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class DeliveryRoute : Form
    {
        private List<Store> _sorted_stores_list;
        private QRAdapter _qrAdapter = new QRAdapter();
        private int _current_store = 0;
        private double _total_earning = 0;

        public DeliveryRoute()
        {
            InitializeComponent();
        }

        private  void UpdateUI()
        {
            tbVisitedStores.Text = (_current_store + 1).ToString();
            tbRemainingStores.Text = (_sorted_stores_list.Count - (_current_store + 1)).ToString();
            tbCurrentStore.Text = _sorted_stores_list[_current_store].storeName;
            tbTotalEarning.Text = _total_earning.ToString();
        }

        private void DeliveryRoute_Load(object sender, EventArgs e)
        {
            _sorted_stores_list = StoreList.GetSortedList();
            UpdateUI();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            
            Store current_store = _sorted_stores_list[_current_store];
            Logger.Log(String.Format("Delivery started, next store {0}", current_store.storeName));
            double total_payed = current_store.GetTotalProductsPrice();
            DialogResult dialog_result = MessageBox.Show("Your order has been delivered.\nYou have payed: $" +
                total_payed.ToString() + ".\nDo you want to order more products?", "Delivering to " + 
                current_store.storeName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Logger.Log(String.Format("Delivery successful, for store {0}", current_store.storeName));
            _total_earning += total_payed;

            if (dialog_result == DialogResult.Yes)
            {
                Logger.Log(String.Format("Store {0} is ready for creating  new order", current_store.storeName));
                OrderProducts order_products = new OrderProducts();
                order_products.SetCurrentStore(current_store);
                order_products.ShowDialog();
            }
            else
            {
                Logger.Log(String.Format("Store {0} will not create a new order", current_store.storeName));
                current_store.products = new List<StoreProduct>();
                _qrAdapter.CreateQR(current_store);
            }

            _current_store++;
            if (_current_store == _sorted_stores_list.Count)
            {
                Form fstores = new fStores();
                fstores.Show();
                Logger.Log(String.Format("You have finished delivering today's products. Hooray!"));
                this.Close();
            }
            else
            {
                UpdateUI();
            }
        }
    }
}
