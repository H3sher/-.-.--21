using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public class AirBus : AirPlane
	{
		private bool motor;
		private Color dopColor;
		public AirBus(int maxSpeed, int maxCountPassenger, double weigth, int tankcapacity, Color color,
            bool motor, Color dopColor) :
			base(maxSpeed, maxCountPassenger, weigth, tankcapacity, color)
		{
			this.motor = motor;
			this.dopColor = dopColor;
          
        }

        protected override void draw(Graphics g)
        {
            base.draw(g);
            if (motor)
            {
                Brush brush = new SolidBrush(Color.Black);
				
				g.FillEllipse(brush, startPosX + 70, startPosY - 20, 15, 30);
				g.FillEllipse(brush, startPosX + 70, startPosY + 40, 15, 30);
				
			}


        }
    }
}
