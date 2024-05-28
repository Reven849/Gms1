using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Drawing;
using System.IO;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data;
using static System.Windows.Forms.AxHost;
using System.Windows.Input;

namespace Gms1
{
    public partial class ScanQrCode : Form
    {
        Functions Con;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public ScanQrCode()
        {
            InitializeComponent();
            Con = new Functions();
           
        }
        private void showQR()
        {
            string query = "select member_id AS 'ID',first_name AS 'ຊື່', last_name AS 'ນາມສະກຸນ',phone_number AS 'ເບີໂທ', " +
                  "gender AS 'ເພດ',birthdate AS 'ວັນ/ເດືອນ/ປີເກິດ', ID_card AS 'ເລກບັດປະຈຳຕົວ',package_name AS 'ຄ່າທຳນຽມ'," +
                  "Date_of_issue As 'ວັນທີສະໝັກ' ,Date_of_expiry As 'ວັນໝົດອາຍຸ' from Members " +
                  "INNER JOIN Packages ON Members.package_id=Packages.package_id where member_id Like'%" + ID_text.Text + "%'";
            Data5.DataSource = Con.GetData(query);

            
           if (DateTime.Now > DT2.Value)
            {
                MessageBox.Show("ບັດຂອງທ່ານຫມົດອາຍຸແລ້ວ");
            }

        }

    
        private void ScanQrCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);

            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            //Date and Time
            //label2.Text = DateTime.Now.ToLongDateString();
            //time_text.Text = DateTime.Now.ToLongTimeString();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PCB.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("OK");
              //  MemoryStream ms = new MemoryStream();
              //  pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  byte[] Photo = new byte[ms.Length];
             //   ms.Position = 0;
              //  ms.Read(Photo, 0, Photo.Length);

             //   con.Open();
             //   MySqlCommand coman = new MySqlCommand();
             //   coman.Connection = con;
             //   coman.CommandText = "insert into attendance_tbl (ID,Name,FatherName,EmailAddress,DateOfBirth,Class,PhoneNumber,Gender,InTime,Photo) values('" + ID_text.Text + " ', ' " + Name_text.Text + " ',' " + Fname_text.Text + " ',' " + Email_text.Text + " ','" + Dateofbirth_text.Text + "','" + Class_text.Text + "','" + Phone_text.Text + "','" + gender_text.Text + "','" + time_text.Text + "',@photo)";
             //   coman.Parameters.AddWithValue("@photo", Photo);
             //   coman.ExecuteNonQuery();
             //   con.Close();
             //   MessageBox.Show("Data Save Successfull !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)PCB.Image);
            try
            {
                string decoded = result.ToString().Trim();
                ID_text.Text = decoded;
                if (decoded != null)
                {
                   
                    
                    //DT1.Text =;
                    //DT2.Text =;
                    showQR();
                   
                }

                    //timer2.Start();
                    //MessageBox.Show("Data Save Successfull !");
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex);
            }
        }

        private void btopen_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            // timer1.Start();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void PCB_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Data5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Data5_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            }
        }
    }

