using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mid_term_Exam
{
    public partial class Member_Admin : Form
    {
        public Member_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"Library management\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Member_details values (@Member_Id,@Member_Name)", conn);
            cmd.Parameters.AddWithValue("Member_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("Member_Name", textBox2.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"Library management\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Member_details set Member_Name = @Member_Name where Member_Id = @Member_Id", conn);
            cmd.Parameters.AddWithValue("Member_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("Member_Name", textBox2.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully updated");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 20231869 - Jay\\SQLEXPRESS; Initial Catalog =\"Library management\";Integrated Security=True;Encrypt=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Member_details where Member_Id = @Member_Id", con);
            cmd.Parameters.AddWithValue("Member_id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Deleted");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Books_per_user Form3 = new Books_per_user();
            Form3.Show();
            this.Hide();
        }

       

        private void Member_Admin_Load(object sender, EventArgs e)
        {
        }

      
        
    }
}





