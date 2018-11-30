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
    public partial class FLogConfiguration : Form
    {

        public FLogConfiguration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAddlogFile_Click(object sender, EventArgs e)
        {
            Logger.Add(new FileLog());
        }

        private void btnAddTextboxLog_Click(object sender, EventArgs e)
        {
            Logger.Add(new BoxLog());
        }

        private void btnAddDatagridViewLog_Click(object sender, EventArgs e)
        {
            Logger.Add(new DgvLog());
        }

        private void FLogConfiguration_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteLog",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            dgvLogs.DataSource = Logger.GetBindingList();
            dgvLogs.Columns.Add(btnColumn);
            dgvLogs.Columns["LogName"].Width = 125;

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLogs.Columns["DeleteLog"].Index)
            {
                int LogId = Convert.ToInt32(dgvLogs.Rows[e.RowIndex].Cells["IdLog"].Value);
                Logger.DeleteLog(LogId);
            }
        }
    }
}
