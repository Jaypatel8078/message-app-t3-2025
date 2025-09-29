using System.Data;
using System.Data.SqlClient;



namespace studentapplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into student_tabelnew values (@ID,@Givenname,@FamilyName,@Dateofbirth,@Gender)", conn);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("GivenName", textBox2.Text);
            cmd.Parameters.AddWithValue("familyname", textBox3.Text);
            cmd.Parameters.AddWithValue("Dateofbirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("Gender", GetGender());

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Update student_tabelnew set Givenname = @Givenname, familyname = @familyname , Dateofbirth = @Dateofbirth , Gender = @Gender where studentID = @studentID", conn);
            cmd.Parameters.AddWithValue("studentID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("GivenName", textBox2.Text);
            cmd.Parameters.AddWithValue("familyname", textBox3.Text);
            cmd.Parameters.AddWithValue("Dateofbirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("Gender", GetGender());


            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully updated");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete student_tabelnew where StudentID = @StudentID", conn);
            cmd.Parameters.AddWithValue("StudentID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Deleted");

        }

        private string GetGender()
        {
            if (radioButton1.Checked) return "Male";
            if (radioButton2.Checked) return "Female";
            return "Prefer not to say";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from student_tabelnew ", conn);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from student_tabelnew ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-JAY\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from student_tabelnew ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
