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
    public partial class FBoxLog : Form
    {
        public FBoxLog()
        {
            InitializeComponent();
        }

        private void FBoxLog_Load(object sender, EventArgs e)
        {

        }

        public void AddLog(LogItem Log)
        {
            tbLog.AppendText(Log.ToString());
        }
    }
}
