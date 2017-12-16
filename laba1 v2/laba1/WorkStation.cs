using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class WorkStation
    {
        public void Clean_potato(Ice p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }
        public void Clean_carrots(Chokolate p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }
        public void Clean_onion(Icecream p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }
    

        public void Cutting_c(Vanil t)
        {
            if (t.cutting)
            {
                t.cutting = false;
            }

        }


    }
}
