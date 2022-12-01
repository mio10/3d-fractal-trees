namespace FractalTree
{
    partial class Form
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
            this.canvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.trackBarCrown = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarLeavesB = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarLeavesG = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarLeavesR = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarWoodB = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarWoodG = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarWoodR = new System.Windows.Forms.TrackBar();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.trackBarDensity = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AccumBits = ((byte)(0));
            this.canvas.AutoCheckErrors = false;
            this.canvas.AutoFinish = false;
            this.canvas.AutoMakeCurrent = true;
            this.canvas.AutoSwapBuffers = true;
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.ColorBits = ((byte)(32));
            this.canvas.DepthBits = ((byte)(16));
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 600);
            this.canvas.StencilBits = ((byte)(0));
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // trackBarCrown
            // 
            this.trackBarCrown.Location = new System.Drawing.Point(201, 31);
            this.trackBarCrown.Maximum = 90;
            this.trackBarCrown.Name = "trackBarCrown";
            this.trackBarCrown.Size = new System.Drawing.Size(104, 45);
            this.trackBarCrown.SmallChange = 5;
            this.trackBarCrown.TabIndex = 1;
            this.trackBarCrown.Value = 45;
            this.trackBarCrown.Scroll += new System.EventHandler(this.trackBarCrown_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.trackBarSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(628, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 433);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.trackBarLeavesB);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.trackBarLeavesG);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.trackBarLeavesR);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(10, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 149);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Листва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Синий";
            // 
            // trackBarLeavesB
            // 
            this.trackBarLeavesB.LargeChange = 1;
            this.trackBarLeavesB.Location = new System.Drawing.Point(183, 101);
            this.trackBarLeavesB.Maximum = 100;
            this.trackBarLeavesB.Name = "trackBarLeavesB";
            this.trackBarLeavesB.Size = new System.Drawing.Size(98, 45);
            this.trackBarLeavesB.TabIndex = 16;
            this.trackBarLeavesB.Value = 41;
            this.trackBarLeavesB.Scroll += new System.EventHandler(this.trackBarLeavesB_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Зелёный";
            // 
            // trackBarLeavesG
            // 
            this.trackBarLeavesG.LargeChange = 1;
            this.trackBarLeavesG.Location = new System.Drawing.Point(183, 66);
            this.trackBarLeavesG.Maximum = 100;
            this.trackBarLeavesG.Name = "trackBarLeavesG";
            this.trackBarLeavesG.Size = new System.Drawing.Size(98, 45);
            this.trackBarLeavesG.TabIndex = 14;
            this.trackBarLeavesG.Value = 65;
            this.trackBarLeavesG.Scroll += new System.EventHandler(this.trackBarLeavesG_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Красный";
            // 
            // trackBarLeavesR
            // 
            this.trackBarLeavesR.LargeChange = 1;
            this.trackBarLeavesR.Location = new System.Drawing.Point(183, 31);
            this.trackBarLeavesR.Maximum = 100;
            this.trackBarLeavesR.Name = "trackBarLeavesR";
            this.trackBarLeavesR.Size = new System.Drawing.Size(98, 45);
            this.trackBarLeavesR.TabIndex = 12;
            this.trackBarLeavesR.Scroll += new System.EventHandler(this.trackBarLeavesR_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trackBarWoodB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.trackBarWoodG);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.trackBarWoodR);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(10, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 150);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Древесина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Синий";
            // 
            // trackBarWoodB
            // 
            this.trackBarWoodB.LargeChange = 1;
            this.trackBarWoodB.Location = new System.Drawing.Point(183, 101);
            this.trackBarWoodB.Maximum = 100;
            this.trackBarWoodB.Name = "trackBarWoodB";
            this.trackBarWoodB.Size = new System.Drawing.Size(98, 45);
            this.trackBarWoodB.TabIndex = 16;
            this.trackBarWoodB.Scroll += new System.EventHandler(this.trackBarWoodB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Зелёный";
            // 
            // trackBarWoodG
            // 
            this.trackBarWoodG.LargeChange = 1;
            this.trackBarWoodG.Location = new System.Drawing.Point(183, 66);
            this.trackBarWoodG.Maximum = 100;
            this.trackBarWoodG.Name = "trackBarWoodG";
            this.trackBarWoodG.Size = new System.Drawing.Size(98, 45);
            this.trackBarWoodG.TabIndex = 14;
            this.trackBarWoodG.Value = 29;
            this.trackBarWoodG.Scroll += new System.EventHandler(this.trackBarWoodG_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Красный";
            // 
            // trackBarWoodR
            // 
            this.trackBarWoodR.LargeChange = 1;
            this.trackBarWoodR.Location = new System.Drawing.Point(183, 31);
            this.trackBarWoodR.Maximum = 100;
            this.trackBarWoodR.Name = "trackBarWoodR";
            this.trackBarWoodR.Size = new System.Drawing.Size(98, 45);
            this.trackBarWoodR.TabIndex = 12;
            this.trackBarWoodR.Value = 58;
            this.trackBarWoodR.Scroll += new System.EventHandler(this.trackBarWoodR_Scroll);
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 1;
            this.trackBarSize.Location = new System.Drawing.Point(193, 44);
            this.trackBarSize.Maximum = 100;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(104, 45);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.Value = 25;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Размер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Распределение кроны";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRandom);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.trackBarDensity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.trackBarCrown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(628, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Новое дерево";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.Location = new System.Drawing.Point(193, 121);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(112, 33);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Случайно";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNew.Location = new System.Drawing.Point(6, 121);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(129, 33);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "Построить";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // trackBarDensity
            // 
            this.trackBarDensity.LargeChange = 1;
            this.trackBarDensity.Location = new System.Drawing.Point(201, 74);
            this.trackBarDensity.Maximum = 8;
            this.trackBarDensity.Minimum = 1;
            this.trackBarDensity.Name = "trackBarDensity";
            this.trackBarDensity.Size = new System.Drawing.Size(104, 45);
            this.trackBarDensity.TabIndex = 4;
            this.trackBarDensity.Value = 8;
            this.trackBarDensity.Scroll += new System.EventHandler(this.trackBarDensity_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Плотность кроны";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(644, 661);
            this.Name = "Form";
            this.Text = "L-система деревьев";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCrown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeavesR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWoodR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl canvas;
        private System.Windows.Forms.TrackBar trackBarCrown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBarDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarLeavesB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarLeavesG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarLeavesR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarWoodB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarWoodG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarWoodR;
        private System.Windows.Forms.Button buttonRandom;
    }
}

