using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
	public partial class Form1 : Form
	{
        Color color;
        Color dopColor;
        int maxSpeed;
        int weigth;
        int maxCountPass;
        int tankcapacity;
        private ITransport Transport;
        public Form1()
		{
            color = Color.Green;
            dopColor = Color.Brown;
            maxSpeed = 500;
            weigth = 55000;
            tankcapacity = 15000;
            maxCountPass = 200;
            InitializeComponent();
            textBox1.Text = "" + maxSpeed;
            textBox2.Text = "" + weigth;
            textBox3.Text = "" + maxCountPass;
            textBox4.Text = "" + tankcapacity;
         
		}
        private bool checkFields()
        {
            if (!int.TryParse(textBox2.Text, out weigth))
            {
                return false;
            }
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out maxCountPass))
            {
                return false;
            }
            if (!int.TryParse(textBox4.Text, out tankcapacity))
            {
                return false;
            }
            return true;
        }
		private void button4_Click_1(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				dopColor = cd.Color;
				button4.BackColor = dopColor;
			}
		}
		private void button3_Click_1(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				color = cd.Color;
				button3.BackColor = color;
			}
		}
		private void button1_Click(object sender, EventArgs e)//самолёт
		{

            if (checkFields())
            {



               Transport = new AirPlane(maxSpeed, maxCountPass, weigth, tankcapacity, color);
            Console.WriteLine(pictureBox1.Width+" "+ pictureBox1.Height);
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Transport.drawAirPlane(gr);
                pictureBox1.Image = bmp;



         }
        }
        

        private void button2_Click(object sender, EventArgs e)// катер
        {
            if (checkFields())
            {
                Transport = new AirBus(maxSpeed, maxCountPass, weigth ,tankcapacity, color, checkBox2.Checked,dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Transport.drawAirPlane(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void button5_Click(object sender, EventArgs e)//движение
        {
            if (Transport != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Transport.moveAirPlane(gr);
                pictureBox1.Image = bmp;

            }
        }
		
        private void Form1_Load(object sender, EventArgs e)
        {


        }

	

	}
}
