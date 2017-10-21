using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Knife
    {
        public void Clean(egg e)
        {
            if (e.Have_skin)
            {
                e.Have_skin = false;
            }
        }
    }
}
