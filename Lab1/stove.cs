﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class stove
    {
        private pan pan;

        public bool State { get; set; }

        public pan Pan { set { pan = value; } get { return pan; } }

        public void Cook()
        {
            if (State)
            {
                while (!pan.is_ready())
                {
                    pan.GetHeat();
                }
            }
        }

    }
}
