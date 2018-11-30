using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class TextboxSingleton : SingletonForms
    {
        private static TextboxSingleton textbox_singleton = null;

        private TextboxSingleton()
        {
        }

        public static TextboxSingleton GetReference()
        {
            if (textbox_singleton == null)
            {
                textbox_singleton = new TextboxSingleton();
            }

            return textbox_singleton;
        }

        public void Show()
        {
            number_references++;
            if (number_references == 1)
            {
                form = new FBoxLog();
                form.Show();
            }
        }

        public void AddLog(LogItem log)
        {
            ((FBoxLog)form).AddLog(log);
        }
    }
}
