using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gms1
{
    public partial class Employees : Form
    {
        readonly Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            showEM();
        }

        int Key = 0;
        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }
        private void mem_Click(object sender, EventArgs e)
        {
            Mem Obj = new Mem();
            Obj.Show();
            this.Hide();
        }

        private void fe_Click(object sender, EventArgs e)
        {
            Fee Obj1 = new Fee();
            Obj1.Show();
            this.Hide();
        }

        private void eq_Click(object sender, EventArgs e)
        {
            Eqm Obj4 = new Eqm();
            Obj4.Show();
            this.Hide();
        }

        private void em_Click(object sender, EventArgs e)
        {
            Employees Obj2 = new Employees();
            Obj2.Show();
            this.Hide();
        }

        private void inc_Click(object sender, EventArgs e)
        {
            In Obj5 = new In();
            Obj5.Show();
            this.Hide();
        }

        private void ou_Click(object sender, EventArgs e)
        {
            Out Obj6 = new Out();
            Obj6.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showEM()
        {
            string query = "select employee_id AS ID,first_name AS 'ຊື່', last_name AS 'ນາມສະກຸນ'," +
                "phone_number AS 'ເບີໂທ', gender AS 'ເພດ', address AS 'ທີຢູ່',birthdate AS 'ວັນ/ເດືອນ/ປີເກິດ', username AS 'ຊື່ຜູ້ໃຊ້'," +
                " password AS 'ລະຫັດຜ່ານ', ID_card AS 'ເລກບັດປະຈຳຕົວ' from Employees";
            Data1.DataSource = Con.GetData(query);
        }
        private void cbgen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfname.Text == "" || txtlname.Text == "" || txtphone.Text == "" || txtadd.Text == "" || txtuser.Text == "" || txtpass.Text == "" || txtidcard.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string first_name = txtfname.Text;
                    string last_name = txtlname.Text;
                    string phone_number = txtphone.Text;
                    string gender = cbgen.SelectedItem.ToString();
                    string address = txtadd.Text;
                    string username = txtuser.Text;
                    string password = txtpass.Text;
                    string ID_card = txtidcard.Text;
                    string Query = "insert into Employees values('{0}','{1}','{2}','{3}'," +
                        "'{4}','{5}','{6}','{7}','{8}')";
                    Query = string.Format(Query, first_name, last_name, phone_number, gender, address,
                        bdate.Value.Date, username, password, ID_card);
                    Con.setData(Query);
                    showEM();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void gunaLabel15_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel14_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfname.Text == "" || txtlname.Text == "" || txtphone.Text == "" ||
                    txtadd.Text == "" || txtuser.Text == "" || txtpass.Text == "" || txtidcard.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string first_name = txtfname.Text;
                    string last_name = txtlname.Text;
                    string phone_number = txtphone.Text;
                    string gender = cbgen.SelectedItem.ToString();
                    string address = txtadd.Text;

                    string username = txtuser.Text;
                    string password = txtpass.Text;
                    string ID_card = txtidcard.Text;
                    string Query = "update Employees set first_name = '{0}',last_name = '{1}',phone_number = '{2}'" +
                        ",gender = '{3}',address = '{4}',birthdate = '{5}',username = '{6}',password = '{7}'" +
                        ",ID_card = '{8}' where employee_id = {9}";
                    Query = string.Format(Query, first_name, last_name, phone_number, gender, address,
                        bdate.Value.Date, username, password, ID_card, Key);
                    Con.setData(Query);
                    showEM();
                    MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Data1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtfname.Text = Data1.SelectedRows[0].Cells[1].Value.ToString();
                txtlname.Text = Data1.SelectedRows[0].Cells[2].Value.ToString();
                txtphone.Text = Data1.SelectedRows[0].Cells[3].Value.ToString();
                cbgen.SelectedItem = Data1.SelectedRows[0].Cells[4].Value.ToString();
                bdate.Text = Data1.SelectedRows[0].Cells[6].Value.ToString();
                txtadd.Text = Data1.SelectedRows[0].Cells[5].Value.ToString();
                txtuser.Text = Data1.SelectedRows[0].Cells[7].Value.ToString();
                txtpass.Text = Data1.SelectedRows[0].Cells[8].Value.ToString();
                txtidcard.Text = Data1.SelectedRows[0].Cells[9].Value.ToString();
                if (txtfname.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Data1.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນຂໍ້ມູນ");
                }
                else
                {
                    string first_name = txtfname.Text;
                    string last_name = txtlname.Text;
                    string phone_number = txtphone.Text;
                    string gender = cbgen.SelectedItem.ToString();
                    string address = txtadd.Text;

                    string username = txtuser.Text;
                    string password = txtpass.Text;
                    string ID_card = txtidcard.Text;
                    string Query = "delete from Employees where employee_id ={0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    showEM();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel16_Click(object sender, EventArgs e)
        {

        }
    }
}

