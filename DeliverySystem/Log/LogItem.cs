using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem.Log
{
    public class LogItem
    {
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }

        public LogItem(DateTime timeStamp, string message)
        {
            TimeStamp = timeStamp;
            Message = message;
        }

        public override string ToString()
        {
            return TimeStamp.ToLongTimeString() + " | " + Message + "\n";
        }
    }
}
