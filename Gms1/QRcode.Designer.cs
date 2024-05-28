namespace Gms1
{
    partial class QRcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRcode));
            this.QRCodeBox = new Guna.UI.WinForms.GunaPictureBox();
            this.QRgen = new Guna.UI.WinForms.GunaButton();
            this.TextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.Printing = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodeBox
            // 
            this.QRCodeBox.BaseColor = System.Drawing.Color.White;
            this.QRCodeBox.Location = new System.Drawing.Point(233, 110);
            this.QRCodeBox.Name = "QRCodeBox";
            this.QRCodeBox.Size = new System.Drawing.Size(304, 204);
            this.QRCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRCodeBox.TabIndex = 0;
            this.QRCodeBox.TabStop = false;
            this.QRCodeBox.Click += new System.EventHandler(this.QRCodeBox_Click);
            // 
            // QRgen
            // 
            this.QRgen.AnimationHoverSpeed = 0.07F;
            this.QRgen.AnimationSpeed = 0.03F;
            this.QRgen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QRgen.BorderColor = System.Drawing.Color.Black;
            this.QRgen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.QRgen.FocusedColor = System.Drawing.Color.Empty;
            this.QRgen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QRgen.ForeColor = System.Drawing.Color.White;
            this.QRgen.Image = ((System.Drawing.Image)(resources.GetObject("QRgen.Image")));
            this.QRgen.ImageSize = new System.Drawing.Size(20, 20);
            this.QRgen.Location = new System.Drawing.Point(233, 367);
            this.QRgen.Name = "QRgen";
            this.QRgen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.QRgen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.QRgen.OnHoverForeColor = System.Drawing.Color.White;
            this.QRgen.OnHoverImage = null;
            this.QRgen.OnPressedColor = System.Drawing.Color.Black;
            this.QRgen.Size = new System.Drawing.Size(149, 42);
            this.QRgen.TabIndex = 1;
            this.QRgen.Text = "Generate QR Code";
            this.QRgen.Click += new System.EventHandler(this.genQR_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BaseColor = System.Drawing.Color.White;
            this.TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox1.Location = new System.Drawing.Point(233, 320);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(304, 30);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Printing
            // 
            this.Printing.AnimationHoverSpeed = 0.07F;
            this.Printing.AnimationSpeed = 0.03F;
            this.Printing.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Printing.BorderColor = System.Drawing.Color.Black;
            this.Printing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Printing.FocusedColor = System.Drawing.Color.Empty;
            this.Printing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Printing.ForeColor = System.Drawing.Color.White;
            this.Printing.Image = ((System.Drawing.Image)(resources.GetObject("Printing.Image")));
            this.Printing.ImageSize = new System.Drawing.Size(20, 20);
            this.Printing.Location = new System.Drawing.Point(388, 367);
            this.Printing.Name = "Printing";
            this.Printing.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Printing.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Printing.OnHoverForeColor = System.Drawing.Color.White;
            this.Printing.OnHoverImage = null;
            this.Printing.OnPressedColor = System.Drawing.Color.Black;
            this.Printing.Size = new System.Drawing.Size(149, 42);
            this.Printing.TabIndex = 3;
            this.Printing.Text = "Print";
            this.Printing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Printing.Click += new System.EventHandler(this.Printing_Click);
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Printing);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.QRgen);
            this.Controls.Add(this.QRCodeBox);
            this.Name = "QRcode";
            this.Text = "QRcode";
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox QRCodeBox;
        private Guna.UI.WinForms.GunaButton QRgen;
        private Guna.UI.WinForms.GunaTextBox TextBox1;
        private Guna.UI.WinForms.GunaButton Printing;
    }
}