namespace Gms1
{
    partial class ScanQrCode
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanQrCode));
            this.ID_text = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Data5 = new Guna.UI.WinForms.GunaDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DT2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.DT1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btopen = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.PCB = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_text
            // 
            this.ID_text.Location = new System.Drawing.Point(63, 38);
            this.ID_text.Multiline = true;
            this.ID_text.Name = "ID_text";
            this.ID_text.Size = new System.Drawing.Size(148, 22);
            this.ID_text.TabIndex = 45;
            this.ID_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(33, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Data5
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Data5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Data5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data5.BackgroundColor = System.Drawing.Color.White;
            this.Data5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data5.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Data5.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Data5.EnableHeadersVisualStyles = false;
            this.Data5.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data5.Location = new System.Drawing.Point(6, 86);
            this.Data5.Name = "Data5";
            this.Data5.RowHeadersVisible = false;
            this.Data5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data5.Size = new System.Drawing.Size(867, 368);
            this.Data5.TabIndex = 65;
            this.Data5.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Data5.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Data5.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Data5.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Data5.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Data5.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Data5.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Data5.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data5.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Data5.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Data5.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data5.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Data5.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Data5.ThemeStyle.HeaderStyle.Height = 4;
            this.Data5.ThemeStyle.ReadOnly = false;
            this.Data5.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Data5.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Data5.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data5.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Data5.ThemeStyle.RowsStyle.Height = 22;
            this.Data5.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Data5.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Data5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data5_CellClick);
            this.Data5.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data5_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DT2);
            this.groupBox1.Controls.Add(this.DT1);
            this.groupBox1.Controls.Add(this.Data5);
            this.groupBox1.Controls.Add(this.ID_text);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(244, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 472);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DT2
            // 
            this.DT2.BaseColor = System.Drawing.Color.White;
            this.DT2.BorderColor = System.Drawing.Color.Silver;
            this.DT2.CustomFormat = "d/MM/yyyy";
            this.DT2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DT2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DT2.ForeColor = System.Drawing.Color.Black;
            this.DT2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT2.Location = new System.Drawing.Point(387, 38);
            this.DT2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DT2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DT2.Name = "DT2";
            this.DT2.OnHoverBaseColor = System.Drawing.Color.White;
            this.DT2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT2.OnPressedColor = System.Drawing.Color.Black;
            this.DT2.Size = new System.Drawing.Size(117, 30);
            this.DT2.TabIndex = 67;
            this.DT2.Text = "22/05/2024";
            this.DT2.Value = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // DT1
            // 
            this.DT1.BaseColor = System.Drawing.Color.White;
            this.DT1.BorderColor = System.Drawing.Color.Silver;
            this.DT1.CustomFormat = "d/MM/yyyy";
            this.DT1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DT1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DT1.ForeColor = System.Drawing.Color.Black;
            this.DT1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT1.Location = new System.Drawing.Point(243, 38);
            this.DT1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DT1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DT1.Name = "DT1";
            this.DT1.OnHoverBaseColor = System.Drawing.Color.White;
            this.DT1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DT1.OnPressedColor = System.Drawing.Color.Black;
            this.DT1.Size = new System.Drawing.Size(117, 30);
            this.DT1.TabIndex = 66;
            this.DT1.Text = "22/05/2024";
            this.DT1.Value = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // btopen
            // 
            this.btopen.AnimationHoverSpeed = 0.07F;
            this.btopen.AnimationSpeed = 0.03F;
            this.btopen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btopen.BorderColor = System.Drawing.Color.Black;
            this.btopen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btopen.FocusedColor = System.Drawing.Color.Empty;
            this.btopen.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btopen.ForeColor = System.Drawing.Color.White;
            this.btopen.Image = ((System.Drawing.Image)(resources.GetObject("btopen.Image")));
            this.btopen.ImageSize = new System.Drawing.Size(20, 20);
            this.btopen.Location = new System.Drawing.Point(54, 299);
            this.btopen.Name = "btopen";
            this.btopen.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btopen.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btopen.OnHoverForeColor = System.Drawing.Color.White;
            this.btopen.OnHoverImage = null;
            this.btopen.OnPressedColor = System.Drawing.Color.Black;
            this.btopen.Size = new System.Drawing.Size(161, 42);
            this.btopen.TabIndex = 64;
            this.btopen.Text = "ເປິດກ້ອງ";
            this.btopen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Phetsarath OT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(54, 364);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(161, 42);
            this.gunaButton1.TabIndex = 65;
            this.gunaButton1.Text = "ສະແກນ QrCode";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // PCB
            // 
            this.PCB.BaseColor = System.Drawing.Color.White;
            this.PCB.Location = new System.Drawing.Point(54, 126);
            this.PCB.Name = "PCB";
            this.PCB.Size = new System.Drawing.Size(158, 153);
            this.PCB.TabIndex = 66;
            this.PCB.TabStop = false;
            this.PCB.Click += new System.EventHandler(this.PCB_Click);
            // 
            // ScanQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 517);
            this.Controls.Add(this.PCB);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.btopen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScanQrCode";
            this.Text = "ScanQrCode";
            this.Load += new System.EventHandler(this.ScanQrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ID_text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaDataGridView Data5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaButton btopen;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaPictureBox PCB;
        private Guna.UI.WinForms.GunaDateTimePicker DT2;
        private Guna.UI.WinForms.GunaDateTimePicker DT1;
    }
}