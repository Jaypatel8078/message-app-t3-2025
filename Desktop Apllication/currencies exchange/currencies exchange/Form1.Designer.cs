﻿namespace currencies_exchange
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(74, 29);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter amount in Nz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(575, 9);
            button1.Name = "button1";
            button1.Size = new Size(140, 59);
            button1.TabIndex = 2;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(94, 100);
            label2.Name = "label2";
            label2.Size = new Size(80, 43);
            label2.TabIndex = 3;
            label2.Text = "USD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(327, 105);
            label3.Name = "label3";
            label3.Size = new Size(62, 38);
            label3.TabIndex = 4;
            label3.Text = "INR";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(35, 171);
            label4.Name = "label4";
            label4.Size = new Size(216, 38);
            label4.TabIndex = 5;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(271, 171);
            label5.Name = "label5";
            label5.Size = new Size(208, 38);
            label5.TabIndex = 10;
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(575, 147);
            button3.Name = "button3";
            button3.Size = new Size(140, 62);
            button3.TabIndex = 8;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Currencies converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}
