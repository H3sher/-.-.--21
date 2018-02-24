using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab2
{
	interface ITransport
	{
		void moveAirPlane(Graphics g);
		void drawAirPlane(Graphics g);
		void SetPosition(int x, int y);
		void loadPassenger(int count);
		int getPassenger();
	}
}
