using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gms1
{
    public partial class Fee : Form
    {
        Functions Con;
        public Fee()
        {
            InitializeComponent();
            Con = new Functions();
            showF();
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
        private void showF()
        {
            string query = "select package_id AS 'ID',package_name AS 'ຊື່ຄ່າທຳນຽມ', description AS 'ຄຳອະທິບາຍ' , price AS 'ລາຄາ' from Packages";
            Data3.DataSource = Con.GetData(query);
        }
        int Key = 0 ;
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpname.Text == "" || txtd.Text == "" || txttt.Text == "")
                {
                    MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນ");
                }
                else
                {
                    string package_name = txtpname.Text;
                    string description = txtd.Text;
                    string price = txttt.Text;
                    string Query = "delete from Packages where package_id = {0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    showF();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpname.Text == "" || txtd.Text == "" || txttt.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string package_name = txtpname.Text;
                    string description = txtd.Text;
                    string price = txttt.Text;
                    string Query = "update Packages set package_name = '{0}', description = '{1}', price = '{2}' where package_id = {3}";
                    Query = string.Format(Query, package_name, description,  price, Key);
                    Con.setData(Query);
                    showF();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpname.Text == "" || txtd.Text == "" || txttt.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string package_name = txtpname.Text;
                    string description = txtd.Text;
                    string price = txttt.Text;
                    string Query = "insert into Packages values('{0}','{1}','{2}')";
                    Query = string.Format(Query, package_name, description, price);
                    Con.setData(Query);
                    showF();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {

        }

        private void Data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fee_Load(object sender, EventArgs e)
        {

        }

        private void txtidcard_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtpname.Text = Data3.SelectedRows[0].Cells[1].Value.ToString();
                txtd.Text = Data3.SelectedRows[0].Cells[2].Value.ToString();
                txttt.Text = Data3.SelectedRows[0].Cells[3].Value.ToString();
                if (txtpname.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Data3.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
