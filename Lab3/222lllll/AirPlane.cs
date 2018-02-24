using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	public class AirPlane : AirTransport
	{

		public override int MaxSpeed
		{
			get
			{
				return base.MaxSpeed;
			}

			protected set
			{
				if (value > 0 && value < 300)
				{
					base.MaxSpeed = value;
				}
				else {
					base.MaxSpeed = 100;
				}
			}
		}

		public override int MaxCountPassengers
		{
			get
			{
				return base.MaxCountPassengers;
			}

			protected set
			{
				if (value > 0 && value < 10)
				{
					base.MaxCountPassengers = value;
				}
				else
				{
					base.MaxCountPassengers = 9;
				}
				
			}
		}

		public override double Weigth
		{
			get
			{
				return base.Weigth;
			}

			protected set
			{
				if (value > 1000 && value < 2000)
				{
					base.Weigth = value;
				}
				else
				{
					base.Weigth = 1500;
				}
			}
		}

		

		public override int tankcapacity
		{
			get
			{
				return base.tankcapacity;
			}

			protected set
			{
				if (value > 100 && value < 500)
				{
					base.tankcapacity = value;
				}
				else
				{
					base.tankcapacity = 1500;
				}
			}
		}


		


		public AirPlane(int maxSpeed, int maxCountPassenger, double weigth, int tankcapacity, Color color) {
			this.MaxSpeed = maxSpeed;
            this.tankcapacity = tankcapacity;
            this.MaxCountPassengers = maxCountPassenger;
           
			this.ColorBody = color;
			this.Weigth = weigth;
			this.countPassengers = 0;
			Random rand = new Random();
			startPosX = rand.Next(10, 60);
			startPosY = rand.Next(10, 60);
		}
		public override void movePlane(Graphics g) {
			startPosX += (MaxSpeed * 50) / (float)Weigth / (countPassengers == 0 ? 1 : countPassengers);
			drawPlane(g);

		}
		public override void drawPlane(Graphics g) {
			draw(g);
		}
		protected virtual void draw(Graphics g) {

			Brush brush1 = new SolidBrush(ColorBody);
			g.FillEllipse(brush1, startPosX, startPosY+10, 125, 27);
			Brush brush2 = new SolidBrush(ColorBody);
			g.FillEllipse(brush2, startPosX + 5, startPosY - 10, 15, 65);
			Brush brush = new SolidBrush(Color.Green);
			g.FillRectangle(brush, startPosX + 60, startPosY - 10, 20, 73);
		}
	}
}
