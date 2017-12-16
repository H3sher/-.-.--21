using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class HolodTap
    {

		public bool State { set; get; }
		public void WashPotato(Ice p)
		{
			if (State)
			{
				p.Dirty = 0;

			}
		}

		public void WashCarrot(Chokolate c)
		{
			if (State)
			{
				c.Dirty = 0;

			}
		}


		public void WashOnion(Icecream o)
		{
			if (State)
			{
				o.Dirty = 0;

			}
		}
		public Holod GetWater() {
            if (State)
            {
                return new Holod();

            }
            else {
                return null;
            }
        }
    }
}
