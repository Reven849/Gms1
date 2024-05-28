using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gms1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1G72T6C\NOYSQLEXPRESS;Initial Catalog=FMS;Integrated Security=True");
            con.Open();
            string username = User.Text;
            string password = Pass.Text;
            SqlCommand cnn = new SqlCommand("select username,password from  Employees where UserName = '" + User.Text + "'and Password = '" + Pass.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Employees mn = new Employees();
                mn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username and password");
            }
            con.Close();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
