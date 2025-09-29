using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("select StudentId,Givenname,Familyname from Student_table",conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Givenname";
            
            listBox1.ValueMember = "StudentId";
           

                
        }
    }
}
