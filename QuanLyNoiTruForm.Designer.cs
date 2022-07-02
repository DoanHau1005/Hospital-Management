
namespace CuoiKiCDCNPM
{
    partial class QuanLyNoiTruForm
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaynhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMaGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNoitru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMaBN = new System.Windows.Forms.TextBox();
            this.boxTenBN = new System.Windows.Forms.TextBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.boxSdt = new System.Windows.Forms.TextBox();
            this.boxNghenghiep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxNoitru = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxGB = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAddBN = new FontAwesome.Sharp.IconButton();
            this.tongTien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.boxPhiGB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.boxGbenh = new System.Windows.Forms.TextBox();
            this.maBN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bhyt = new System.Windows.Forms.TextBox();
            this.boxTuoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 50;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(473, 289);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Tính tổng";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaso,
            this.txtHoten,
            this.txtMaGB,
            this.txtTinhtrang,
            this.txtPhi,
            this.txtNgaynhan,
            this.txtNgaytra,
            this.txtTongtien,
            this.tenMaGB,
            this.txtTuoi,
            this.txtGioitinh,
            this.txtNghenghiep,
            this.txtBhyt,
            this.txtSDT,
            this.txtNoitru});
            this.dataGridView1.Location = new System.Drawing.Point(8, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 169);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtMaso
            // 
            this.txtMaso.Frozen = true;
            this.txtMaso.HeaderText = "Mã BN";
            this.txtMaso.MinimumWidth = 6;
            this.txtMaso.Name = "txtMaso";
            this.txtMaso.ReadOnly = true;
            this.txtMaso.Width = 125;
            // 
            // txtHoten
            // 
            this.txtHoten.Frozen = true;
            this.txtHoten.HeaderText = "Họ Và Tên";
            this.txtHoten.MinimumWidth = 6;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.ReadOnly = true;
            this.txtHoten.Width = 175;
            // 
            // txtMaGB
            // 
            this.txtMaGB.Frozen = true;
            this.txtMaGB.HeaderText = "Mã Giường Bệnh";
            this.txtMaGB.MinimumWidth = 6;
            this.txtMaGB.Name = "txtMaGB";
            this.txtMaGB.ReadOnly = true;
            this.txtMaGB.Width = 175;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Frozen = true;
            this.txtTinhtrang.HeaderText = "Tình Trạng";
            this.txtTinhtrang.MinimumWidth = 6;
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.ReadOnly = true;
            this.txtTinhtrang.Width = 125;
            // 
            // txtPhi
            // 
            this.txtPhi.Frozen = true;
            this.txtPhi.HeaderText = "Phí Giường Bệnh";
            this.txtPhi.MinimumWidth = 6;
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.ReadOnly = true;
            this.txtPhi.Width = 175;
            // 
            // txtNgaynhan
            // 
            this.txtNgaynhan.Frozen = true;
            this.txtNgaynhan.HeaderText = "Ngày Nhận Phòng";
            this.txtNgaynhan.MinimumWidth = 6;
            this.txtNgaynhan.Name = "txtNgaynhan";
            this.txtNgaynhan.ReadOnly = true;
            this.txtNgaynhan.Width = 175;
            // 
            // txtNgaytra
            // 
            this.txtNgaytra.Frozen = true;
            this.txtNgaytra.HeaderText = "Ngày Trả Phòng";
            this.txtNgaytra.MinimumWidth = 6;
            this.txtNgaytra.Name = "txtNgaytra";
            this.txtNgaytra.ReadOnly = true;
            this.txtNgaytra.Width = 150;
            // 
            // txtTongtien
            // 
            this.txtTongtien.HeaderText = "Tổng Tiền Phòng";
            this.txtTongtien.MinimumWidth = 6;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Width = 180;
            // 
            // tenMaGB
            // 
            this.tenMaGB.HeaderText = "Tên Mã Giường";
            this.tenMaGB.MinimumWidth = 6;
            this.tenMaGB.Name = "tenMaGB";
            this.tenMaGB.ReadOnly = true;
            this.tenMaGB.Visible = false;
            this.tenMaGB.Width = 125;
            // 
            // txtTuoi
            // 
            this.txtTuoi.HeaderText = "Tuổi";
            this.txtTuoi.MinimumWidth = 6;
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Visible = false;
            this.txtTuoi.Width = 125;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.HeaderText = "Giới tính";
            this.txtGioitinh.MinimumWidth = 6;
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.ReadOnly = true;
            this.txtGioitinh.Visible = false;
            this.txtGioitinh.Width = 125;
            // 
            // txtNghenghiep
            // 
            this.txtNghenghiep.HeaderText = "Nghề nghiệp";
            this.txtNghenghiep.MinimumWidth = 6;
            this.txtNghenghiep.Name = "txtNghenghiep";
            this.txtNghenghiep.ReadOnly = true;
            this.txtNghenghiep.Visible = false;
            this.txtNghenghiep.Width = 125;
            // 
            // txtBhyt
            // 
            this.txtBhyt.HeaderText = "BHYT";
            this.txtBhyt.MinimumWidth = 6;
            this.txtBhyt.Name = "txtBhyt";
            this.txtBhyt.ReadOnly = true;
            this.txtBhyt.Visible = false;
            this.txtBhyt.Width = 125;
            // 
            // txtSDT
            // 
            this.txtSDT.HeaderText = "Số điện thoại";
            this.txtSDT.MinimumWidth = 6;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Visible = false;
            this.txtSDT.Width = 125;
            // 
            // txtNoitru
            // 
            this.txtNoitru.HeaderText = "Mã nội trú";
            this.txtNoitru.MinimumWidth = 6;
            this.txtNoitru.Name = "txtNoitru";
            this.txtNoitru.ReadOnly = true;
            this.txtNoitru.Visible = false;
            this.txtNoitru.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã BN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(41, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(43, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "BHYT:";
            // 
            // boxMaBN
            // 
            this.boxMaBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxMaBN.Location = new System.Drawing.Point(173, 48);
            this.boxMaBN.Name = "boxMaBN";
            this.boxMaBN.ReadOnly = true;
            this.boxMaBN.Size = new System.Drawing.Size(70, 34);
            this.boxMaBN.TabIndex = 10;
            this.boxMaBN.TextChanged += new System.EventHandler(this.boxMaBN_TextChanged);
            // 
            // boxTenBN
            // 
            this.boxTenBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTenBN.Location = new System.Drawing.Point(173, 112);
            this.boxTenBN.Name = "boxTenBN";
            this.boxTenBN.ReadOnly = true;
            this.boxTenBN.Size = new System.Drawing.Size(268, 34);
            this.boxTenBN.TabIndex = 11;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Enabled = false;
            this.radioNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioNam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioNam.Location = new System.Drawing.Point(173, 177);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(70, 27);
            this.radioNam.TabIndex = 14;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Enabled = false;
            this.radioNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioNu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioNu.Location = new System.Drawing.Point(320, 177);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(57, 27);
            this.radioNu.TabIndex = 15;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // boxSdt
            // 
            this.boxSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxSdt.Location = new System.Drawing.Point(173, 376);
            this.boxSdt.Name = "boxSdt";
            this.boxSdt.ReadOnly = true;
            this.boxSdt.Size = new System.Drawing.Size(268, 34);
            this.boxSdt.TabIndex = 25;
            // 
            // boxNghenghiep
            // 
            this.boxNghenghiep.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxNghenghiep.Location = new System.Drawing.Point(173, 235);
            this.boxNghenghiep.Name = "boxNghenghiep";
            this.boxNghenghiep.ReadOnly = true;
            this.boxNghenghiep.Size = new System.Drawing.Size(268, 34);
            this.boxNghenghiep.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(43, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "SĐT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(41, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nghề nghiệp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxNoitru);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.boxGB);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.btnAddBN);
            this.groupBox1.Controls.Add(this.tongTien);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.boxPhiGB);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.boxGbenh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.maBN);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 433);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Nội Trú";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // boxNoitru
            // 
            this.boxNoitru.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxNoitru.Location = new System.Drawing.Point(201, 57);
            this.boxNoitru.Name = "boxNoitru";
            this.boxNoitru.ReadOnly = true;
            this.boxNoitru.Size = new System.Drawing.Size(56, 30);
            this.boxNoitru.TabIndex = 55;
            this.boxNoitru.TextChanged += new System.EventHandler(this.boxNoitru_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(15, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Mã nội trú:";
            // 
            // boxGB
            // 
            this.boxGB.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxGB.FormattingEnabled = true;
            this.boxGB.ItemHeight = 26;
            this.boxGB.Items.AddRange(new object[] {
            ""});
            this.boxGB.Location = new System.Drawing.Point(201, 112);
            this.boxGB.Name = "boxGB";
            this.boxGB.Size = new System.Drawing.Size(208, 30);
            this.boxGB.TabIndex = 38;
            this.boxGB.SelectedIndexChanged += new System.EventHandler(this.boxGB_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Location = new System.Drawing.Point(510, 228);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(252, 34);
            this.dateTimePicker2.TabIndex = 30;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 108);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 34);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 50;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(441, 364);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 56);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Sửa ";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 50;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(223, 364);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 56);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 50;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(627, 364);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 56);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(441, 55);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 31);
            this.iconButton1.TabIndex = 28;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAddBN
            // 
            this.btnAddBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddBN.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddBN.IconColor = System.Drawing.Color.DarkGreen;
            this.btnAddBN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBN.IconSize = 50;
            this.btnAddBN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBN.Location = new System.Drawing.Point(19, 364);
            this.btnAddBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBN.Name = "btnAddBN";
            this.btnAddBN.Size = new System.Drawing.Size(110, 56);
            this.btnAddBN.TabIndex = 50;
            this.btnAddBN.Text = "Thêm";
            this.btnAddBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBN.UseVisualStyleBackColor = true;
            this.btnAddBN.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // tongTien
            // 
            this.tongTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tongTien.Location = new System.Drawing.Point(201, 303);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(208, 30);
            this.tongTien.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(15, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 23);
            this.label17.TabIndex = 26;
            this.label17.Text = "Tổng Tiền Phòng";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(506, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "Ngày Trả Phòng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(506, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ngày Nhận Phòng:";
            // 
            // boxPhiGB
            // 
            this.boxPhiGB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxPhiGB.Location = new System.Drawing.Point(201, 237);
            this.boxPhiGB.Name = "boxPhiGB";
            this.boxPhiGB.Size = new System.Drawing.Size(208, 30);
            this.boxPhiGB.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(270, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Mã BN:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // boxGbenh
            // 
            this.boxGbenh.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxGbenh.Location = new System.Drawing.Point(201, 174);
            this.boxGbenh.Name = "boxGbenh";
            this.boxGbenh.ReadOnly = true;
            this.boxGbenh.Size = new System.Drawing.Size(208, 30);
            this.boxGbenh.TabIndex = 19;
            this.boxGbenh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // maBN
            // 
            this.maBN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.maBN.Location = new System.Drawing.Point(353, 57);
            this.maBN.Name = "maBN";
            this.maBN.Size = new System.Drawing.Size(56, 30);
            this.maBN.TabIndex = 18;
            this.maBN.TextChanged += new System.EventHandler(this.maBN_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(15, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tình Trạng Giường:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(15, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Phí Giường Bệnh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(15, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã Giường Bệnh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bhyt);
            this.groupBox2.Controls.Add(this.boxTuoi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.boxNghenghiep);
            this.groupBox2.Controls.Add(this.boxMaBN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.boxTenBN);
            this.groupBox2.Controls.Add(this.boxSdt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioNam);
            this.groupBox2.Controls.Add(this.radioNu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(803, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 433);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // bhyt
            // 
            this.bhyt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.bhyt.Location = new System.Drawing.Point(173, 310);
            this.bhyt.Name = "bhyt";
            this.bhyt.ReadOnly = true;
            this.bhyt.Size = new System.Drawing.Size(268, 34);
            this.bhyt.TabIndex = 46;
            // 
            // boxTuoi
            // 
            this.boxTuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTuoi.Location = new System.Drawing.Point(320, 45);
            this.boxTuoi.Name = "boxTuoi";
            this.boxTuoi.ReadOnly = true;
            this.boxTuoi.Size = new System.Drawing.Size(121, 34);
            this.boxTuoi.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(261, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tuổi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(7, 497);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1252, 217);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Bệnh Nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(486, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 51);
            this.label5.TabIndex = 47;
            this.label5.Text = "HỒ SƠ NỘI TRÚ";
            // 
            // QuanLyNoiTruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1269, 715);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "QuanLyNoiTruForm";
            this.Text = "Quản Lý Nội Trú";
            this.Load += new System.EventHandler(this.QuanLyNoiTruForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxMaBN;
        private System.Windows.Forms.TextBox boxTenBN;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.TextBox boxSdt;
        private System.Windows.Forms.TextBox boxNghenghiep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxTuoi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox boxGbenh;
        private System.Windows.Forms.TextBox maBN;
        private System.Windows.Forms.TextBox tongTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boxPhiGB;
        private System.Windows.Forms.TextBox bhyt;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAddBN;
        private System.Windows.Forms.ListBox boxGB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxNoitru;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMaGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNoitru;
    }
}