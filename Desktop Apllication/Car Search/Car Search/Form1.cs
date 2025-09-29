using System.Data;
using System.Data.SqlClient;

namespace Car_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=Car;Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Car_table where registration_number = @registration_number ", conn);
            cmd.Parameters.AddWithValue("registration_number",int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
