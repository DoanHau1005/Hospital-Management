using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class DoctorPanel : Form
    {
        int idnhanvien_user;
        //Tạo biến khởi tạo kết nối DATABASE
        SqlConnection connect;
        SqlCommand command;
        SqlConnection connect2;
        SqlCommand command2;
        SqlCommand command3;
        string str = Properties.Resources.connectString;
        string str2 = Properties.Resources.connectString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataTable table2 = new DataTable();
        // Tạo biến thực hiện chức năng responsive 
        private Rectangle DoctorPanel1;
        private Rectangle Textbox1Rect;
        private Rectangle Textbox1cloneRect;
        private Rectangle Textbox2Rect;
        private Rectangle Textbox4Rect;
        private Rectangle Textbox5Rect;
        private Rectangle Textbox7Rect;
        private Rectangle Textbox10Rect;
        private Rectangle TextboxLidokhamRect;
        private Rectangle Button2Rect;
        private Rectangle Button3Rect;
        private Rectangle Button4Rect;
        private Rectangle CbbBacsiRect;
        private Rectangle Label1Rect;
        private Rectangle Label2Rect;
        private Rectangle Label3Rect;
        private Rectangle Label4Rect;
        private Rectangle Label5Rect;
        private Rectangle Label6Rect;
        private Rectangle Label8Rect;
        private Rectangle Label9Rect;
        private Rectangle Label10Rect;
        private Rectangle Label11Rect;
        private Rectangle Label12Rect;
        private Rectangle Label15Rect;
        private Rectangle GroupBox1Rect;
        private Rectangle GroupBox2Rect;
        private Rectangle GroupBox3Rect;
        private Rectangle DataGView1Rect;
        private Rectangle DataGView2Rect;
        private Rectangle DtpNgayKhamRect;
        private Rectangle DtpNgayTaiKhamRect;
        private Rectangle IconButton5Rect;
        private float Textbox1FontSize;
        private float Textbox1cloneFontSize;
        private float Textbox2FontSize;
        private float Textbox4FontSize;
        private float Textbox5FontSize;
        private float Textbox7FontSize;
        private float Textbox10FontSize;
        private float TextboxLidokhamSize;
        private float GroupBox1FontSize;
        private float GroupBox2FontSize;
        private float GroupBox3FontSize;
        private float CbbBacSiFontSize;
        private float DtpNgayKhamFontSize;
        private float DtpNgayTaiKhamFontSize;
        private float Label1FontSize;
        private float Label2FontSize;
        private float Label3FontSize;
        private float Label4FontSize;
        private float Label5FontSize;
        private float Label6FontSize;
        private float Label8FontSize;
        private float Label9FontSize;
        private float Label10FontSize;
        private float Label11FontSize;
        private float Label12FontSize;
        private float Label15FontSize;
        private float DataGView1FontSize;
        private float DataGView2FontSize;
        private float Button2FontSize;
        private float Button3FontSize;
        private float Button4FontSize;
        private float IconButton5FontSize;
        private float fontScale = 1;

        void Loaddata_benhnhan()
        //Load dữ liệu của bệnh nhân chờ khám vào datagidview
        {
            command = connect.CreateCommand();
            command.CommandText = "select * from tBenhNhan where trangthai is NULL and bacsikham = (select hoten from hosonhanvien where  idnhanvien_user = '" + idnhanvien_user + "')";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }
        void Loaddata_benhnhanDone()
        //Load dữ liệu của bệnh nhân đã khám vào datagidview
        {
            command2 = connect2.CreateCommand();
            command2.CommandText = "select * from tBenhNhanDone where bacsikham = (select hoten from hosonhanvien where  idnhanvien_user = '" + idnhanvien_user + "')";
            adapter2.SelectCommand = command2;
            table2.Clear();
            adapter2.Fill(table2);
            dataGridView1.DataSource = table2;
        }
        public DoctorPanel(int account_user_id)
        {
            InitializeComponent();
            idnhanvien_user = account_user_id;
        }
        private void button2_Click(object sender, EventArgs e)
        //Chức năng thêm bệnh nhân chưa khám vào bảng đã khám
        {
            DialogResult result = MessageBox.Show("Bạn có muốn THÊM không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
           //Tạo các điều kiện kiểm tra tác vụ nhập của người dùng
            {
                if (txtLyDoKham.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Lý do khám !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLyDoKham.Focus();
                }
                else if (txtXetNghiem.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Yêu cầu xét nghiệm !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXetNghiem.Focus();
                }
                else if (txtChuanDoan.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chuẩn đoán !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChuanDoan.Focus();
                }

                else if (txtGhiChu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Ghi chú !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGhiChu.Focus();
                }

                else if (txtTienKham.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Tiền Khám !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTienKham.Focus();
                }
                else
                {
                    command3 = connect.CreateCommand();
                    command3.CommandText = "insert into tBenhNhanDone values ( '" + txtMaBN.Text + "',"
                                                                            + "'" + txtMaBA.Text + "',"
                                                                            + "'" + dtpNgayKham.Text + "',"
                                                                            + "'" + dtpNgayTaiKham.Text + "',"
                                                                            + "N'" + txtHoTen.Text + "',"
                                                                            + "'" + txtTuoi.Text + "',"
                                                                            + "N'" + txtgioitinh.Text + "',"
                                                                            + "N'" + txtnghenghiep.Text + "',N'"
                                                                            + txtdiachi.Text + "',N'"
                                                                            + txtsdt.Text + "',N'"
                                                                            + txtLyDoKham.Text + "',N'"
                                                                            + txtXetNghiem.Text + "' ,N'"
                                                                            + txtChuanDoan.Text + "' ,N'"
                                                                            + txtPhong.Text + "' ,N'"
                                                                            + txtBHYT.Text + "' ,"
                                                                            + "N'" + cbbBacSiKham.Text + "',N'"
                                                                            + txtGhiChu.Text + "','"
                                                                            + txtTienKham.Text + "','"
                                                                            + txtMaDT.Text + "')";
                    command3.ExecuteNonQuery();
                    command = connect.CreateCommand();
                    /*Sau khi thêm xong đổi trạng thái bệnh nhân thành 'xong', dữ liệu bệnh nhân khi hiển thị 
                   sẽ được chuyển xuống Datagridview hiện bệnh nhân đã  khám*/
                    command.CommandText = "update tBenhNhan set trangthai = '" + "xong" + "' where maBN = '" + txtMaBN.Text + "'";
                    command.ExecuteNonQuery();
                    Loaddata_benhnhanDone();
                    Loaddata_benhnhan();
                }
            }
            else
            {
                MessageBox.Show("Đã hủy tác vụ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        // Truyền dữ liệu vào những ô textbox khi click vào DataGridView
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaBN.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtMaBA.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtLyDoKham.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            dtpNgayKham.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtpNgayTaiKham.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[i].Cells[18].Value.ToString();
            txtChuanDoan.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
            txtXetNghiem.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
            txtTienKham.Text = dataGridView1.Rows[i].Cells[19].Value.ToString();
            cbbBacSiKham.Text = dataGridView1.Rows[i].Cells[17].Value.ToString();
            txtPhong.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            txtBHYT.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
            txtMaDT.Text = dataGridView1.Rows[i].Cells[20].Value.ToString();
        }
       
        private void button3_Click(object sender, EventArgs e)
        /*Chức năng Sửa thông tin bệnh nhân*/
        {
            DialogResult result = MessageBox.Show("Bạn có muốn SỬA không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            //Tạo các điều kiện kiểm tra tác vụ nhập của người dùng
            {
                if (txtXetNghiem.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Yêu cầu xét nghiệm !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtXetNghiem.Focus();
                }
                else if (txtChuanDoan.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chuẩn đoán !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChuanDoan.Focus();
                }
                else if (txtGhiChu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Ghi chú !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGhiChu.Focus();
                }
                else if (txtTienKham.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Tiền Khám !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTienKham.Focus();
                }
                else
                {
                    command2 = connect2.CreateCommand();
                    command2.CommandText = "update tBenhNhanDone set ngaytaikham = '" + dtpNgayTaiKham.Text + "', " +
                                                    "lydokham =  N'" + txtLyDoKham.Text + "', " +
                                                    "xetnghiem = N'" + txtXetNghiem.Text + "'," +
                                                    "chuandoan =N'" + txtChuanDoan.Text + "'," +
                                                    "ghichu =N'" + txtGhiChu.Text + "'," +
                                                    "tienkham ='" + txtTienKham.Text + "'" +
                                                    "where maBN = '" + txtMaBN.Text + "'";
                    command2.ExecuteNonQuery();
                    Loaddata_benhnhanDone();
                }
            }
            else
            {
                MessageBox.Show("Đã HỦY tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)  
        {
            /*Tại ô số tiền khám chặn không cho người dùng nhập chữ, chỉ được nhập số*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
            /*Truyền dữ liệu vào các ô textbox khi click vào Datagridview*/
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtMaBN.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtMaBA.Text = "SIDA" + dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cbbBacSiKham.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            txtLyDoKham.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            dtpNgayKham.Text = dataGridView2.Rows[i].Cells[11].Value.ToString();
            txtdiachi.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txtgioitinh.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txtnghenghiep.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txtTuoi.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txtsdt.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txtPhong.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txtBHYT.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            txtMaDT.Text = "DT" + dataGridView2.Rows[i].Cells[0].Value.ToString();
            txtXetNghiem.Text = "";
            txtChuanDoan.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Khởi tạo các biến lưu trữ dữ liệu các thuộc tính để truyền sang form đơn thuốc
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {
                String maBN = "";
                String hoten = "";
                String tuoi = "";
                String gioitinh = "";
                String diachi = "";
                String xetnghiem = "";
                String chuandoan = "";
                String bacsikham = "";
                String ghichu = "";
                String maDT = "";
                if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    maBN = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    hoten = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    tuoi = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    gioitinh = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    diachi = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    xetnghiem = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
                    chuandoan = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
                    bacsikham = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
                    ghichu = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
                    maDT = dataGridView1.Rows[e.RowIndex].Cells[20].Value.ToString();
                }
                //truyền các biến từ form bác sĩ sang form đơn thuốc
                DonThuocForm donthuoc_form = new DonThuocForm(maBN, hoten, tuoi, gioitinh, diachi, xetnghiem, chuandoan, bacsikham, ghichu, maDT);
                donthuoc_form.Show();
            }
        }
        
        private void DoctorPanel_Load_1(object sender, EventArgs e)
        //Chức năng responsive 
        {
            this.tBenhNhanTableAdapter1.Fill(this.cuoikicdDataSet11.tBenhNhan);
            connect = new SqlConnection(str);
            connect.Open();
            Loaddata_benhnhan();
            this.tBenhNhanDoneTableAdapter3.Fill(this.cuoikicdDataSet23.tBenhNhanDone);
            connect2 = new SqlConnection(str2);
            connect2.Open();
            Loaddata_benhnhanDone();
            DoctorPanel1 = new Rectangle(this.Location, this.Size);
            Textbox1Rect = new Rectangle(txtHoTen.Location, txtHoTen.Size);
            Textbox1cloneRect = new Rectangle(txtMaBN.Location, txtMaBN.Size);
            Textbox2Rect = new Rectangle(txtMaBA.Location, txtMaBA.Size);
            Textbox4Rect = new Rectangle(txtXetNghiem.Location, txtXetNghiem.Size);
            Textbox5Rect = new Rectangle(txtChuanDoan.Location, txtChuanDoan.Size);
            Textbox7Rect = new Rectangle(txtGhiChu.Location, txtGhiChu.Size);
            TextboxLidokhamRect = new Rectangle(txtLyDoKham.Location, txtLyDoKham.Size);
            Textbox10Rect = new Rectangle(txtTienKham.Location, txtTienKham.Size);
            Label1Rect = new Rectangle(label1.Location, label1.Size);
            Label2Rect = new Rectangle(label2.Location, label2.Size);
            Label3Rect = new Rectangle(label3.Location, label3.Size);
            Label4Rect = new Rectangle(label4.Location, label4.Size);
            Label5Rect = new Rectangle(label5.Location, label5.Size);
            Label6Rect = new Rectangle(label6.Location, label6.Size);
            Label8Rect = new Rectangle(label8.Location, label8.Size);
            Label9Rect = new Rectangle(label9.Location, label9.Size);
            Label10Rect = new Rectangle(label10.Location, label10.Size);
            Label11Rect = new Rectangle(label11.Location, label11.Size);
            Label12Rect = new Rectangle(label12.Location, label12.Size);
            Label15Rect = new Rectangle(label15.Location, label15.Size);
            DtpNgayKhamRect = new Rectangle(dtpNgayKham.Location, dtpNgayKham.Size);
            DtpNgayTaiKhamRect = new Rectangle(dtpNgayTaiKham.Location, dtpNgayTaiKham.Size);
            GroupBox1Rect = new Rectangle(groupBox1.Location, groupBox1.Size);
            GroupBox2Rect = new Rectangle(groupBox2.Location, groupBox2.Size);
            GroupBox3Rect = new Rectangle(groupBox3.Location, groupBox3.Size);
            DataGView1Rect = new Rectangle(dataGridView1.Location, dataGridView1.Size);
            DataGView2Rect = new Rectangle(dataGridView2.Location, dataGridView2.Size);
            Button2Rect = new Rectangle(btnKhoiTao.Location, btnKhoiTao.Size);
            Button3Rect = new Rectangle(btnCapNhat.Location, btnCapNhat.Size);
            Button4Rect = new Rectangle(btnLamMoi.Location, btnLamMoi.Size);
            IconButton5Rect = new Rectangle(btnThoat.Location, btnThoat.Size);
            CbbBacsiRect = new Rectangle(cbbBacSiKham.Location, cbbBacSiKham.Size);
            DtpNgayKhamFontSize = dtpNgayKham.Font.Size;
            DtpNgayTaiKhamFontSize = dtpNgayTaiKham.Font.Size;
            Textbox1FontSize = txtHoTen.Font.Size;
            Textbox1cloneFontSize = txtMaBN.Font.Size;
            Textbox2FontSize = txtMaBA.Font.Size;
            TextboxLidokhamSize = txtLyDoKham.Font.Size;
            Textbox4FontSize = txtXetNghiem.Font.Size;
            Textbox5FontSize = txtChuanDoan.Font.Size;
            Textbox7FontSize = txtGhiChu.Font.Size;
            Textbox10FontSize = txtTienKham.Font.Size;
            Label1FontSize = label1.Font.Size;
            Label2FontSize = label2.Font.Size;
            Label3FontSize = label3.Font.Size;
            Label4FontSize = label4.Font.Size;
            Label5FontSize = label5.Font.Size;
            Label6FontSize = label6.Font.Size;
            Label8FontSize = label8.Font.Size;
            Label9FontSize = label9.Font.Size;
            Label10FontSize = label10.Font.Size;
            Label11FontSize = label11.Font.Size;
            Label12FontSize = label12.Font.Size;
            Label15FontSize = label15.Font.Size;
            CbbBacSiFontSize = cbbBacSiKham.Font.Size;
            GroupBox1FontSize = groupBox1.Font.Size;
            GroupBox2FontSize = groupBox2.Font.Size;
            GroupBox3FontSize = groupBox3.Font.Size;
            DataGView1FontSize = dataGridView1.Font.Size;
            DataGView2FontSize = dataGridView2.Font.Size;
            Button2FontSize = btnKhoiTao.Font.Size;
            Button3FontSize = btnCapNhat.Font.Size;
            Button4FontSize = btnLamMoi.Font.Size;
            IconButton5FontSize = btnThoat.Font.Size;
        }
        private void DoctorPanel_Resize(object sender, EventArgs e)
        //Chức năng responsive 
        {
            ResizeChildrenControl();
        }
        
        private void ResizeChildrenControl()
        //Chức năng responsive 
        {
            ResizeControl(label1, Label1Rect, Label1FontSize);
            ResizeControl(groupBox1, GroupBox1Rect, GroupBox1FontSize);
            ResizeControl(groupBox2, GroupBox2Rect, GroupBox2FontSize);
            ResizeControl(groupBox3, GroupBox3Rect, GroupBox3FontSize);
            ResizeControl(dataGridView1, DataGView1Rect, DataGView1FontSize);
            ResizeControl(dataGridView2, DataGView2Rect, DataGView2FontSize);
            ResizeControl(btnKhoiTao, Button2Rect, Button2FontSize);
            ResizeControl(btnCapNhat, Button3Rect, Button3FontSize);
            ResizeControl(btnLamMoi, Button4Rect, Button4FontSize);
            ResizeControl(btnThoat, IconButton5Rect, IconButton5FontSize);
            ResizeControl(label4, Label4Rect, Label4FontSize);
            ResizeControl(label2, Label2Rect, Label2FontSize);
            ResizeControl(label3, Label3Rect, Label3FontSize);
            ResizeControl(label5, Label5Rect, Label5FontSize);
            ResizeControl(label6, Label6Rect, Label6FontSize);
            ResizeControl(label8, Label8Rect, Label8FontSize);
            ResizeControl(label9, Label9Rect, Label9FontSize);
            ResizeControl(label10, Label10Rect, Label10FontSize);
            ResizeControl(label11, Label11Rect, Label11FontSize);
            ResizeControl(label12, Label12Rect, Label12FontSize);
            ResizeControl(label15, Label15Rect, Label15FontSize);
            ResizeControl(txtHoTen, Textbox1Rect, Textbox1FontSize);
            ResizeControl(txtMaBN, Textbox1cloneRect, Textbox1cloneFontSize);
            ResizeControl(txtMaBA, Textbox2Rect, Textbox2FontSize);
            ResizeControl(txtLyDoKham, TextboxLidokhamRect, TextboxLidokhamSize);
            ResizeControl(txtXetNghiem, Textbox4Rect, Textbox4FontSize);
            ResizeControl(txtChuanDoan, Textbox5Rect, Textbox5FontSize);
            ResizeControl(txtGhiChu, Textbox7Rect, Textbox7FontSize);
            ResizeControl(txtTienKham, Textbox10Rect, Textbox10FontSize);
            ResizeControl(cbbBacSiKham, CbbBacsiRect, CbbBacSiFontSize);
            ResizeControl(dtpNgayTaiKham, DtpNgayTaiKhamRect, DtpNgayTaiKhamFontSize);
            ResizeControl(dtpNgayKham, DtpNgayKhamRect, DtpNgayKhamFontSize);

        }
        
        private void ResizeControl(Control control, Rectangle ControlRect, float FontSize)
        //Chức năng responsive 
        {
            float xRatio = (float)this.ClientRectangle.Width / DoctorPanel1.Width;
            float yRatio = (float)this.ClientRectangle.Height / DoctorPanel1.Height;
            float newX = ControlRect.Location.X * xRatio;
            float newY = ControlRect.Location.Y * yRatio;
            control.Location = new Point((int)newX, (int)newY);
            control.Width = (int)(ControlRect.Width * xRatio);
            control.Height = (int)(ControlRect.Height * yRatio);
            float ratio = xRatio;
            if (xRatio >= yRatio)
            {
                ratio = yRatio;
            }
            float newFontSize = FontSize * ratio * fontScale;
            
        }



        
        private void button4_Click(object sender, EventArgs e)
        //Chức năng làm mới - làm trống dữ liệu trong các ô textbox
        {
            txtHoTen.Text = "";
            txtMaBN.Text = "";
            txtMaBA.Text = "";
            txtLyDoKham.Text = "";
            txtXetNghiem.Text = "";
            txtChuanDoan.Text = "";
            cbbBacSiKham.Text = "";
            txtGhiChu.Text = "";
            txtTienKham.Text = "";
        }
       
        private void iconButton2_Click(object sender, EventArgs e)
        //Chức năng đăng xuất, quay lại form Đăng nhập
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
