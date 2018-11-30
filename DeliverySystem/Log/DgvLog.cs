using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    class DgvLog : LogObserver
    {
        private DataGridSingleton datagrid_singleton;

        public DgvLog()
        {
            IdLog = 2;
            LogName = "DataGridView Log";
            datagrid_singleton = DataGridSingleton.GetReference();
            datagrid_singleton.Show();
        }

        public override void Close()
        {
            datagrid_singleton.Close();
        }

        public override void ConcreteLog(LogItem log)
        {
            datagrid_singleton.AddLog(log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
