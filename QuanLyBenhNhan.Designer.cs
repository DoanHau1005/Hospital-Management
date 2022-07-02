
namespace CuoiKiCDCNPM
{
    partial class QuanLyBenhNhan
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
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMaBN = new System.Windows.Forms.TextBox();
            this.boxTenBN = new System.Windows.Forms.TextBox();
            this.boxDiachi = new System.Windows.Forms.TextBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.boxSdt = new System.Windows.Forms.TextBox();
            this.boxNghenghiep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxTrieuchung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtNameBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTuoi = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchDiachi = new System.Windows.Forms.TextBox();
            this.searchHoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxPhong = new System.Windows.Forms.TextBox();
            this.boxBHYT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelPhong = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.boxTuoi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.boxBacsi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTrieuchung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBacsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNgaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTuoir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bacsilistview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.btnClear.Location = new System.Drawing.Point(619, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 55);
            this.btnClear.TabIndex = 16;
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
            this.btnDelete.Location = new System.Drawing.Point(228, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 55);
            this.btnDelete.TabIndex = 14;
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
            this.btnAdd.Location = new System.Drawing.Point(37, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 55);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
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
            this.txtTenBN,
            this.txtGioitinh,
            this.txtDiachi,
            this.txtSdt,
            this.txtTrieuchung,
            this.txtBacsi,
            this.txtNgaykham,
            this.txtNghenghiep,
            this.txtTuoir,
            this.txtBHYT,
            this.txtPhong,
            this.bacsilistview});
            this.dataGridView1.Location = new System.Drawing.Point(9, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 137);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 54);
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
            this.label2.Location = new System.Drawing.Point(12, 115);
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
            this.label3.Location = new System.Drawing.Point(12, 173);
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
            this.label4.Location = new System.Drawing.Point(394, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ:";
            // 
            // boxMaBN
            // 
            this.boxMaBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxMaBN.Location = new System.Drawing.Point(131, 47);
            this.boxMaBN.Name = "boxMaBN";
            this.boxMaBN.ReadOnly = true;
            this.boxMaBN.Size = new System.Drawing.Size(70, 34);
            this.boxMaBN.TabIndex = 10;
            this.boxMaBN.TextChanged += new System.EventHandler(this.boxMaBN_TextChanged);
            // 
            // boxTenBN
            // 
            this.boxTenBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTenBN.Location = new System.Drawing.Point(131, 110);
            this.boxTenBN.Name = "boxTenBN";
            this.boxTenBN.Size = new System.Drawing.Size(234, 34);
            this.boxTenBN.TabIndex = 2;
            // 
            // boxDiachi
            // 
            this.boxDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxDiachi.Location = new System.Drawing.Point(519, 162);
            this.boxDiachi.Name = "boxDiachi";
            this.boxDiachi.Size = new System.Drawing.Size(234, 34);
            this.boxDiachi.TabIndex = 9;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioNam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioNam.Location = new System.Drawing.Point(131, 170);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(70, 27);
            this.radioNam.TabIndex = 3;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioNu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioNu.Location = new System.Drawing.Point(226, 171);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(57, 27);
            this.radioNu.TabIndex = 4;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // boxSdt
            // 
            this.boxSdt.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxSdt.Location = new System.Drawing.Point(518, 102);
            this.boxSdt.Name = "boxSdt";
            this.boxSdt.Size = new System.Drawing.Size(234, 34);
            this.boxSdt.TabIndex = 8;
            // 
            // boxNghenghiep
            // 
            this.boxNghenghiep.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxNghenghiep.Location = new System.Drawing.Point(518, 44);
            this.boxNghenghiep.Name = "boxNghenghiep";
            this.boxNghenghiep.Size = new System.Drawing.Size(234, 34);
            this.boxNghenghiep.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(394, 108);
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
            this.label9.Location = new System.Drawing.Point(394, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nghề nghiệp:";
            // 
            // boxTrieuchung
            // 
            this.boxTrieuchung.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTrieuchung.Location = new System.Drawing.Point(131, 282);
            this.boxTrieuchung.Multiline = true;
            this.boxTrieuchung.Name = "boxTrieuchung";
            this.boxTrieuchung.Size = new System.Drawing.Size(234, 88);
            this.boxTrieuchung.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(10, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Lý do khám:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.searchTuoi);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchDiachi);
            this.groupBox1.Controls.Add(this.searchHoten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 465);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm bệnh nhân";
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
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtNameBN
            // 
            this.txtNameBN.HeaderText = "Họ Tên";
            this.txtNameBN.MinimumWidth = 6;
            this.txtNameBN.Name = "txtNameBN";
            this.txtNameBN.ReadOnly = true;
            this.txtNameBN.Width = 190;
            // 
            // txtTuoi
            // 
            this.txtTuoi.HeaderText = "Tuổi";
            this.txtTuoi.MinimumWidth = 6;
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ReadOnly = true;
            this.txtTuoi.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Địa Chỉ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // searchTuoi
            // 
            this.searchTuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.searchTuoi.Location = new System.Drawing.Point(370, 42);
            this.searchTuoi.Name = "searchTuoi";
            this.searchTuoi.Size = new System.Drawing.Size(87, 34);
            this.searchTuoi.TabIndex = 18;
            this.searchTuoi.TextChanged += new System.EventHandler(this.searchTuoi_TextChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.Green;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(158, 168);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(131, 43);
            this.iconButton3.TabIndex = 20;
            this.iconButton3.Text = "Tìm Kiếm";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(327, 168);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(130, 43);
            this.iconButton2.TabIndex = 21;
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
            this.label13.Location = new System.Drawing.Point(301, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tuổi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(14, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Địa Chỉ:";
            // 
            // searchDiachi
            // 
            this.searchDiachi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchDiachi.Location = new System.Drawing.Point(101, 108);
            this.searchDiachi.Name = "searchDiachi";
            this.searchDiachi.Size = new System.Drawing.Size(356, 30);
            this.searchDiachi.TabIndex = 19;
            this.searchDiachi.TextChanged += new System.EventHandler(this.searchDiachi_TextChanged);
            // 
            // searchHoten
            // 
            this.searchHoten.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchHoten.Location = new System.Drawing.Point(101, 46);
            this.searchHoten.Name = "searchHoten";
            this.searchHoten.Size = new System.Drawing.Size(191, 30);
            this.searchHoten.TabIndex = 17;
            this.searchHoten.TextChanged += new System.EventHandler(this.searchHoten_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(15, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Họ Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxPhong);
            this.groupBox2.Controls.Add(this.boxBHYT);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelPhong);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.boxTuoi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.boxBacsi);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.boxNghenghiep);
            this.groupBox2.Controls.Add(this.boxMaBN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.boxTrieuchung);
            this.groupBox2.Controls.Add(this.boxTenBN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxSdt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radioNam);
            this.groupBox2.Controls.Add(this.radioNu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.boxDiachi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(510, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 465);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // boxPhong
            // 
            this.boxPhong.Location = new System.Drawing.Point(518, 276);
            this.boxPhong.Name = "boxPhong";
            this.boxPhong.ReadOnly = true;
            this.boxPhong.Size = new System.Drawing.Size(234, 34);
            this.boxPhong.TabIndex = 11;
            // 
            // boxBHYT
            // 
            this.boxBHYT.Location = new System.Drawing.Point(518, 218);
            this.boxBHYT.Name = "boxBHYT";
            this.boxBHYT.Size = new System.Drawing.Size(234, 34);
            this.boxBHYT.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(400, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 50;
            this.label14.Text = "BHYT:";
            // 
            // labelPhong
            // 
            this.labelPhong.AutoSize = true;
            this.labelPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelPhong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPhong.Location = new System.Drawing.Point(400, 281);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(74, 23);
            this.labelPhong.TabIndex = 49;
            this.labelPhong.Text = "Phòng: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 50;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(421, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 55);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Sửa ";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // boxTuoi
            // 
            this.boxTuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTuoi.Location = new System.Drawing.Point(289, 47);
            this.boxTuoi.Name = "boxTuoi";
            this.boxTuoi.Size = new System.Drawing.Size(76, 34);
            this.boxTuoi.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(394, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 42;
            this.label11.Text = "Ngày khám:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMMdd, yyyy  |  hh:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 333);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 4, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 34);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(230, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tuổi:";
            // 
            // boxBacsi
            // 
            this.boxBacsi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxBacsi.FormattingEnabled = true;
            this.boxBacsi.ItemHeight = 26;
            this.boxBacsi.Items.AddRange(new object[] {
            ""});
            this.boxBacsi.Location = new System.Drawing.Point(131, 225);
            this.boxBacsi.Name = "boxBacsi";
            this.boxBacsi.Size = new System.Drawing.Size(234, 30);
            this.boxBacsi.TabIndex = 5;
            this.boxBacsi.SelectedIndexChanged += new System.EventHandler(this.boxBacsi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(10, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Bác sĩ khám:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(7, 534);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1270, 176);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Bệnh Nhân";
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
            this.label15.Size = new System.Drawing.Size(409, 51);
            this.label15.TabIndex = 48;
            this.label15.Text = "QUẢN LÝ BỆNH NHÂN";
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
            // txtTenBN
            // 
            this.txtTenBN.Frozen = true;
            this.txtTenBN.HeaderText = "Họ và Tên";
            this.txtTenBN.MinimumWidth = 6;
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.ReadOnly = true;
            this.txtTenBN.Width = 200;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Frozen = true;
            this.txtGioitinh.HeaderText = "Giới tính";
            this.txtGioitinh.MinimumWidth = 6;
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.ReadOnly = true;
            this.txtGioitinh.Width = 125;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Frozen = true;
            this.txtDiachi.HeaderText = "Địa chỉ";
            this.txtDiachi.MinimumWidth = 6;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.ReadOnly = true;
            this.txtDiachi.Width = 200;
            // 
            // txtSdt
            // 
            this.txtSdt.Frozen = true;
            this.txtSdt.HeaderText = "SĐT";
            this.txtSdt.MinimumWidth = 6;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.ReadOnly = true;
            this.txtSdt.Width = 160;
            // 
            // txtTrieuchung
            // 
            this.txtTrieuchung.Frozen = true;
            this.txtTrieuchung.HeaderText = "Triệu Chứng";
            this.txtTrieuchung.MinimumWidth = 6;
            this.txtTrieuchung.Name = "txtTrieuchung";
            this.txtTrieuchung.ReadOnly = true;
            this.txtTrieuchung.Width = 170;
            // 
            // txtBacsi
            // 
            this.txtBacsi.Frozen = true;
            this.txtBacsi.HeaderText = "Bác sĩ khám";
            this.txtBacsi.MinimumWidth = 6;
            this.txtBacsi.Name = "txtBacsi";
            this.txtBacsi.ReadOnly = true;
            this.txtBacsi.Width = 150;
            // 
            // txtNgaykham
            // 
            this.txtNgaykham.Frozen = true;
            this.txtNgaykham.HeaderText = "Ngày Khám";
            this.txtNgaykham.MinimumWidth = 6;
            this.txtNgaykham.Name = "txtNgaykham";
            this.txtNgaykham.ReadOnly = true;
            this.txtNgaykham.Width = 160;
            // 
            // txtNghenghiep
            // 
            this.txtNghenghiep.Frozen = true;
            this.txtNghenghiep.HeaderText = "Nghề nghiệp";
            this.txtNghenghiep.MinimumWidth = 6;
            this.txtNghenghiep.Name = "txtNghenghiep";
            this.txtNghenghiep.ReadOnly = true;
            this.txtNghenghiep.Visible = false;
            this.txtNghenghiep.Width = 125;
            // 
            // txtTuoir
            // 
            this.txtTuoir.Frozen = true;
            this.txtTuoir.HeaderText = "Tuổi";
            this.txtTuoir.MinimumWidth = 6;
            this.txtTuoir.Name = "txtTuoir";
            this.txtTuoir.ReadOnly = true;
            this.txtTuoir.Visible = false;
            this.txtTuoir.Width = 125;
            // 
            // txtBHYT
            // 
            this.txtBHYT.HeaderText = "BHYT";
            this.txtBHYT.MinimumWidth = 6;
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.ReadOnly = true;
            this.txtBHYT.Visible = false;
            this.txtBHYT.Width = 125;
            // 
            // txtPhong
            // 
            this.txtPhong.HeaderText = "Phòng";
            this.txtPhong.MinimumWidth = 6;
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Visible = false;
            this.txtPhong.Width = 125;
            // 
            // bacsilistview
            // 
            this.bacsilistview.HeaderText = "bác sỹ listview";
            this.bacsilistview.MinimumWidth = 6;
            this.bacsilistview.Name = "bacsilistview";
            this.bacsilistview.ReadOnly = true;
            this.bacsilistview.Visible = false;
            this.bacsilistview.Width = 125;
            // 
            // QuanLyBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1282, 711);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "QuanLyBenhNhan";
            this.Text = "Quản lý khám bệnh";
            this.Load += new System.EventHandler(this.QuanLyBenhNhan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxMaBN;
        private System.Windows.Forms.TextBox boxTenBN;
        private System.Windows.Forms.TextBox boxDiachi;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.TextBox boxSdt;
        private System.Windows.Forms.TextBox boxNghenghiep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxTrieuchung;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchDiachi;
        private System.Windows.Forms.TextBox searchHoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox boxBacsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxTuoi;
        private System.Windows.Forms.TextBox searchTuoi;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.TextBox boxPhong;
        private System.Windows.Forms.TextBox boxBHYT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNameBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTrieuchung;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNgaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNghenghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTuoir;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn bacsilistview;
    }
}