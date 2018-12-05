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
        TextboxSingleton logElement;

        public BoxLog()
        {
            IdLog = 1;
            LogName = "Textbox Log";
            logElement = TextboxSingleton.GetReference();
            logElement.Show();
        }

        public override void ConcreteLog(LogItem Log)
        {
            logElement.AddLog(Log);
        }

        public override void Close()
        {
            logElement.Close();
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
