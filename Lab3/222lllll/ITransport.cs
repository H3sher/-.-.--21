using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Lab3
{
	interface ITransport
	{
		void movePlane(Graphics g);
		void drawPlane(Graphics g);
		void SetPosition(int x, int y);
		void loadPassenger(int count);
		int getPassenger();
	}
}
