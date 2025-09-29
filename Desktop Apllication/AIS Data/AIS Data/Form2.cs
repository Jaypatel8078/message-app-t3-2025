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

namespace AIS_Data
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {





        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }   

        private void Form2_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"AIS Data\";Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("select Student_id,Name from student_id", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Name";

            listBox1.ValueMember = "Student_id";

            SqlConnection con = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"AIS Data\";Integrated Security=True;Encrypt=False");
            SqlCommand cd = new SqlCommand("select Student_id,Course from Student_course ", con);
            SqlDataAdapter d1 = new SqlDataAdapter();
            d1.SelectCommand = cd;
            DataTable dd = new DataTable();
            d1.Fill(dd);
            listBox2.DataSource = dd;
            listBox2.DisplayMember = "Course";
            listBox2.ValueMember = "Student_id";
        }

    }

}

