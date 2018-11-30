using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public partial class fStores : Form
    {
        public fStores()
        {
            InitializeComponent();
        }

        private void fStores_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(Utils.GetStoresPath());
            QRAdapter qrAdapter = new QRAdapter();

            var files = directory.GetFiles("*.png");

            Logger.Add(new FileLog());
            Logger.Log("DeliveryApp Started!");
            StoreList.Init();
            foreach (var image in files)
            {
                StoreList.Add(qrAdapter.ReadQR(image.Name));
            }

            dgvStores.DataSource = StoreList.GetStores().Select(o => new { Id = o.idStore, Name = o.storeName }).ToList();
            dgvStores.Columns["Name"].Width = 220;
        }

        private void btnDeliverOrder_Click(object sender, EventArgs e)
        {
            Form deliverySimulation = new DeliverySimulation();
            deliverySimulation.Show();
            this.Hide();
        }

        private void btnLogConfig_Click(object sender, EventArgs e)
        {
            Form logConfig = new FLogConfiguration();
            logConfig.Show();
        }
    }
}
