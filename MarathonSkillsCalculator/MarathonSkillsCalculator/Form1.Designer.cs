namespace MarathonSkillsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.man = new System.Windows.Forms.PictureBox();
            this.woman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI калькулятор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация о том, что такое BMI и как калькулятор работает  ";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(133, 412);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 26);
            this.height.TabIndex = 4;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(133, 481);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 26);
            this.weight.TabIndex = 5;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(50, 557);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(112, 33);
            this.count.TabIndex = 6;
            this.count.Text = "Рассчитать";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(196, 557);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 33);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Рост";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "кг";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(505, 537);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(572, 69);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Value = 30;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(515, 586);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(468, 623);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Недостаточный";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(613, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Chocolate;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(689, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 20;
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.OrangeRed;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(738, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 20);
            this.label10.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(606, 623);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Здоровый";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(697, 623);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Избыточный";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(873, 623);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ожирение";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(62, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 22);
            this.label15.TabIndex = 25;
            this.label15.Text = "Мужской";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(211, 349);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 22);
            this.label16.TabIndex = 26;
            this.label16.Text = "Женский";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(-4, -1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1096, 80);
            this.label17.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(79, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 43);
            this.label18.TabIndex = 28;
            this.label18.Text = "MARATHON SKILLS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MarathonSkillsCalculator.Properties.Resources.bmi_healthy_icon1;
            this.pictureBox3.Location = new System.Drawing.Point(701, 153);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 342);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarathonSkillsCalculator.Properties.Resources.bmi_obese_icon;
            this.pictureBox1.Location = new System.Drawing.Point(701, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MarathonSkillsCalculator.Properties.Resources.bmi_overweight_icon;
            this.pictureBox2.Location = new System.Drawing.Point(701, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 342);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MarathonSkillsCalculator.Properties.Resources.bmi_underweight_icon;
            this.pictureBox4.Location = new System.Drawing.Point(701, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(254, 342);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // man
            // 
            this.man.Image = global::MarathonSkillsCalculator.Properties.Resources.bmi_healthy_icon;
            this.man.Location = new System.Drawing.Point(50, 200);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(100, 146);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.man.TabIndex = 34;
            this.man.TabStop = false;
            this.man.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // woman
            // 
            this.woman.Image = global::MarathonSkillsCalculator.Properties.Resources.female_icon;
            this.woman.Location = new System.Drawing.Point(193, 200);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(100, 146);
            this.woman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.woman.TabIndex = 35;
            this.woman.TabStop = false;
            this.woman.Click += new System.EventHandler(this.woman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 681);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.count);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills - BMI calculator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.PictureBox woman;
    }
}

