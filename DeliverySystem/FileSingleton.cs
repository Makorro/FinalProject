using DeliverySystem.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    class FileSingleton
    {
        private static FileSingleton file_singleton = null;
        private Stream LogFile;
        private StreamWriter sw;
        private static int number_references { get; set; }

        private FileSingleton()
        {
            
        }

        public static FileSingleton GetReference()
        {
            if (file_singleton == null)
            {
                file_singleton = new FileSingleton();
            }

            number_references++;
            return file_singleton;
        }

        public void AddLog(LogItem Log)
        {
            LogFile = File.Open(Utils.GetLogPath(), FileMode.Append);
            sw = new StreamWriter(LogFile);
            sw.WriteLine(Log.ToString());
            sw.Close();
        }

        public void Close()
        {
            number_references--;
            if (number_references == 0)
            {
                sw.Close();
            }
        }
    }
}
