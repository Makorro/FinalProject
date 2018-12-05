using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class DataGridSingleton : SingletonForms
    {
        private static DataGridSingleton datagrid_singleton = null;

        private DataGridSingleton()
        {
        }

        public static DataGridSingleton GetReference()
        {
            if (datagrid_singleton == null)
            {
                datagrid_singleton = new DataGridSingleton();
            }

            return datagrid_singleton;
        }

        public void Show()
        {
            number_references++;
            if (number_references == 1)
            {
                form = new FDgvLog();
                form.Show();
            }
        }

        public void AddLog(LogItem log)
        {
            ((FDgvLog)form).AddLog(log);
        }
    }
}
