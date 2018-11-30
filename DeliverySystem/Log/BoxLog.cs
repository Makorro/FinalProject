using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class BoxLog : LogObserver
    {
        TextboxSingleton textbox_singleton;

        public BoxLog()
        {
            IdLog = 1;
            LogName = "Textbox Log";
            textbox_singleton = TextboxSingleton.GetReference();
            textbox_singleton.Show();
        }

        public override void ConcreteLog(LogItem Log)
        {
            textbox_singleton.AddLog(Log);
        }

        public override void Close()
        {
            textbox_singleton.Close();
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
