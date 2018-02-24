using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
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
			Brush brush1 = new SolidBrush(ColorBody);
			g.FillEllipse(brush1, startPosX, startPosY - 10, 185, 55);
			g.FillEllipse(brush1, startPosX - 5, startPosY - 15, 25, 70);
			if (motor)
			{

				Brush brush = new SolidBrush(dopColor);
				g.FillEllipse(brush, startPosX + 90, startPosY - 70, 15, 30);
				g.FillEllipse(brush, startPosX + 90, startPosY - 30, 15, 30);
				g.FillEllipse(brush, startPosX + 90, startPosY + 40, 15, 30);
				g.FillEllipse(brush, startPosX + 90, startPosY + 75, 15, 30);
			}


		}
	}
}
