
namespace CuoiKiCDCNPM
{
    partial class Baocaoluong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTienPhuCap = new System.Windows.Forms.TextBox();
            this.boxTienBaoHiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNameBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTuoi = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchDiachi = new System.Windows.Forms.TextBox();
            this.searchHoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxLuongCoBan = new System.Windows.Forms.ComboBox();
            this.boxHoten = new System.Windows.Forms.ComboBox();
            this.boxTongLuong = new System.Windows.Forms.TextBox();
            this.boxKhoa = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.boxSoNgayCong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxHeSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxChuyenmon = new System.Windows.Forms.TextBox();
            this.boxCacKhoanTru = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridHeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSoNgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTienBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTienPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCacKhoanTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 50;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(452, 374);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnDelete.IconColor = System.Drawing.Color.Red;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 50;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(199, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 50;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(22, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Tính Lương";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(6, 55);
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
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khoa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(375, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền Phụ Cấp:";
            // 
            // boxTienPhuCap
            // 
            this.boxTienPhuCap.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTienPhuCap.Location = new System.Drawing.Point(518, 173);
            this.boxTienPhuCap.Name = "boxTienPhuCap";
            this.boxTienPhuCap.Size = new System.Drawing.Size(234, 34);
            this.boxTienPhuCap.TabIndex = 13;
            // 
            // boxTienBaoHiem
            // 
            this.boxTienBaoHiem.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTienBaoHiem.Location = new System.Drawing.Point(518, 110);
            this.boxTienBaoHiem.Name = "boxTienBaoHiem";
            this.boxTienBaoHiem.Size = new System.Drawing.Size(234, 34);
            this.boxTienBaoHiem.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(375, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tiền Bảo Hiểm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(375, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lương cơ bản:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.searchTuoi);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchDiachi);
            this.groupBox1.Controls.Add(this.searchHoten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(9, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 465);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNameBN,
            this.txtTuoi,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(26, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(443, 207);
            this.dataGridView2.TabIndex = 11;
            // 
            // txtNameBN
            // 
            this.txtNameBN.HeaderText = "Họ Tên";
            this.txtNameBN.MinimumWidth = 6;
            this.txtNameBN.Name = "txtNameBN";
            this.txtNameBN.ReadOnly = true;
            this.txtNameBN.Width = 220;
            // 
            // txtTuoi
            // 
            this.txtTuoi.HeaderText = "Chuyên Môn";
            this.txtTuoi.MinimumWidth = 6;
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Width = 175;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tổng Lương";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // searchTuoi
            // 
            this.searchTuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchTuoi.Location = new System.Drawing.Point(177, 92);
            this.searchTuoi.Name = "searchTuoi";
            this.searchTuoi.Size = new System.Drawing.Size(275, 34);
            this.searchTuoi.TabIndex = 44;
            this.searchTuoi.TextChanged += new System.EventHandler(this.searchTuoi_TextChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(252, 188);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(130, 43);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Text = "Làm Mới";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(38, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Chuyên Môn:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(38, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tổng Lương:";
            // 
            // searchDiachi
            // 
            this.searchDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchDiachi.Location = new System.Drawing.Point(177, 141);
            this.searchDiachi.Name = "searchDiachi";
            this.searchDiachi.Size = new System.Drawing.Size(275, 34);
            this.searchDiachi.TabIndex = 13;
            this.searchDiachi.TextChanged += new System.EventHandler(this.searchDiachi_TextChanged);
            // 
            // searchHoten
            // 
            this.searchHoten.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchHoten.Location = new System.Drawing.Point(177, 44);
            this.searchHoten.Name = "searchHoten";
            this.searchHoten.Size = new System.Drawing.Size(275, 34);
            this.searchHoten.TabIndex = 10;
            this.searchHoten.TextChanged += new System.EventHandler(this.searchHoten_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(38, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxLuongCoBan);
            this.groupBox2.Controls.Add(this.boxHoten);
            this.groupBox2.Controls.Add(this.boxTongLuong);
            this.groupBox2.Controls.Add(this.boxKhoa);
            this.groupBox2.Controls.Add(this.iconButton1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.boxSoNgayCong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.boxHeSoLuong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.boxChuyenmon);
            this.groupBox2.Controls.Add(this.boxCacKhoanTru);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.boxTienBaoHiem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.boxTienPhuCap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(512, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 465);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Lương";
            // 
            // boxLuongCoBan
            // 
            this.boxLuongCoBan.FormattingEnabled = true;
            this.boxLuongCoBan.Items.AddRange(new object[] {
            "1490000",
            "1600000"});
            this.boxLuongCoBan.Location = new System.Drawing.Point(518, 50);
            this.boxLuongCoBan.Name = "boxLuongCoBan";
            this.boxLuongCoBan.Size = new System.Drawing.Size(233, 33);
            this.boxLuongCoBan.TabIndex = 63;
            // 
            // boxHoten
            // 
            this.boxHoten.FormattingEnabled = true;
            this.boxHoten.Location = new System.Drawing.Point(130, 50);
            this.boxHoten.Name = "boxHoten";
            this.boxHoten.Size = new System.Drawing.Size(232, 33);
            this.boxHoten.TabIndex = 62;
            this.boxHoten.SelectedIndexChanged += new System.EventHandler(this.boxBacsi_SelectedIndexChanged);
            this.boxHoten.TextChanged += new System.EventHandler(this.boxHoten_TextChanged);
            // 
            // boxTongLuong
            // 
            this.boxTongLuong.Location = new System.Drawing.Point(518, 299);
            this.boxTongLuong.Name = "boxTongLuong";
            this.boxTongLuong.ReadOnly = true;
            this.boxTongLuong.Size = new System.Drawing.Size(234, 34);
            this.boxTongLuong.TabIndex = 61;
            this.boxTongLuong.MouseEnter += new System.EventHandler(this.textBox5_MouseEnter);
            // 
            // boxKhoa
            // 
            this.boxKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxKhoa.Location = new System.Drawing.Point(130, 109);
            this.boxKhoa.Name = "boxKhoa";
            this.boxKhoa.ReadOnly = true;
            this.boxKhoa.Size = new System.Drawing.Size(234, 34);
            this.boxKhoa.TabIndex = 59;
            this.boxKhoa.TextChanged += new System.EventHandler(this.boxKhoa_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(613, 374);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(131, 55);
            this.iconButton1.TabIndex = 45;
            this.iconButton1.Text = "In Phiếu";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(2, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "Số ngày công:";
            // 
            // boxSoNgayCong
            // 
            this.boxSoNgayCong.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxSoNgayCong.Location = new System.Drawing.Point(130, 299);
            this.boxSoNgayCong.Name = "boxSoNgayCong";
            this.boxSoNgayCong.Size = new System.Drawing.Size(234, 34);
            this.boxSoNgayCong.TabIndex = 58;
            this.boxSoNgayCong.TextChanged += new System.EventHandler(this.boxSoNgayCong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Hệ số lương:";
            // 
            // boxHeSoLuong
            // 
            this.boxHeSoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxHeSoLuong.Location = new System.Drawing.Point(130, 237);
            this.boxHeSoLuong.Name = "boxHeSoLuong";
            this.boxHeSoLuong.ReadOnly = true;
            this.boxHeSoLuong.Size = new System.Drawing.Size(234, 34);
            this.boxHeSoLuong.TabIndex = 56;
            this.boxHeSoLuong.TextChanged += new System.EventHandler(this.boxHeSoLuong_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Chuyên môn:";
            // 
            // boxChuyenmon
            // 
            this.boxChuyenmon.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxChuyenmon.Location = new System.Drawing.Point(130, 173);
            this.boxChuyenmon.Name = "boxChuyenmon";
            this.boxChuyenmon.ReadOnly = true;
            this.boxChuyenmon.Size = new System.Drawing.Size(234, 34);
            this.boxChuyenmon.TabIndex = 54;
            // 
            // boxCacKhoanTru
            // 
            this.boxCacKhoanTru.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.boxCacKhoanTru.Location = new System.Drawing.Point(517, 237);
            this.boxCacKhoanTru.Name = "boxCacKhoanTru";
            this.boxCacKhoanTru.Size = new System.Drawing.Size(234, 34);
            this.boxCacKhoanTru.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(375, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 23);
            this.label14.TabIndex = 50;
            this.label14.Text = "Các khoản trừ:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 50;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(329, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 55);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Sửa ";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(375, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Tổng Lương:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(441, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(324, 51);
            this.label15.TabIndex = 48;
            this.label15.Text = "QUẢN LÝ LƯƠNG";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(9, 517);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1270, 181);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kết quả";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "dd/mm/yy";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridMaNV,
            this.gridHoTen,
            this.gridKhoa,
            this.gridChuyenMon,
            this.gridHeSoLuong,
            this.gridSoNgayCong,
            this.gridLuongCoBan,
            this.gridTienBaoHiem,
            this.gridTienPhuCap,
            this.gridCacKhoanTru,
            this.gridTongLuong,
            this.thangluong});
            this.dataGridView1.Location = new System.Drawing.Point(38, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 147);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.textBox1.Location = new System.Drawing.Point(1145, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 34);
            this.textBox1.TabIndex = 59;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridMaNV
            // 
            this.gridMaNV.DataPropertyName = "idnhanvien";
            this.gridMaNV.HeaderText = "Mã NV";
            this.gridMaNV.MinimumWidth = 6;
            this.gridMaNV.Name = "gridMaNV";
            this.gridMaNV.Width = 125;
            // 
            // gridHoTen
            // 
            this.gridHoTen.HeaderText = "Họ Tên";
            this.gridHoTen.MinimumWidth = 6;
            this.gridHoTen.Name = "gridHoTen";
            this.gridHoTen.Width = 180;
            // 
            // gridKhoa
            // 
            this.gridKhoa.DataPropertyName = "gioitinh";
            this.gridKhoa.HeaderText = "Khoa";
            this.gridKhoa.MinimumWidth = 6;
            this.gridKhoa.Name = "gridKhoa";
            this.gridKhoa.Width = 125;
            // 
            // gridChuyenMon
            // 
            this.gridChuyenMon.DataPropertyName = "socmnd";
            this.gridChuyenMon.HeaderText = "Chuyên Môn";
            this.gridChuyenMon.MinimumWidth = 6;
            this.gridChuyenMon.Name = "gridChuyenMon";
            this.gridChuyenMon.Width = 150;
            // 
            // gridHeSoLuong
            // 
            this.gridHeSoLuong.DataPropertyName = "ngaysinh";
            this.gridHeSoLuong.HeaderText = "Hệ Số Lương";
            this.gridHeSoLuong.MinimumWidth = 6;
            this.gridHeSoLuong.Name = "gridHeSoLuong";
            this.gridHeSoLuong.Width = 175;
            // 
            // gridSoNgayCong
            // 
            this.gridSoNgayCong.DataPropertyName = "chucvu";
            this.gridSoNgayCong.HeaderText = "Số Ngày Công";
            this.gridSoNgayCong.MinimumWidth = 6;
            this.gridSoNgayCong.Name = "gridSoNgayCong";
            this.gridSoNgayCong.Width = 175;
            // 
            // gridLuongCoBan
            // 
            this.gridLuongCoBan.DataPropertyName = "sdt";
            this.gridLuongCoBan.HeaderText = "Lương Cơ Bản";
            this.gridLuongCoBan.MinimumWidth = 6;
            this.gridLuongCoBan.Name = "gridLuongCoBan";
            this.gridLuongCoBan.Width = 175;
            // 
            // gridTienBaoHiem
            // 
            this.gridTienBaoHiem.DataPropertyName = "diachi";
            this.gridTienBaoHiem.HeaderText = "Tiền Bảo Hiểm";
            this.gridTienBaoHiem.MinimumWidth = 6;
            this.gridTienBaoHiem.Name = "gridTienBaoHiem";
            this.gridTienBaoHiem.Width = 175;
            // 
            // gridTienPhuCap
            // 
            this.gridTienPhuCap.DataPropertyName = "email";
            this.gridTienPhuCap.HeaderText = "Tiền Phụ Cấp";
            this.gridTienPhuCap.MinimumWidth = 6;
            this.gridTienPhuCap.Name = "gridTienPhuCap";
            this.gridTienPhuCap.Width = 175;
            // 
            // gridCacKhoanTru
            // 
            this.gridCacKhoanTru.DataPropertyName = "chuyenmon";
            this.gridCacKhoanTru.HeaderText = "Các Khoản Trừ";
            this.gridCacKhoanTru.MinimumWidth = 6;
            this.gridCacKhoanTru.Name = "gridCacKhoanTru";
            this.gridCacKhoanTru.Width = 175;
            // 
            // gridTongLuong
            // 
            this.gridTongLuong.DataPropertyName = "khoa";
            this.gridTongLuong.HeaderText = "Tổng Lương";
            this.gridTongLuong.MinimumWidth = 6;
            this.gridTongLuong.Name = "gridTongLuong";
            this.gridTongLuong.Width = 150;
            // 
            // thangluong
            // 
            this.thangluong.HeaderText = "Tháng Lương";
            this.thangluong.MinimumWidth = 6;
            this.thangluong.Name = "thangluong";
            this.thangluong.Visible = false;
            this.thangluong.Width = 125;
            // 
            // Baocaoluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1282, 700);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Baocaoluong";
            this.Text = "Quản lý khám bệnh";
            this.Load += new System.EventHandler(this.Baocaoluong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxTienPhuCap;
        private System.Windows.Forms.TextBox boxTienBaoHiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchDiachi;
        private System.Windows.Forms.TextBox searchHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchTuoi;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.TextBox boxCacKhoanTru;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxSoNgayCong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxHeSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxChuyenmon;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox boxKhoa;
        private System.Windows.Forms.TextBox boxTongLuong;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox boxLuongCoBan;
        private System.Windows.Forms.ComboBox boxHoten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNameBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSoNgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTienBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTienPhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCacKhoanTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangluong;
    }
}