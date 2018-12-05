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
        private DataGridSingleton logElement;

        public DgvLog()
        {
            IdLog = 2;
            LogName = "DataGridView Log";
            logElement = DataGridSingleton.GetReference();
            logElement.Show();
        }

        public override void Close()
        {
            logElement.Close();
        }

        public override void ConcreteLog(LogItem log)
        {
            logElement.AddLog(log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
