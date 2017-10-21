namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDownSalt = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownEgg = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.add_pan = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.add_salt = new System.Windows.Forms.Button();
			this.add_egg = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgg)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDownSalt);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numericUpDownEgg);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(153, 135);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ингредиенты";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// numericUpDownSalt
			// 
			this.numericUpDownSalt.Location = new System.Drawing.Point(9, 96);
			this.numericUpDownSalt.Name = "numericUpDownSalt";
			this.numericUpDownSalt.Size = new System.Drawing.Size(129, 20);
			this.numericUpDownSalt.TabIndex = 3;
			this.numericUpDownSalt.ValueChanged += new System.EventHandler(this.numericUpDownSalt_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Мороженое";
			// 
			// numericUpDownEgg
			// 
			this.numericUpDownEgg.Location = new System.Drawing.Point(9, 43);
			this.numericUpDownEgg.Name = "numericUpDownEgg";
			this.numericUpDownEgg.Size = new System.Drawing.Size(129, 20);
			this.numericUpDownEgg.TabIndex = 1;
			this.numericUpDownEgg.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Молоко";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Location = new System.Drawing.Point(12, 164);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(153, 135);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тарелка";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(18, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 66);
			this.button1.TabIndex = 0;
			this.button1.Text = "Смешать молоко и мороженное";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.add_pan);
			this.groupBox3.Location = new System.Drawing.Point(322, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(118, 287);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Стакан";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// add_pan
			// 
			this.add_pan.Location = new System.Drawing.Point(6, 91);
			this.add_pan.Name = "add_pan";
			this.add_pan.Size = new System.Drawing.Size(105, 76);
			this.add_pan.TabIndex = 1;
			this.add_pan.Text = "Перелить смесь в стакан";
			this.add_pan.UseVisualStyleBackColor = true;
			this.add_pan.Click += new System.EventHandler(this.add_pan_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.add_salt);
			this.groupBox4.Controls.Add(this.add_egg);
			this.groupBox4.Controls.Add(this.button5);
			this.groupBox4.Location = new System.Drawing.Point(171, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(145, 287);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Миксер";
			// 
			// add_salt
			// 
			this.add_salt.Location = new System.Drawing.Point(6, 193);
			this.add_salt.Name = "add_salt";
			this.add_salt.Size = new System.Drawing.Size(127, 79);
			this.add_salt.TabIndex = 6;
			this.add_salt.Text = "Взбить смесь миксером";
			this.add_salt.UseVisualStyleBackColor = true;
			this.add_salt.Click += new System.EventHandler(this.button7_Click);
			// 
			// add_egg
			// 
			this.add_egg.Location = new System.Drawing.Point(6, 29);
			this.add_egg.Name = "add_egg";
			this.add_egg.Size = new System.Drawing.Size(127, 76);
			this.add_egg.TabIndex = 5;
			this.add_egg.Text = "Включить миксер";
			this.add_egg.UseVisualStyleBackColor = true;
			this.add_egg.Click += new System.EventHandler(this.add_egg_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 111);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(127, 76);
			this.button5.TabIndex = 4;
			this.button5.Text = "Добавить в миксер ингредиенты";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 303);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Бар";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgg)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSalt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownEgg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button add_pan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button add_salt;
        private System.Windows.Forms.Button add_egg;
        private System.Windows.Forms.Button button5;
    }
}

