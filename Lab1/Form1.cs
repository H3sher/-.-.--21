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
       
        private egg[] eggs;
        private salt salt;
        private Knife knife;
        private pan pan;
        private stove stove;
        private oil oil;


        public Form1()
        {
           
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            add_salt.Enabled = false;
            add_pan.Enabled = false;
            add_egg.Enabled = false;
            knife = new Knife();
            pan = new pan();
            stove = new stove();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eggs = new egg[Convert.ToInt32(numericUpDownEgg.Value)];
            pan.init(Convert.ToInt32(numericUpDownEgg.Value));
            salt = new salt();
            salt.Count = Convert.ToInt32(numericUpDownSalt.Value);
            for (int i = 0; i < eggs.Length; ++i)
            {
                eggs[i] = new egg();
            }

			if (numericUpDownEgg.Value > 0)
			{

				for (int i = 0; i < eggs.Length; i++)
				{
					knife.Clean(eggs[i]);
				}
				add_egg.Enabled = true;

				MessageBox.Show("Ингредиенты смешаны", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("А про молоко то забыли...", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void add_egg_Click(object sender, EventArgs e)
        {
            if (eggs == null)
            {
                MessageBox.Show("Молока нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs.Length == 0)
            {
                MessageBox.Show("Хм, кажется, мы что-то забыли", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			
			for (int i = 0; i < eggs.Length; ++i)
            {
               
                if (eggs[i].Have_skin)
                {
                    MessageBox.Show("Сначала нужно перемешать их!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                pan.add_egg(eggs[i]);
            }
            add_pan.Enabled = true;
            //buttonAddPan.Enabled = true;
            MessageBox.Show(" Приступаем к приготовлению!", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                pan.add_oil(oil);
            }
			add_salt.Enabled = true;
			if (salt.Count > 0)
			{
				pan.add_salt(salt);
				MessageBox.Show("Ингредиенты в миксере! Можно смешивать", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Кажется, мы забыли про мороженое...", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			
        }

        private void button7_Click(object sender, EventArgs e)
        {
            salt = new salt();
            salt.Count = Convert.ToInt32(numericUpDownSalt.Value);
            if (salt.Count > 0)
            {
                pan.add_salt(salt);
                MessageBox.Show("Смесь взбита! Коктейль почти готов", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Мороженого же нет!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void add_pan_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            
            MessageBox.Show("Поздравляем! Молочный коктейль готов", "Бар", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

		private void numericUpDownSalt_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
