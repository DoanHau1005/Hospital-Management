
namespace CuoiKiCDCNPM
{
    partial class ManagementMedicine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridMathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNhomthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDonvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridHamluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCachdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridGhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxNcc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listDonvi = new System.Windows.Forms.ListBox();
            this.boxNhomthuoc = new System.Windows.Forms.TextBox();
            this.boxTenthuoc = new System.Windows.Forms.TextBox();
            this.boxSoluong = new System.Windows.Forms.TextBox();
            this.boxMaThuoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNhomThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchNhomthuoc = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchTenthuoc = new System.Windows.Forms.TextBox();
            this.searchMaThuoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxCachdung = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxGhichu = new System.Windows.Forms.TextBox();
            this.boxHamluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDongia = new System.Windows.Forms.TextBox();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridMathuoc,
            this.gridTenthuoc,
            this.gridNhomthuoc,
            this.gridDonvitinh,
            this.gridHamluong,
            this.gridCachdung,
            this.gridSoluong,
            this.gridNcc,
            this.gridGhichu,
            this.gridDongia});
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1257, 179);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gridMathuoc
            // 
            this.gridMathuoc.HeaderText = "Mã";
            this.gridMathuoc.MinimumWidth = 6;
            this.gridMathuoc.Name = "gridMathuoc";
            this.gridMathuoc.ReadOnly = true;
            this.gridMathuoc.Width = 50;
            // 
            // gridTenthuoc
            // 
            this.gridTenthuoc.HeaderText = "Tên Thuốc";
            this.gridTenthuoc.MinimumWidth = 6;
            this.gridTenthuoc.Name = "gridTenthuoc";
            this.gridTenthuoc.ReadOnly = true;
            this.gridTenthuoc.Width = 220;
            // 
            // gridNhomthuoc
            // 
            this.gridNhomthuoc.HeaderText = "Nhóm Thuốc";
            this.gridNhomthuoc.MinimumWidth = 6;
            this.gridNhomthuoc.Name = "gridNhomthuoc";
            this.gridNhomthuoc.ReadOnly = true;
            this.gridNhomthuoc.Width = 228;
            // 
            // gridDonvitinh
            // 
            this.gridDonvitinh.HeaderText = "Đơn Vị Tính";
            this.gridDonvitinh.MinimumWidth = 6;
            this.gridDonvitinh.Name = "gridDonvitinh";
            this.gridDonvitinh.ReadOnly = true;
            this.gridDonvitinh.Width = 178;
            // 
            // gridHamluong
            // 
            this.gridHamluong.HeaderText = "Hàm lượng";
            this.gridHamluong.MinimumWidth = 6;
            this.gridHamluong.Name = "gridHamluong";
            this.gridHamluong.ReadOnly = true;
            this.gridHamluong.Width = 200;
            // 
            // gridCachdung
            // 
            this.gridCachdung.HeaderText = "Cách dùng";
            this.gridCachdung.MinimumWidth = 6;
            this.gridCachdung.Name = "gridCachdung";
            this.gridCachdung.ReadOnly = true;
            this.gridCachdung.Visible = false;
            this.gridCachdung.Width = 160;
            // 
            // gridSoluong
            // 
            this.gridSoluong.HeaderText = "Số Lượng";
            this.gridSoluong.MinimumWidth = 6;
            this.gridSoluong.Name = "gridSoluong";
            this.gridSoluong.ReadOnly = true;
            this.gridSoluong.Visible = false;
            this.gridSoluong.Width = 120;
            // 
            // gridNcc
            // 
            this.gridNcc.HeaderText = "NCC";
            this.gridNcc.MinimumWidth = 6;
            this.gridNcc.Name = "gridNcc";
            this.gridNcc.ReadOnly = true;
            this.gridNcc.Width = 128;
            // 
            // gridGhichu
            // 
            this.gridGhichu.HeaderText = "Ghi chú";
            this.gridGhichu.MinimumWidth = 6;
            this.gridGhichu.Name = "gridGhichu";
            this.gridGhichu.ReadOnly = true;
            this.gridGhichu.Width = 200;
            // 
            // gridDongia
            // 
            this.gridDongia.HeaderText = "Đơn giá";
            this.gridDongia.MinimumWidth = 6;
            this.gridDongia.Name = "gridDongia";
            this.gridDongia.ReadOnly = true;
            this.gridDongia.Visible = false;
            this.gridDongia.Width = 125;
            // 
            // boxNcc
            // 
            this.boxNcc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxNcc.Location = new System.Drawing.Point(528, 195);
            this.boxNcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNcc.MaxLength = 50;
            this.boxNcc.Name = "boxNcc";
            this.boxNcc.Size = new System.Drawing.Size(244, 34);
            this.boxNcc.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(188, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 36;
            this.label11.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(408, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tên NCC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(408, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Đơn vị tính: ";
            // 
            // listDonvi
            // 
            this.listDonvi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.listDonvi.FormattingEnabled = true;
            this.listDonvi.ItemHeight = 26;
            this.listDonvi.Items.AddRange(new object[] {
            "",
            "Viên",
            "Vỉ",
            "Chai",
            "Hộp"});
            this.listDonvi.Location = new System.Drawing.Point(528, 146);
            this.listDonvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listDonvi.Name = "listDonvi";
            this.listDonvi.Size = new System.Drawing.Size(244, 30);
            this.listDonvi.TabIndex = 30;
            this.listDonvi.SelectedIndexChanged += new System.EventHandler(this.listDonvi_SelectedIndexChanged);
            // 
            // boxNhomthuoc
            // 
            this.boxNhomthuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxNhomthuoc.Location = new System.Drawing.Point(136, 150);
            this.boxNhomthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxNhomthuoc.MaxLength = 50;
            this.boxNhomthuoc.Name = "boxNhomthuoc";
            this.boxNhomthuoc.Size = new System.Drawing.Size(244, 34);
            this.boxNhomthuoc.TabIndex = 27;
            // 
            // boxTenthuoc
            // 
            this.boxTenthuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTenthuoc.Location = new System.Drawing.Point(136, 93);
            this.boxTenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxTenthuoc.MaxLength = 50;
            this.boxTenthuoc.Name = "boxTenthuoc";
            this.boxTenthuoc.Size = new System.Drawing.Size(244, 34);
            this.boxTenthuoc.TabIndex = 26;
            // 
            // boxSoluong
            // 
            this.boxSoluong.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxSoluong.Location = new System.Drawing.Point(277, 35);
            this.boxSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxSoluong.Name = "boxSoluong";
            this.boxSoluong.Size = new System.Drawing.Size(103, 34);
            this.boxSoluong.TabIndex = 25;
            // 
            // boxMaThuoc
            // 
            this.boxMaThuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxMaThuoc.Location = new System.Drawing.Point(136, 35);
            this.boxMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxMaThuoc.Name = "boxMaThuoc";
            this.boxMaThuoc.ReadOnly = true;
            this.boxMaThuoc.Size = new System.Drawing.Size(46, 34);
            this.boxMaThuoc.TabIndex = 24;
            this.boxMaThuoc.TextChanged += new System.EventHandler(this.boxMaThuoc_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(408, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tên thuốc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nhóm thuốc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã thuốc:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.searchNhomthuoc);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.iconButton4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.searchTenthuoc);
            this.groupBox1.Controls.Add(this.searchMaThuoc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(481, 414);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm Thuốc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtMaThuoc,
            this.txtTenthuoc,
            this.txtNhomThuoc});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(21, 211);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(443, 187);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.HeaderText = "Mã";
            this.txtMaThuoc.MinimumWidth = 6;
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Width = 50;
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.HeaderText = "Tên Thuốc";
            this.txtTenthuoc.MinimumWidth = 6;
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.ReadOnly = true;
            this.txtTenthuoc.Width = 170;
            // 
            // txtNhomThuoc
            // 
            this.txtNhomThuoc.HeaderText = "Nhóm Thuốc";
            this.txtNhomThuoc.MinimumWidth = 6;
            this.txtNhomThuoc.Name = "txtNhomThuoc";
            this.txtNhomThuoc.ReadOnly = true;
            this.txtNhomThuoc.Width = 170;
            // 
            // searchNhomthuoc
            // 
            this.searchNhomthuoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.searchNhomthuoc.Location = new System.Drawing.Point(370, 34);
            this.searchNhomthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchNhomthuoc.Name = "searchNhomthuoc";
            this.searchNhomthuoc.Size = new System.Drawing.Size(87, 34);
            this.searchNhomthuoc.TabIndex = 11;
            this.searchNhomthuoc.TextChanged += new System.EventHandler(this.searchNhomthuoc_TextChanged);
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(158, 127);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(131, 48);
            this.iconButton3.TabIndex = 13;
            this.iconButton3.Text = "Tìm Kiếm";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(326, 127);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(130, 48);
            this.iconButton4.TabIndex = 14;
            this.iconButton4.Text = "Làm Mới";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(226, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhóm Thuốc: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(15, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tên Thuốc: ";
            // 
            // searchTenthuoc
            // 
            this.searchTenthuoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchTenthuoc.Location = new System.Drawing.Point(132, 86);
            this.searchTenthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTenthuoc.Name = "searchTenthuoc";
            this.searchTenthuoc.Size = new System.Drawing.Size(325, 30);
            this.searchTenthuoc.TabIndex = 12;
            this.searchTenthuoc.TextChanged += new System.EventHandler(this.searchTenthuoc_TextChanged);
            // 
            // searchMaThuoc
            // 
            this.searchMaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchMaThuoc.Location = new System.Drawing.Point(132, 34);
            this.searchMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchMaThuoc.Name = "searchMaThuoc";
            this.searchMaThuoc.Size = new System.Drawing.Size(76, 30);
            this.searchMaThuoc.TabIndex = 10;
            this.searchMaThuoc.TextChanged += new System.EventHandler(this.searchMaThuoc_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(15, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "Mã thuốc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxCachdung);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.boxGhichu);
            this.groupBox2.Controls.Add(this.boxHamluong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.boxDongia);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.boxSoluong);
            this.groupBox2.Controls.Add(this.boxNcc);
            this.groupBox2.Controls.Add(this.boxTenthuoc);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.boxMaThuoc);
            this.groupBox2.Controls.Add(this.listDonvi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.boxNhomthuoc);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(487, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(783, 413);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Thuốc";
            // 
            // boxCachdung
            // 
            this.boxCachdung.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxCachdung.FormattingEnabled = true;
            this.boxCachdung.ItemHeight = 26;
            this.boxCachdung.Items.AddRange(new object[] {
            "",
            "Uống",
            "Thoa"});
            this.boxCachdung.Location = new System.Drawing.Point(528, 34);
            this.boxCachdung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCachdung.Name = "boxCachdung";
            this.boxCachdung.Size = new System.Drawing.Size(244, 30);
            this.boxCachdung.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(408, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "Cách dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(13, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ghi chú:";
            // 
            // boxGhichu
            // 
            this.boxGhichu.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxGhichu.Location = new System.Drawing.Point(136, 205);
            this.boxGhichu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxGhichu.MaxLength = 50;
            this.boxGhichu.Multiline = true;
            this.boxGhichu.Name = "boxGhichu";
            this.boxGhichu.Size = new System.Drawing.Size(244, 71);
            this.boxGhichu.TabIndex = 28;
            // 
            // boxHamluong
            // 
            this.boxHamluong.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxHamluong.Location = new System.Drawing.Point(528, 86);
            this.boxHamluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxHamluong.MaxLength = 50;
            this.boxHamluong.Name = "boxHamluong";
            this.boxHamluong.Size = new System.Drawing.Size(244, 34);
            this.boxHamluong.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(408, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Hàm lượng:";
            // 
            // boxDongia
            // 
            this.boxDongia.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxDongia.Location = new System.Drawing.Point(528, 247);
            this.boxDongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxDongia.MaxLength = 20;
            this.boxDongia.Name = "boxDongia";
            this.boxDongia.Size = new System.Drawing.Size(244, 34);
            this.boxDongia.TabIndex = 32;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 50;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(440, 321);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 58);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Sửa ";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnClear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.IconSize = 50;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(637, 321);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 57);
            this.btnClear.TabIndex = 36;
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
            this.btnDelete.Location = new System.Drawing.Point(221, 322);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 57);
            this.btnDelete.TabIndex = 34;
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
            this.btnAdd.Location = new System.Drawing.Point(17, 323);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 57);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(3, 487);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1267, 222);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Thuốc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(487, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(315, 51);
            this.label15.TabIndex = 49;
            this.label15.Text = "QUẢN LÝ THUỐC";
            // 
            // ManagementMedicine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 711);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagementMedicine";
            this.Text = "Quản Lý Thuốc";
            this.Load += new System.EventHandler(this.ManagementMedicine_Load_1);
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
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TextBox boxNcc;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ListBox listDonvi;
    private System.Windows.Forms.TextBox boxNhomthuoc;
    private System.Windows.Forms.TextBox boxTenthuoc;
    private System.Windows.Forms.TextBox boxSoluong;
    private System.Windows.Forms.TextBox boxMaThuoc;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.TextBox searchNhomthuoc;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton iconButton4;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox searchTenthuoc;
    private System.Windows.Forms.TextBox searchMaThuoc;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.GroupBox groupBox2;
    private FontAwesome.Sharp.IconButton btnUpdate;
    private FontAwesome.Sharp.IconButton btnClear;
    private FontAwesome.Sharp.IconButton btnDelete;
    private FontAwesome.Sharp.IconButton btnAdd;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox boxDongia;
    private System.Windows.Forms.TextBox boxHamluong;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox boxGhichu;
    private System.Windows.Forms.ListBox boxCachdung;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtMaThuoc;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtTen;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtNhomThuoc;
    private System.Windows.Forms.DataGridViewTextBoxColumn txtTenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridMathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNhomthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridHamluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCachdung;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridGhichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDongia;
        private System.Windows.Forms.Label label15;
    }
}