using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Gms1
{
    public partial class Mem : Form
    {
        Functions Con;
        public Mem()
        {
            InitializeComponent();
            Con = new Functions();
            showMM();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
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

        int Key = 0;
        private void showMM()
        {
            string query = "select member_id AS 'ID',first_name AS 'ຊື່', last_name AS 'ນາມສະກຸນ',phone_number AS 'ເບີໂທ', gender AS 'ເພດ'," +
                "birthdate AS 'ວັນ/ເດືອນ/ປີເກິດ', ID_card AS 'ເລກບັດປະຈຳຕົວ',package_name AS 'ຄ່າທຳນຽມ' ,Date_of_issue As 'ວັນທີສະມັກ' ,Date_of_expiry As 'ວັນໝົດອາຍຸ' from Members " +
                "INNER JOIN Packages ON Members.package_id=Packages.package_id;";
            Data4.DataSource = Con.GetData(query);

            if (LB.Text != "")
            {
                DT2.Value = DateTime.Now;
            }
            if (LB.Text == "2")
            {
                DT1.Value = DateTime.Now;
                DT2.Value = DT1.Value.AddDays(7);
            }
            if (LB.Text == "4")
            {
                DT1.Value = DateTime.Now;
                DT2.Value = DT1.Value.AddDays(30);
            }
            if (LB.Text == "5")
            {
                DT1.Value = DateTime.Now;
                DT2.Value = DT1.Value.AddDays(90);
            }
            if (LB.Text == "6")
            {
                DT1.Value = DateTime.Now;
                DT2.Value = DT1.Value.AddDays(180);
            }
            if (LB.Text == "7")
            {
                DT1.Value = DateTime.Now;
                DT2.Value = DT1.Value.AddDays(365);
            }
        }
        private void Mem_Load(object sender, EventArgs e)
        {
            string query = "select package_id , package_name from Packages";

            CBP.DataSource = Con.GetData(query);
            CBP.DisplayMember = "package_name";
            CBP.ValueMember = "package_id";

        }
        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfname.Text == "" || txtlname.Text == "" || txtphone.Text == "" || txtidcard.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string first_name = txtfname.Text;
                    string last_name = txtlname.Text;
                    string phone_number = txtphone.Text;
                    string gender = cbgen.SelectedItem.ToString();
                    string ID_card = txtidcard.Text;
                    string package_id = LB.Text;
                    string Query = "insert into Members values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                    Query = string.Format(Query, first_name, last_name, phone_number, gender, bdate.Value.Date, ID_card, package_id, DT1.Value.Date, DT2.Value.Date);
                    Con.setData(Query);
                    showMM();
                    MessageBox.Show("ເພີ່ມຂໍ້ມູນສຳເລັດ");
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
                if (txtfname.Text == "" || txtlname.Text == "" || txtphone.Text == "" || txtidcard.Text == "")
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ");
                }
                else
                {
                    string first_name = txtfname.Text;
                    string last_name = txtlname.Text;
                    string phone_number = txtphone.Text;
                    string gender = cbgen.Text;
                    string ID_card = txtidcard.Text;
                    string package_id = LB.Text;
                    string Query = "update Members set first_name = '{0}',last_name = '{1}',phone_number = '{2}',gender = '{3}',birthdate = '{4}',ID_card = '{5}',package_id = '{6}' ,Date_of_issue = '{7}' ,Date_of_expiry = '{8}' where member_id = {9}";
                    Query = string.Format(Query, first_name, last_name, phone_number, gender, bdate.Value.Date, ID_card, package_id, DT1.Value.Date, DT2.Value.Date,  Key);
                    Con.setData(Query);
                    showMM();
                    MessageBox.Show("ແກ້ໄຂຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
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

                    string Query = "delete from Members where member_id = {0}";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    showMM();
                    MessageBox.Show("ລົບຂໍ້ມູນສຳເລັດ");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void CBP_SelectedValueChanged(object sender, EventArgs e)
        {
            LB.Text = CBP.SelectedValue.ToString();

        }

        private void Data4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                txtID.Text = Data4.SelectedRows[0].Cells[0].Value.ToString();
                txtfname.Text = Data4.SelectedRows[0].Cells[1].Value.ToString();
                txtlname.Text = Data4.SelectedRows[0].Cells[2].Value.ToString();
                txtphone.Text = Data4.SelectedRows[0].Cells[3].Value.ToString();
                cbgen.SelectedItem = Data4.SelectedRows[0].Cells[4].Value.ToString();
                bdate.Text = Data4.SelectedRows[0].Cells[5].Value.ToString();
                txtidcard.Text = Data4.SelectedRows[0].Cells[6].Value.ToString();
                CBP.SelectedItem = Data4.SelectedRows[0].Cells[7].Value.ToString();
                if (txtfname.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Data4.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void QRgen_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode(txtID.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);


            QRCodeBox.Image = QRcode.GetGraphic(150);
        }

        private void Printing_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"E:\Projects\Gms1\QRsave"; // Use @ for verbatim strings
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            saveFileDialog.FileName = ID.Text;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    QRCodeBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("Image saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextS_TextChanged(object sender, EventArgs e)
        {
            string query = "select member_id AS 'ID',first_name AS 'ຊື່', last_name AS 'ນາມສະກຸນ',phone_number AS 'ເບີໂທ', gender AS 'ເພດ'" +
                ",birthdate AS 'ວັນ/ເດືອນ/ປີເກິດ', ID_card AS 'ເລກບັດປະຈຳຕົວ',package_name AS 'ຄ່າທຳນຽມ' from Members  " +
                "INNER JOIN Packages ON Members.package_id=Packages.package_id where first_name like '%" + TextS.Text + "%'";
            Data4.DataSource = Con.GetData(query);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMM();
        }

        private void LB_Click(object sender, EventArgs e)
        {
            showMM();
        }

        private void DT1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            ScanQrCode Obj7 = new ScanQrCode();
            Obj7.Show();
            this.Hide();
        }

        private void Data4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
