using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Gms1
{
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }

        private void genQR_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode(TextBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);


            QRCodeBox.Image = QRcode.GetGraphic(50);
        }

        private void Printing_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"E:\Projects\Gms1\QRsave"; // Use @ for verbatim strings
            saveFileDialog.DefaultExt = ".png";
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            saveFileDialog.FileName = TextBox1.Text;

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

        private void PrintPicture(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(QRCodeBox.Width, QRCodeBox.Height);
            QRCodeBox.DrawToBitmap(bmp, new Rectangle(0, 0, QRCodeBox.Width, QRCodeBox.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QRCodeBox_Click(object sender, EventArgs e)
        {

        }
    }
}
