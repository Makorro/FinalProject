using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem.Log
{
    class ObserverFactory
    {
        public List<LogObserver> CreateObservers(List<CheckBox> checkBoxes)
        {
            List<LogObserver> logObservers = new List<LogObserver>(); 

            int id = 0;
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    switch (id)
                    {
                        case 0:
                            logObservers.Add(new FileLog());
                            break;
                        case 1:
                            logObservers.Add(new BoxLog());
                            break;
                        case 2:
                            logObservers.Add(new DgvLog());
                            break;
                    }
                }
                
                id++;
            }

            return logObservers;
        }
    }
}
