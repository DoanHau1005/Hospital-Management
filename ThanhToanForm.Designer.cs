
namespace CuoiKiCDCNPM
{
    partial class ThanhToanForm
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
            this.btnSum = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtThanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaBA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhidichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKhambenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhithuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhiGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDieutri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongchiphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxMaBN = new System.Windows.Forms.TextBox();
            this.boxTenBN = new System.Windows.Forms.TextBox();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.boxSdt = new System.Windows.Forms.TextBox();
            this.boxDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxTongchiphi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.phiBhyt = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label17 = new System.Windows.Forms.Label();
            this.boxPhidieutri = new System.Windows.Forms.TextBox();
            this.btnIn = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.boxPhiGB = new System.Windows.Forms.TextBox();
            this.btnThanhtoan = new FontAwesome.Sharp.IconButton();
            this.label15 = new System.Windows.Forms.Label();
            this.boxPhithuoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.boxPhikham = new System.Windows.Forms.TextBox();
            this.boxDichvu = new System.Windows.Forms.TextBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.boxMaBA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxBHYT = new System.Windows.Forms.TextBox();
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
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSum.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnSum.IconColor = System.Drawing.Color.DarkGreen;
            this.btnSum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSum.IconSize = 50;
            this.btnSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSum.Location = new System.Drawing.Point(475, 320);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(145, 55);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtThanhtoan,
            this.txtMaBN,
            this.txtMaBA,
            this.txtPhidichvu,
            this.txtKhambenh,
            this.txtPhithuoc,
            this.txtPhiGB,
            this.txtDieutri,
            this.txtBHYT,
            this.txtTongchiphi,
            this.txtDatetime});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(5, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 210);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtThanhtoan
            // 
            this.txtThanhtoan.HeaderText = "Mã Thanh Toán";
            this.txtThanhtoan.MinimumWidth = 6;
            this.txtThanhtoan.Name = "txtThanhtoan";
            this.txtThanhtoan.ReadOnly = true;
            this.txtThanhtoan.Width = 175;
            // 
            // txtMaBN
            // 
            this.txtMaBN.HeaderText = "Mã BN";
            this.txtMaBN.MinimumWidth = 6;
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Width = 125;
            // 
            // txtMaBA
            // 
            this.txtMaBA.HeaderText = "Mã BA";
            this.txtMaBA.MinimumWidth = 6;
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.ReadOnly = true;
            this.txtMaBA.Width = 125;
            // 
            // txtPhidichvu
            // 
            this.txtPhidichvu.HeaderText = "Phí Dịch Vụ";
            this.txtPhidichvu.MinimumWidth = 6;
            this.txtPhidichvu.Name = "txtPhidichvu";
            this.txtPhidichvu.ReadOnly = true;
            this.txtPhidichvu.Width = 175;
            // 
            // txtKhambenh
            // 
            this.txtKhambenh.HeaderText = "Phí Khám Bệnh";
            this.txtKhambenh.MinimumWidth = 6;
            this.txtKhambenh.Name = "txtKhambenh";
            this.txtKhambenh.ReadOnly = true;
            this.txtKhambenh.Width = 125;
            // 
            // txtPhithuoc
            // 
            this.txtPhithuoc.HeaderText = "Phí Thuốc";
            this.txtPhithuoc.MinimumWidth = 6;
            this.txtPhithuoc.Name = "txtPhithuoc";
            this.txtPhithuoc.ReadOnly = true;
            this.txtPhithuoc.Width = 165;
            // 
            // txtPhiGB
            // 
            this.txtPhiGB.HeaderText = "Phí Giường Bệnh";
            this.txtPhiGB.MinimumWidth = 6;
            this.txtPhiGB.Name = "txtPhiGB";
            this.txtPhiGB.ReadOnly = true;
            this.txtPhiGB.Width = 175;
            // 
            // txtDieutri
            // 
            this.txtDieutri.HeaderText = "Phí Điều Trị";
            this.txtDieutri.MinimumWidth = 6;
            this.txtDieutri.Name = "txtDieutri";
            this.txtDieutri.ReadOnly = true;
            this.txtDieutri.Width = 125;
            // 
            // txtBHYT
            // 
            this.txtBHYT.HeaderText = "Bảo Hiểm Y Tế";
            this.txtBHYT.MinimumWidth = 6;
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.ReadOnly = true;
            this.txtBHYT.Width = 175;
            // 
            // txtTongchiphi
            // 
            this.txtTongchiphi.HeaderText = "Tổng Chi Phí";
            this.txtTongchiphi.MinimumWidth = 6;
            this.txtTongchiphi.Name = "txtTongchiphi";
            this.txtTongchiphi.ReadOnly = true;
            this.txtTongchiphi.Width = 175;
            // 
            // txtDatetime
            // 
            this.txtDatetime.HeaderText = "Ngày thanh toán";
            this.txtDatetime.MinimumWidth = 6;
            this.txtDatetime.Name = "txtDatetime";
            this.txtDatetime.ReadOnly = true;
            this.txtDatetime.Visible = false;
            this.txtDatetime.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(10, 53);
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
            this.label2.Location = new System.Drawing.Point(10, 108);
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
            this.label3.Location = new System.Drawing.Point(10, 168);
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
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "BHYT:";
            // 
            // boxMaBN
            // 
            this.boxMaBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxMaBN.Location = new System.Drawing.Point(142, 45);
            this.boxMaBN.Name = "boxMaBN";
            this.boxMaBN.ReadOnly = true;
            this.boxMaBN.Size = new System.Drawing.Size(70, 34);
            this.boxMaBN.TabIndex = 10;
            // 
            // boxTenBN
            // 
            this.boxTenBN.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTenBN.Location = new System.Drawing.Point(142, 108);
            this.boxTenBN.Name = "boxTenBN";
            this.boxTenBN.ReadOnly = true;
            this.boxTenBN.Size = new System.Drawing.Size(234, 34);
            this.boxTenBN.TabIndex = 11;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Enabled = false;
            this.radioNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioNam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioNam.Location = new System.Drawing.Point(142, 168);
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
            this.radioNu.Location = new System.Drawing.Point(257, 168);
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
            this.boxSdt.Location = new System.Drawing.Point(142, 341);
            this.boxSdt.Name = "boxSdt";
            this.boxSdt.ReadOnly = true;
            this.boxSdt.Size = new System.Drawing.Size(234, 34);
            this.boxSdt.TabIndex = 25;
            // 
            // boxDiachi
            // 
            this.boxDiachi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxDiachi.Location = new System.Drawing.Point(142, 212);
            this.boxDiachi.Name = "boxDiachi";
            this.boxDiachi.ReadOnly = true;
            this.boxDiachi.Size = new System.Drawing.Size(234, 34);
            this.boxDiachi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(12, 346);
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
            this.label9.Location = new System.Drawing.Point(10, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Địa chỉ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxTongchiphi);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.phiBhyt);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.boxPhidieutri);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.boxPhiGB);
            this.groupBox1.Controls.Add(this.btnThanhtoan);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Controls.Add(this.boxPhithuoc);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.boxPhikham);
            this.groupBox1.Controls.Add(this.boxDichvu);
            this.groupBox1.Controls.Add(this.iconButton3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.boxMaBA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(6, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 410);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // boxTongchiphi
            // 
            this.boxTongchiphi.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxTongchiphi.Location = new System.Drawing.Point(644, 244);
            this.boxTongchiphi.Name = "boxTongchiphi";
            this.boxTongchiphi.ReadOnly = true;
            this.boxTongchiphi.Size = new System.Drawing.Size(187, 30);
            this.boxTongchiphi.TabIndex = 30;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label19.Location = new System.Drawing.Point(476, 251);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 23);
            this.label19.TabIndex = 29;
            this.label19.Text = "Tổng Chi Phí";
            // 
            // phiBhyt
            // 
            this.phiBhyt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.phiBhyt.Location = new System.Drawing.Point(644, 182);
            this.phiBhyt.Name = "phiBhyt";
            this.phiBhyt.ReadOnly = true;
            this.phiBhyt.Size = new System.Drawing.Size(187, 30);
            this.phiBhyt.TabIndex = 27;
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(720, 320);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(111, 55);
            this.iconButton1.TabIndex = 45;
            this.iconButton1.Text = "Thoát";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(476, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 23);
            this.label17.TabIndex = 26;
            this.label17.Text = "Bảo Hiểm Y Tế:";
            // 
            // boxPhidieutri
            // 
            this.boxPhidieutri.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxPhidieutri.Location = new System.Drawing.Point(644, 116);
            this.boxPhidieutri.Name = "boxPhidieutri";
            this.boxPhidieutri.ReadOnly = true;
            this.boxPhidieutri.Size = new System.Drawing.Size(187, 30);
            this.boxPhidieutri.TabIndex = 25;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnIn.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnIn.IconColor = System.Drawing.Color.Black;
            this.btnIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIn.IconSize = 35;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(246, 320);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(131, 55);
            this.btnIn.TabIndex = 44;
            this.btnIn.Text = "In Phiếu";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(476, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 23);
            this.label16.TabIndex = 24;
            this.label16.Text = "Phí Điều Trị:";
            // 
            // boxPhiGB
            // 
            this.boxPhiGB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxPhiGB.Location = new System.Drawing.Point(644, 49);
            this.boxPhiGB.Name = "boxPhiGB";
            this.boxPhiGB.ReadOnly = true;
            this.boxPhiGB.Size = new System.Drawing.Size(187, 30);
            this.boxPhiGB.TabIndex = 23;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhtoan.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnThanhtoan.IconColor = System.Drawing.Color.DarkGreen;
            this.btnThanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhtoan.IconSize = 35;
            this.btnThanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhtoan.Location = new System.Drawing.Point(18, 320);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(145, 55);
            this.btnThanhtoan.TabIndex = 16;
            this.btnThanhtoan.Text = "Thanh Toán";
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(476, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "Phí Giường Bệnh:";
            // 
            // boxPhithuoc
            // 
            this.boxPhithuoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxPhithuoc.Location = new System.Drawing.Point(181, 246);
            this.boxPhithuoc.Name = "boxPhithuoc";
            this.boxPhithuoc.ReadOnly = true;
            this.boxPhithuoc.Size = new System.Drawing.Size(196, 30);
            this.boxPhithuoc.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(15, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Phí Thuốc:";
            // 
            // boxPhikham
            // 
            this.boxPhikham.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxPhikham.Location = new System.Drawing.Point(181, 174);
            this.boxPhikham.Name = "boxPhikham";
            this.boxPhikham.Size = new System.Drawing.Size(196, 30);
            this.boxPhikham.TabIndex = 19;
            // 
            // boxDichvu
            // 
            this.boxDichvu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxDichvu.Location = new System.Drawing.Point(181, 113);
            this.boxDichvu.Name = "boxDichvu";
            this.boxDichvu.Size = new System.Drawing.Size(196, 30);
            this.boxDichvu.TabIndex = 18;
            // 
            // iconButton3
            // 
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(404, 45);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(45, 38);
            this.iconButton3.TabIndex = 17;
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(15, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "Phí Khám Bệnh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(14, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "Phí dịch vụ:";
            // 
            // boxMaBA
            // 
            this.boxMaBA.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.boxMaBA.Location = new System.Drawing.Point(181, 51);
            this.boxMaBA.Name = "boxMaBA";
            this.boxMaBA.Size = new System.Drawing.Size(196, 30);
            this.boxMaBA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã Bệnh Án:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxBHYT);
            this.groupBox2.Controls.Add(this.boxTuoi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.boxDiachi);
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
            this.groupBox2.Location = new System.Drawing.Point(859, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 410);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // boxBHYT
            // 
            this.boxBHYT.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxBHYT.Location = new System.Drawing.Point(142, 276);
            this.boxBHYT.Name = "boxBHYT";
            this.boxBHYT.ReadOnly = true;
            this.boxBHYT.Size = new System.Drawing.Size(234, 34);
            this.boxBHYT.TabIndex = 46;
            // 
            // boxTuoi
            // 
            this.boxTuoi.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.boxTuoi.Location = new System.Drawing.Point(289, 45);
            this.boxTuoi.Name = "boxTuoi";
            this.boxTuoi.ReadOnly = true;
            this.boxTuoi.Size = new System.Drawing.Size(87, 34);
            this.boxTuoi.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(230, 51);
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
            this.groupBox3.Location = new System.Drawing.Point(5, 466);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1267, 244);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hồ sơ Thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(515, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 51);
            this.label5.TabIndex = 46;
            this.label5.Text = "THANH TOÁN";
            // 
            // ThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(205)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1274, 711);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ThanhToanForm";
            this.Text = "Quản Lý Thanh Toán";
            this.Load += new System.EventHandler(this.ThanhToanForm_Load_1);
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
    private FontAwesome.Sharp.IconButton btnSum;
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
    private System.Windows.Forms.TextBox boxDiachi;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private FontAwesome.Sharp.IconButton iconButton3;
    private FontAwesome.Sharp.IconButton btnThanhtoan;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox boxMaBA;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox boxTuoi;
    private FontAwesome.Sharp.IconButton btnIn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox boxPhikham;
        private System.Windows.Forms.TextBox boxDichvu;
        private System.Windows.Forms.TextBox phiBhyt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox boxPhidieutri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox boxPhiGB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boxPhithuoc;
        private System.Windows.Forms.TextBox boxTongchiphi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox boxBHYT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtThanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaBA;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhidichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtKhambenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhithuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhiGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDieutri;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTongchiphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDatetime;
    }
}