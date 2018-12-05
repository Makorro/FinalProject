using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliverySystem
{
    public abstract class SingletonForms
    {
        protected int number_references { get; set; }
        protected Form form { get; set; }

        public void Close()
        {
            if (number_references == 1)
            {
                form.Close();
            }

            number_references--;
        }
    }
}
