using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class FormKitchen : Form
    {
        private Sugar salt;

        private HolodTap waterTap;

        private WorkStation knife;

        private Blend pan;

        private Blender stove;
        private Holod water;
        private Ice[] potato;
        private Icecream[] onion;
        private Milk lapsha;
        private Vanil chicken;
        private Chokolate[] carrot;
        

        public FormKitchen()
        {
            InitializeComponent();
            waterTap = new HolodTap();
            knife = new WorkStation();
            pan = new Blend();
            stove = new Blender();
            waterTap = new HolodTap();


           

            
        }
        private void FormKitchen_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ker_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Молока нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Молока нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < carrot.Length; ++i)
            {
                knife.Clean_carrots(carrot[i]);
            }
            button12.Enabled = true;
            MessageBox.Show("Молоко можно переливать в блендер", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            knife.Cutting_c(chicken);
            MessageBox.Show("На вкус и цвет, главное - не переборщить ;)", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button10.Enabled = true;
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("Льда нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("Льда нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < onion.Length; ++i)
            {
                knife.Clean_onion(onion[i]);
            }
            button11.Enabled = true;
            MessageBox.Show("Лёд можно добавлять в блендер", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (potato == null)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < potato.Length; i++)
            {
                knife.Clean_potato(potato[i]);
            }
            button9.Enabled = true;
            MessageBox.Show("Ваниль можно добавлять в блендер", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                waterTap.State = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                waterTap.State = true;
            }

        }

        private void numericUpDownPOP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
               
                if (potato[i].Have_scin)
                {
                    MessageBox.Show("Нужно почистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
                pan.AddPotato(potato);
            
        
            MessageBox.Show("Ваниль положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (carrot == null)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrot.Length == 0)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < carrot.Length; ++i)
            {

                if (carrot[i].Have_scin)
                {
                    MessageBox.Show("Нужно достать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
                pan.AddCarrot(carrot);
      
            MessageBox.Show("Шоколад положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (onion == null)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (onion.Length == 0)
            {
                MessageBox.Show("Чего-то не хватает..", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < onion.Length; ++i)
            {

                if (onion[i].Have_scin)
                {
                    MessageBox.Show("Нужно достать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
                pan.AddOnion(onion);
            
           
            MessageBox.Show("Лёд положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (lapsha == null)
            {
                MessageBox.Show("мороженого нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            MessageBox.Show("Мороженое в блендере", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pan.AddLapsha(lapsha);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (chicken == null)
            {
                MessageBox.Show("Корицы нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chicken.cutting)
            {
                MessageBox.Show("Корицу нужно достать", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Корица в блендере", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pan.AddChicken(chicken);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!waterTap.State)
            {
                MessageBox.Show("Эммм.... закрыто :( ", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
           
                pan.AddWater(waterTap.GetWater());
            
            button13.Enabled = true;
            radioButton2.Checked = true;
            MessageBox.Show("Молоко залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            salt = new Sugar();
            salt.Count = Convert.ToInt32(numericUpDown3.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Сахар добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сахара нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            button7.Enabled = true;
            MessageBox.Show("Взбиваем...", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!stove.pan1())
            {
                MessageBox.Show("У нас не все готово к приготовлению!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Взбивать будем с божьей помощью или всё таки включим блендер?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (!stove.Pan.Isready())
            {
                radioButton3.Checked = false;
                MessageBox.Show("Поздравляем, коктейль готов!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = radioButton3.Checked;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            potato = new Ice[3];
            for (int i = 0; i < potato.Length; i++) {
                potato[i] = new Ice();
                
            }
            carrot = new Chokolate[2];
            for (int i = 0; i < carrot.Length; i++) {
                carrot[i] = new Chokolate();
            }
            onion = new Icecream[2];
            for (int i = 0; i < onion.Length; i++)
            {
                onion[i] = new Icecream();
            }
            chicken = new Vanil();
           lapsha = new Milk();
            

        }

		private void FormKitchen_Load_1(object sender, EventArgs e)
		{

		}

        private void button4_Click(object sender, EventArgs e)
        {
            if (!waterTap.State)
            {
                MessageBox.Show("Холодос закрыт, может откроем?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            else {
				for (int i = 0; i < potato.Length; ++i)
				{
					potato[i] = new Ice();
				}
				for (int i = 0; i < potato.Length; ++i)
				{
					potato[i].Dirty = 0;
				}

			}


			MessageBox.Show("Молоко достали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			if (!waterTap.State)
			{
				MessageBox.Show("Холодос закрыт, может откроем?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			else
			{
				for (int i = 0; i < carrot.Length; ++i)
				{
					carrot[i] = new Chokolate();
				}
				for (int i = 0; i < carrot.Length; ++i)
				{
					carrot[i].Dirty = 0;
				}
			}
			MessageBox.Show("Мороженое достали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button17_Click(object sender, EventArgs e)
		{
			if (!waterTap.State)
			{
				MessageBox.Show("Холодос закрыт, может откроем?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			else
			{
				for (int i = 0; i < onion.Length; ++i)
				{
					onion[i] = new Icecream();
				}
				for (int i = 0; i < onion.Length; ++i)
				{
					onion[i].Dirty = 0;
				}
			}
			MessageBox.Show("Шоколадку достали", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
