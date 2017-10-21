using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class oil
    {
        private int temperature = 100;
        public int Temperature { get { return temperature; } }
        public void GetHead()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }
    }
}
