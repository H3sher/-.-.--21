using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 2);
            }
            else if (radioButton2.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 16);
            }
            else if (radioButton3.Checked == true)
            {
                textBox2.Text = Convert.ToString(i, 8);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 2);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 16);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(i, 8);
        }

        
    }
}
