using System.Data;
using System.Data.SqlClient;
namespace Listbox_connect_with_other_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=20231869-Jay\\SQLEXPRESS;Initial Catalog=\"Student details\";Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand("Select StudentId,Givenname from Student_table", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Givenname";
            listBox1.ValueMember = "StudentId";
            listBox2 = new ListBox();
            listBox2.DataSource = dt;

            listBox2.DataSource = dt.Columns;             

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
