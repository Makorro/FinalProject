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
    public partial class OrderProducts : Form
    {
        private Store current_store;
        private QRAdapter qrAdapter = new QRAdapter();

        public OrderProducts()
        {
            InitializeComponent();
        }

        public void SetCurrentStore(Store store)
        {
            current_store = store;
        }

        private void OrderProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductList.GetList();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                row.Cells["Quantity"].Value = 0;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<StoreProduct> products = new List<StoreProduct>();

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                {
                    int id = Convert.ToInt32(row.Cells["Id"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    StoreProduct prod = new StoreProduct(ProductList.GetProductById(id), quantity);
                    products.Add(prod);

                    Logger.Log(String.Format("Store requested {0} of product {1}", quantity, prod.name));
                }
            }

            current_store.products = products;
            qrAdapter.CreateQR(current_store);
            this.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
