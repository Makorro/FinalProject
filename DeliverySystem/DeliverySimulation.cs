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
    public partial class DeliverySimulation : Form
    {
        private List<NumericUpDown> nuds;
        private TruckFactory TF;
        private int _trucks_count = 0;

        public DeliverySimulation()
        {
            InitializeComponent();
            TF = new TruckFactory();
        }

        private void DeliverySimulation_Load(object sender, EventArgs e)
        {
            nudBread.Maximum = Utils.number_bread_trucks;
            nudVegetables.Maximum = Utils.number_vegetables_trucks;
            nudDrinks.Maximum = Utils.number_drinks_trucks;

            nuds = new List<NumericUpDown>()
            {
                nudVegetables,
                nudDrinks,
                nudBread
            };
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            Logger.Log("Simulation started.");
            TF.CleanFleet();

            Dictionary<int, int> order_quantity = new Dictionary<int, int>();
            List<Truck> trucks = TF.Trucks;
            string simulation_ans = "";

            int i = 1;
            bool is_possible = true;

            foreach (var nud in nuds)
            {
                TF.GetTrucks(i, Convert.ToInt32(nud.Value));
                i++;
            }

            foreach (var store in StoreList.GetStores())
            {
                foreach (var product in store.products)
                {
                    if (order_quantity.ContainsKey(product.idProduct))
                    {
                        order_quantity[product.idProduct] += product.quantity;
                    }
                    else
                    {
                        order_quantity.Add(product.idProduct, product.quantity);
                    }
                }
            }

            foreach (var truck in trucks)
            {
                if (order_quantity.ContainsKey(truck.DeliveryProduct.Id))
                {
                    order_quantity[truck.DeliveryProduct.Id] -= truck.Capacity;
                }
            }

            foreach (var product in order_quantity)
            {
                if (product.Value > 0)
                {
                    is_possible = false;
                    simulation_ans += "missing ";
                }
                else
                {
                    simulation_ans += "remain ";
                }

                simulation_ans += Math.Abs(product.Value).ToString() + " " + ProductList.GetProductById(product.Key).Name + "\n";
            }

            if (is_possible)
            {
                simulation_ans = "Is possible to deliver the products with this trucks.\n" + simulation_ans;
                btnStartDelivery.Enabled = true;
                lblSimulationAns.ForeColor = Color.Green;
                Logger.Log("Simulation finished, delivery is possible.");
            }
            else
            {
                simulation_ans = "Is not possible to deliver the products with this trucks.\n" + simulation_ans;
                btnStartDelivery.Enabled = false;
                lblSimulationAns.ForeColor = Color.Red;
                Logger.Log("Simulation finished, delivery is NOT possible. Please add more trucks.");
            }

            lblSimulationAns.Text = simulation_ans;
            lblSimulationAns.Visible = true;

        }

        private void btnStartDelivery_Click(object sender, EventArgs e)
        {
            Form deliveryRoute = new DeliveryRoute();
            deliveryRoute.Show();
            this.Close();
        }

        private void nudVegetables_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            if (Convert.ToInt32(num.Text) > num.Value)
            {
                _trucks_count--;
                Logger.Log(String.Format("Decreased number of vegetable trucks: using {0} trucks", _trucks_count));

            }
            else
            {
                if (_trucks_count == Utils.number_delivery_trucks_at_same_time)
                {
                    nudVegetables.Value = Convert.ToInt32(num.Text);
                }
                else
                {
                    _trucks_count++;
                    Logger.Log(String.Format("Increased number of vegetable trucks: using {0} trucks", _trucks_count));

                }
            }
        }

        private void nudDrinks_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            if (Convert.ToInt32(num.Text) > num.Value)
            {
                _trucks_count--;
                Logger.Log(String.Format("Decreased Number of soda trucks: using {0} trucks", _trucks_count));
            }
            else 
            {
                if (_trucks_count == Utils.number_delivery_trucks_at_same_time)
                {
                    nudDrinks.Value = Convert.ToInt32(num.Text);
                }
                else
                {
                    _trucks_count++;
                    Logger.Log(String.Format("Increased Number of soda trucks: using {0} trucks", _trucks_count));
                }
            }
        }

        private void nudBread_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            if (Convert.ToInt32(num.Text) > num.Value)
            {
                _trucks_count--;
                Logger.Log(String.Format("Decreased number of bread trucks: using {0} trucks", _trucks_count));

            }
            else
            {
                if (_trucks_count == Utils.number_delivery_trucks_at_same_time)
                {
                    nudBread.Value = Convert.ToInt32(num.Text);
                }
                else
                {
                    _trucks_count++;
                    Logger.Log(String.Format("Increased number of soda trucks: using {0} trucks", _trucks_count));

                }
            }
        }
    }
}
