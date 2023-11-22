namespace lab1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.геометрическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинематическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.траекторияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкаАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкаВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.Lr1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lr2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LOmega = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунокToolStripMenuItem,
            this.движениеToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.траекторияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарисоватьToolStripMenuItem,
            this.стеретьToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // нарисоватьToolStripMenuItem
            // 
            this.нарисоватьToolStripMenuItem.Name = "нарисоватьToolStripMenuItem";
            this.нарисоватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.нарисоватьToolStripMenuItem.Text = "Нарисовать";
            this.нарисоватьToolStripMenuItem.Click += new System.EventHandler(this.нарисоватьToolStripMenuItem_Click);
            // 
            // стеретьToolStripMenuItem
            // 
            this.стеретьToolStripMenuItem.Name = "стеретьToolStripMenuItem";
            this.стеретьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.стеретьToolStripMenuItem.Text = "Стереть";
            this.стеретьToolStripMenuItem.Click += new System.EventHandler(this.стеретьToolStripMenuItem_Click_1);
            // 
            // движениеToolStripMenuItem
            // 
            this.движениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.стопToolStripMenuItem});
            this.движениеToolStripMenuItem.Name = "движениеToolStripMenuItem";
            this.движениеToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.движениеToolStripMenuItem.Text = "Движение";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.начатьToolStripMenuItem.Text = "Начать";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // стопToolStripMenuItem
            // 
            this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            this.стопToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.стопToolStripMenuItem.Text = "Стоп";
            this.стопToolStripMenuItem.Click += new System.EventHandler(this.стопToolStripMenuItem_Click_1);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.геометрическиеToolStripMenuItem,
            this.кинематическиеToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // геометрическиеToolStripMenuItem
            // 
            this.геометрическиеToolStripMenuItem.Name = "геометрическиеToolStripMenuItem";
            this.геометрическиеToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.геометрическиеToolStripMenuItem.Text = "Геометрические";
            this.геометрическиеToolStripMenuItem.Click += new System.EventHandler(this.геометрическиеToolStripMenuItem_Click);
            // 
            // кинематическиеToolStripMenuItem
            // 
            this.кинематическиеToolStripMenuItem.Name = "кинематическиеToolStripMenuItem";
            this.кинематическиеToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.кинематическиеToolStripMenuItem.Text = "Кинематические";
            this.кинематическиеToolStripMenuItem.Click += new System.EventHandler(this.кинематическиеToolStripMenuItem_Click);
            // 
            // траекторияToolStripMenuItem
            // 
            this.траекторияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точкаАToolStripMenuItem,
            this.точкаВToolStripMenuItem});
            this.траекторияToolStripMenuItem.Name = "траекторияToolStripMenuItem";
            this.траекторияToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.траекторияToolStripMenuItem.Text = "Траектория";
            // 
            // точкаАToolStripMenuItem
            // 
            this.точкаАToolStripMenuItem.CheckOnClick = true;
            this.точкаАToolStripMenuItem.Name = "точкаАToolStripMenuItem";
            this.точкаАToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точкаАToolStripMenuItem.Text = "Точка А";
            // 
            // точкаВToolStripMenuItem
            // 
            this.точкаВToolStripMenuItem.CheckOnClick = true;
            this.точкаВToolStripMenuItem.Name = "точкаВToolStripMenuItem";
            this.точкаВToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точкаВToolStripMenuItem.Text = "Точка В";
            this.точкаВToolStripMenuItem.CheckedChanged += new System.EventHandler(this.точкаВToolStripMenuItem_Click);
            this.точкаВToolStripMenuItem.Click += new System.EventHandler(this.точкаВToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 381);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(27, 27);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(37, 36);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "R";
            // 
            // Lr1
            // 
            this.Lr1.AutoSize = true;
            this.Lr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lr1.Location = new System.Drawing.Point(70, 27);
            this.Lr1.Name = "Lr1";
            this.Lr1.Size = new System.Drawing.Size(0, 36);
            this.Lr1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "r";
            // 
            // Lr2
            // 
            this.Lr2.AutoSize = true;
            this.Lr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lr2.Location = new System.Drawing.Point(276, 27);
            this.Lr2.Name = "Lr2";
            this.Lr2.Size = new System.Drawing.Size(0, 36);
            this.Lr2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Omega";
            // 
            // LOmega
            // 
            this.LOmega.AutoSize = true;
            this.LOmega.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOmega.Location = new System.Drawing.Point(523, 27);
            this.LOmega.Name = "LOmega";
            this.LOmega.Size = new System.Drawing.Size(0, 36);
            this.LOmega.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.Lr2);
            this.panel1.Controls.Add(this.LOmega);
            this.panel1.Controls.Add(this.Lr1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 184);
            this.panel1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "B";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(86, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 34);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(308, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 34);
            this.panel3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стопToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem геометрическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинематическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label Lr1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lr2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LOmega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem траекторияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкаАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкаВToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

