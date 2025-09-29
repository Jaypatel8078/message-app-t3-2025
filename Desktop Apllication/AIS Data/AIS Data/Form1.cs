using System.Data;
using System.Data.SqlClient;

namespace AIS_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"AIS Data\";Integrated Security=True;Encrypt=False");

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            string querry = "SELECT * FROM Login_form WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                username = textBox1.Text;
                password = textBox2.Text;

                //page that needed to be load next 
                Form2 di = new Form2();
                di.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            

        }
    }
