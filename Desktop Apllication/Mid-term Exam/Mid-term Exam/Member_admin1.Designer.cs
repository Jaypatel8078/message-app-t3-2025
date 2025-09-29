namespace Mid_term_Exam
{
    partial class Member_admin1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            memberAdminBindingSource = new BindingSource(components);
            memberAdminBindingSource1 = new BindingSource(components);
            memberAdminBindingSource2 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            memberAdminBindingSource3 = new BindingSource(components);
            memberAdminBindingSource4 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 63);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Member ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 142);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 1;
            label2.Text = "Member Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 31);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(72, 213);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 4;
            button1.Text = "Add member";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 213);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(398, 213);
            button3.Name = "button3";
            button3.Size = new Size(112, 43);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(551, 213);
            button4.Name = "button4";
            button4.Size = new Size(112, 43);
            button4.TabIndex = 7;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(572, 75);
            button5.Name = "button5";
            button5.Size = new Size(112, 78);
            button5.TabIndex = 8;
            button5.Text = "Books per Member";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // memberAdminBindingSource
            // 
            memberAdminBindingSource.DataSource = typeof(Member_Admin);
            // 
            // memberAdminBindingSource1
            // 
            memberAdminBindingSource1.DataSource = typeof(Member_Admin);
            // 
            // memberAdminBindingSource2
            // 
            memberAdminBindingSource2.DataSource = typeof(Member_Admin);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(722, 167);
            dataGridView1.TabIndex = 9;
            // 
            // memberAdminBindingSource3
            // 
            memberAdminBindingSource3.DataSource = typeof(Member_Admin);
            // 
            // memberAdminBindingSource4
            // 
            memberAdminBindingSource4.DataSource = typeof(Member_Admin);
            // 
            // Member_admin1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Member_admin1";
            Text = "Member_admin1";
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAdminBindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private BindingSource memberAdminBindingSource;
        private BindingSource memberAdminBindingSource1;
        private BindingSource memberAdminBindingSource2;
        private DataGridView dataGridView1;
        private BindingSource memberAdminBindingSource3;
        private BindingSource memberAdminBindingSource4;
    }
}