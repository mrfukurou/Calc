﻿namespace WindowsFormsApp51
{
    partial class average_calculation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attention = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stoim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rasst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.izrs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 420);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 420);
            this.panel2.TabIndex = 3;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(268, 340);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(167, 36);
            this.clear.TabIndex = 2;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.attention);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.calculation);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stoim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rasst);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.izrs);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Средний расход топлива";
            // 
            // attention
            // 
            this.attention.AutoSize = true;
            this.attention.Location = new System.Drawing.Point(7, 170);
            this.attention.Name = "attention";
            this.attention.Size = new System.Drawing.Size(0, 17);
            this.attention.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "л/100 км";
            // 
            // calculation
            // 
            this.calculation.Location = new System.Drawing.Point(244, 160);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(167, 36);
            this.calculation.TabIndex = 1;
            this.calculation.Text = "Расcчитать";
            this.calculation.UseVisualStyleBackColor = true;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "км";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "литров";
            // 
            // stoim
            // 
            this.stoim.Location = new System.Drawing.Point(149, 255);
            this.stoim.Name = "stoim";
            this.stoim.ReadOnly = true;
            this.stoim.Size = new System.Drawing.Size(201, 22);
            this.stoim.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стоимость топлива";
            // 
            // sr
            // 
            this.sr.Location = new System.Drawing.Point(149, 217);
            this.sr.Name = "sr";
            this.sr.ReadOnly = true;
            this.sr.Size = new System.Drawing.Size(201, 22);
            this.sr.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Средний расход";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(149, 122);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(201, 22);
            this.price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стоимость топлива";
            // 
            // rasst
            // 
            this.rasst.Location = new System.Drawing.Point(181, 78);
            this.rasst.Name = "rasst";
            this.rasst.Size = new System.Drawing.Size(169, 22);
            this.rasst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пройденное расстояние";
            // 
            // izrs
            // 
            this.izrs.Location = new System.Drawing.Point(149, 32);
            this.izrs.Multiline = true;
            this.izrs.Name = "izrs";
            this.izrs.Size = new System.Drawing.Size(201, 22);
            this.izrs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Израсходовано";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Средний расход";
            // 
            // average_calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.panel1);
            this.Name = "average_calculation";
            this.Text = "average calculation";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stoim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rasst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox izrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label attention;
    }
}