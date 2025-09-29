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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mid_term_Exam
{
    public partial class Books_per_user : Form
    {
        public Books_per_user()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Books_per_user_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"Library management\";Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("select Member_Id,Member_Name from Member_details", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Member_Id";

            listBox1.ValueMember = "Member_Name";

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
