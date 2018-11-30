using DeliverySystem.Log;
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
    public partial class FDgvLog : Form
    {
        public FDgvLog()
        {
            InitializeComponent();
        }

        private void FDgvLog_Load(object sender, EventArgs e)
        {

        }

        public void AddLog(LogItem log)
        {   
            dgvLog.Rows.Add(log.TimeStamp.ToLongTimeString(), log.Message);
        }
    }
}
