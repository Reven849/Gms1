using System;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Gms1
{
    public partial class Eqm : Form
    {
        Functions Con;
        public Eqm()
        {
            InitializeComponent();
            Con = new Functions();
            showEQ();
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
        private void showEQ()
        {
            string query = "select EquipmentID AS 'ID',EquipmentName AS 'ຊື່ເຄື່ອງອອກກຳລັງກາຍ', Quantity AS 'ຈຳນວນ' ,PurchaseDate AS 'ວັນທີຊື່', price AS 'ລາຄາ' from Equipment";
            Data2.DataSource = Con.GetData(query);
        }
        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        int Key = 0;
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txteqname.Text == "" || txtqtt.Text == "" || txtp.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string EquipmentName = txteqname.Text;
                    string Quantity = txtqtt.Text;
                    string price = txtp.Text;
                    string Query = "insert into Equipment values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, EquipmentName, Quantity, paydate.Value.Date, price);
                    Con.setData(Query);
                    showEQ();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void Data2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txteqname.Text = Data2.SelectedRows[0].Cells[1].Value.ToString();
                txtqtt.Text = Data2.SelectedRows[0].Cells[2].Value.ToString();
                paydate.Text = Data2.SelectedRows[0].Cells[3].Value.ToString();
                txtp.Text = Data2.SelectedRows[0].Cells[4].Value.ToString();
                if (txteqname.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Data2.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txteqname.Text == "" || txtqtt.Text == "" || txtp.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string EquipmentName = txteqname.Text;
                    string Quantity = txtqtt.Text;
                    string price = txtp.Text;
                    string Query = "update Equipment set EquipmentName = '{0}', Quantity = '{1}', PurchaseDate = '{2}', price = '{3}'  where EquipmentID = {4}";
                    Query = string.Format(Query, EquipmentName, Quantity, paydate.Value.Date, price, Key);
                    Con.setData(Query);
                    showEQ();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txteqname.Text == "" || txtqtt.Text == "" || txtp.Text == "")
                {
                    MessageBox.Show("ກະລຸນາເລືອກຂໍ້ມູນ");
                }
                else
                {
                    string EquipmentName = txteqname.Text;
                    string Quantity = txtqtt.Text;
                    string price = txtp.Text;
                    string Query = "delete from Equipment where EquipmentID = {0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    showEQ();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void paydate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
