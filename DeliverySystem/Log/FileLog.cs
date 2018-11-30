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
        private FileSingleton file_singleton;

        public FileLog()
        {
            IdLog = 0;
            LogName = "File Log";
            file_singleton = FileSingleton.GetReference();
        }

        public override void Close()
        {
            file_singleton.Close();
        }

        public override void ConcreteLog(LogItem Log)
        {
            file_singleton.AddLog(Log);
        }

        public override int GetId()
        {
            return IdLog;
        }
    }
}
