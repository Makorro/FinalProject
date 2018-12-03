using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class FileLog : LogObserver
    {
        private FileSingleton logElement;

        public FileLog()
        {
            IdLog = 0;
            LogName = "File Log";
            logElement = FileSingleton.GetReference();
        }

        public override void Close()
        {
            logElement.Close();
        }

        public override void ConcreteLog(LogItem Log)
        {
            logElement.AddLog(Log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
