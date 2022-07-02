using CuoiKiCDCNPM.DonThuoc;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class DonThuocForm : Form
    {
        String Id;
        public DonThuocForm(String maBN, String hoten, String tuoi, String gioitinh, String diachi, String xetnghiem, String chuandoan, String bacsikham, String ghichu, String maDT)
        //Lấy các thuộc tính từ bảng Bác sĩ 
        {
            InitializeComponent();
            Id = maBN;
            this.txtMaBN.Text = Id.ToString();
            this.txtHoten.Text = hoten.ToString();
            this.txtTuoi.Text = tuoi.ToString();
            this.ccbGioiTinh.Text = gioitinh.ToString();
            this.txtDiaChi.Text = diachi.ToString();
            this.txtXetNghiem.Text = xetnghiem.ToString();
            this.txtChuanDoan.Text = chuandoan.ToString();
            this.ccbBacSiKham.Text = bacsikham.ToString();
            this.txtGhiChu.Text = ghichu.ToString();
            this.txtMaDonThuoc.Text = maDT.ToString();
            loadThuoc();
        }
        //Khởi tạo các biến để kết nối DATABSE
        SqlConnection connect;
        SqlCommand command;
        string str = Properties.Resources.connectString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //Khởi tạo các biến để xử lý tính năng responsive
        private Rectangle FormDonThuoc1;
        private Rectangle comboBox1Rect;
        private Rectangle comboBox2Rect;
        private Rectangle comboBox3Rect;
        private float comboBox1FontSize;
        private float comboBox2FontSize;
        private float comboBox3FontSize;
        private Rectangle dgv1Rect;
        private float dgv1FontSize;
        private Rectangle datetimepicker1Rect;
        private float datetimepickerFontSize;
        private Rectangle groupBox1Rect;
        private Rectangle groupBox2Rect;
        private Rectangle groupBox3Rect;
        private float groupBox1FontSize;
        private float groupBox2FontSize;
        private float groupBox3FontSize;
        private Rectangle button4Rect;
        private Rectangle button5Rect;
        private Rectangle button6Rect;
        private Rectangle button7Rect;
        private Rectangle button8Rect;
        private Rectangle button9Rect;
        private float button4FontSize;
        private float button5FontSize;
        private float button6FontSize;
        private float button7FontSize;
        private float button8FontSize;
        private float button9FontSize;
        private Rectangle Label1Rect;
        private Rectangle Label2Rect;
        private Rectangle Label3Rect;
        private Rectangle Label4Rect;
        private Rectangle Label5Rect;
        private Rectangle Label6Rect;
        private Rectangle Label7Rect;
        private Rectangle Label8Rect;
        private Rectangle Label9Rect;
        private Rectangle Label10Rect;
        private Rectangle Label11Rect;
        private Rectangle Label12Rect;
        private Rectangle Label13Rect;
        private Rectangle Label15Rect;
        private Rectangle Label16Rect;
        private float Label1FontSize;
        private float Label2FontSize;
        private float Label3FontSize;
        private float Label4FontSize;
        private float Label5FontSize;
        private float Label6FontSize;
        private float Label7FontSize;
        private float Label8FontSize;
        private float Label9FontSize;
        private float Label10FontSize;
        private float Label11FontSize;
        private float Label12FontSize;
        private float Label13FontSize;
        private float Label15FontSize;
        private float Label16FontSize;
        private Rectangle numberric1Rect;
        private float numberric1FontSize;
        private Rectangle Textbox1Rect;
        private Rectangle Textbox2Rect;
        private Rectangle Textbox3Rect;
        private Rectangle Textbox4Rect;
        private Rectangle Textbox5Rect;
        private Rectangle Textbox6Rect;
        private Rectangle Textbox7Rect;
        private Rectangle Textbox8Rect;
        private Rectangle Textbox10Rect;
        private float Textbox1FontSize;
        private float Textbox2FontSize;
        private float Textbox3FontSize;
        private float Textbox4FontSize;
        private float Textbox5FontSize;
        private float Textbox6FontSize;
        private float Textbox7FontSize;
        private float Textbox8FontSize;
        private float Textbox10FontSize;
        private Rectangle ComboBox4Rect;
        private float ComboBox4FontSize;
        private float fontScale = 1;
        void tongtienthuoc() 
         //Tính tổng tiền thuốc
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[16].Value);
            }
            txtTongTienThuoc.Text = sum.ToString();
        }
        void loadThuoc()
            //Truyền dữ liệu từ bảng Thuốc
        {
            SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
            cnn.Open();
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = "Select * from Thuoc";

            SqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    ccbTenThuoc.Items.Add((reader.GetValue(1)).ToString());
                }
            }
            reader.Close();
            cnn.Close();
        }
        private void ccbTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
            //Lấy dữ liệu từ bảng Thuốc sang Đơn thuốc
        {
            if (!String.IsNullOrEmpty(ccbTenThuoc.SelectedItem.ToString()))
            {
                String tenthuoc = ccbTenThuoc.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "Select * from dbo.Thuoc where tenThuoc = N'" + tenthuoc.Trim() +"'";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Thuoc");
                foreach (DataRow row in ds.Tables["Thuoc"].Rows)
                {
                    ccbDonVi.Text = row["donvi"].ToString();
                    txtCachDung.Text = row["cachdung"].ToString();
                    numberSL.Text = row["soluong"].ToString();
                    txtMaThuoc.Text = row["ID"].ToString();
                    txtDongia.Text = row["dongia"].ToString();
                }
                con.Close();

            }
        }
        void Loaddata_donthuoc()
            //Load dữ liệu đơn thuốc
        {
            command = connect.CreateCommand();
            command.CommandText = "select * from donthuoc where maBN = @id";
            command.Parameters.AddWithValue("@id", Id);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void DonThuocForm_Load(object sender, EventArgs e)
        //Tính năng responsive
        {
            this.donthuocTableAdapter2.Fill(this.cuoikicdDataSet31.donthuoc);
            connect = new SqlConnection(str);
            connect.Open();
            Loaddata_donthuoc();
            tongtienthuoc();
            FormDonThuoc1 = new Rectangle(this.Location, this.Size);
            comboBox1Rect = new Rectangle(ccbGioiTinh.Location, ccbGioiTinh.Size);
            comboBox2Rect = new Rectangle(ccbBacSiKham.Location, ccbBacSiKham.Size);
            comboBox3Rect = new Rectangle(ccbTenThuoc.Location, ccbTenThuoc.Size);
            comboBox1FontSize = ccbGioiTinh.Font.Size;
            comboBox2FontSize = ccbBacSiKham.Font.Size;
            comboBox3FontSize = ccbTenThuoc.Font.Size;
            dgv1Rect = new Rectangle(dataGridView1.Location, dataGridView1.Size);
            dgv1FontSize = dataGridView1.Font.Size;
            datetimepicker1Rect = new Rectangle(dateTimePickNgayKeDon.Location, dateTimePickNgayKeDon.Size);
            datetimepickerFontSize = dateTimePickNgayKeDon.Font.Size;
            groupBox1Rect = new Rectangle(groupBox1.Location, groupBox1.Size);
            groupBox2Rect = new Rectangle(groupBox2.Location, groupBox2.Size);
            groupBox3Rect = new Rectangle(groupBox3.Location, groupBox3.Size);
            groupBox1FontSize = groupBox1.Font.Size;
            groupBox2FontSize = groupBox2.Font.Size;
            groupBox3FontSize = groupBox3.Font.Size;
            button4Rect = new Rectangle(btnInDonThuoc.Location, btnInDonThuoc.Size);
            button5Rect = new Rectangle(btnThoat.Location, btnThoat.Size);
            button6Rect = new Rectangle(btnThem.Location, btnThem.Size);
            button7Rect = new Rectangle(btnLuu.Location, btnLuu.Size);
            button8Rect = new Rectangle(btnXoa.Location, btnXoa.Size);
            button9Rect = new Rectangle(btnLamMoi.Location, btnLamMoi.Size);
            button4FontSize = btnInDonThuoc.Font.Size;
            button5FontSize = btnThoat.Font.Size;
            button6FontSize = btnThem.Font.Size;
            button7FontSize = btnLuu.Font.Size;
            button8FontSize = btnXoa.Font.Size;
            button9FontSize = btnLamMoi.Font.Size;
            Label1Rect = new Rectangle(label1.Location, label1.Size);
            Label2Rect = new Rectangle(label2.Location, label2.Size);
            Label3Rect = new Rectangle(label3.Location, label3.Size);
            Label4Rect = new Rectangle(label4.Location, label4.Size);
            Label5Rect = new Rectangle(label5.Location, label5.Size);
            Label6Rect = new Rectangle(label6.Location, label6.Size);
            Label7Rect = new Rectangle(label7.Location, label7.Size);
            Label8Rect = new Rectangle(label8.Location, label8.Size);
            Label9Rect = new Rectangle(label9.Location, label9.Size);
            Label10Rect = new Rectangle(label10.Location, label10.Size);
            Label11Rect = new Rectangle(label11.Location, label11.Size);
            Label12Rect = new Rectangle(label12.Location, label12.Size);
            Label13Rect = new Rectangle(label13.Location, label13.Size);
            Label15Rect = new Rectangle(label15.Location, label15.Size);
            Label16Rect = new Rectangle(label16.Location, label16.Size);
            Label1FontSize = label1.Font.Size;
            Label2FontSize = label2.Font.Size;
            Label3FontSize = label3.Font.Size;
            Label4FontSize = label4.Font.Size;
            Label5FontSize = label5.Font.Size;
            Label6FontSize = label6.Font.Size;
            Label7FontSize = label7.Font.Size;
            Label8FontSize = label8.Font.Size;
            Label9FontSize = label9.Font.Size;
            Label10FontSize = label10.Font.Size;
            Label11FontSize = label11.Font.Size;
            Label12FontSize = label12.Font.Size;
            Label13FontSize = label13.Font.Size;
            Label16FontSize = label16.Font.Size;
            numberric1Rect = new Rectangle(numberSL.Location, numberSL.Size);
            numberric1FontSize = numberSL.Font.Size;
            Textbox1Rect = new Rectangle(txtHoten.Location, txtHoten.Size);
            Textbox2Rect = new Rectangle(txtTuoi.Location, txtTuoi.Size);
            Textbox3Rect = new Rectangle(txtDiaChi.Location, txtTuoi.Size);
            Textbox4Rect = new Rectangle(txtGhiChu.Location, txtGhiChu.Size);
            Textbox5Rect = new Rectangle(txtChuanDoan.Location, txtChuanDoan.Size);
            Textbox6Rect = new Rectangle(txtXetNghiem.Location, txtXetNghiem.Size);
            Textbox7Rect = new Rectangle(txtMaDonThuoc.Location, txtMaDonThuoc.Size);
            Textbox8Rect = new Rectangle(txtCachDung.Location, txtCachDung.Size);
            Textbox10Rect = new Rectangle(txtDongia.Location, txtDongia.Size);
            Textbox1FontSize = txtHoten.Font.Size;
            Textbox1FontSize = txtHoten.Font.Size;
            Textbox2FontSize = txtTuoi.Font.Size;
            Textbox3FontSize = txtDiaChi.Font.Size;
            Textbox4FontSize = txtGhiChu.Font.Size;
            Textbox5FontSize = txtChuanDoan.Font.Size;
            Textbox6FontSize = txtXetNghiem.Font.Size;
            Textbox7FontSize = txtMaDonThuoc.Font.Size;
            Textbox8FontSize = txtCachDung.Font.Size;
            Textbox10FontSize = txtDongia.Font.Size;
            ComboBox4Rect = new Rectangle(ccbDonVi.Location, ccbDonVi.Size);
            ComboBox4FontSize = ccbDonVi.Font.Size;
        }
        private void DonThuocForm_Resize(object sender, EventArgs e)
        //Tính năng responsive
        {
            ResizeChildrenControl();
        }
        private void ResizeChildrenControl()
        //Tính năng responsive
        {
            ResizeControl(ccbGioiTinh, comboBox1Rect, comboBox1FontSize);
            ResizeControl(ccbBacSiKham, comboBox2Rect, comboBox2FontSize);
            ResizeControl(ccbTenThuoc, comboBox3Rect, comboBox3FontSize);
            ResizeControl(dataGridView1, dgv1Rect, dgv1FontSize);
            ResizeControl(dateTimePickNgayKeDon, datetimepicker1Rect, datetimepickerFontSize);
            ResizeControl(groupBox1, groupBox1Rect, groupBox1FontSize);
            ResizeControl(groupBox2, groupBox2Rect, groupBox2FontSize);
            ResizeControl(groupBox3, groupBox3Rect, groupBox3FontSize);
            ResizeControl(btnInDonThuoc, button4Rect, button4FontSize);
            ResizeControl(btnThoat, button5Rect, button5FontSize);
            ResizeControl(btnThem, button6Rect, button6FontSize);
            ResizeControl(btnLuu, button7Rect, button7FontSize);
            ResizeControl(btnXoa, button8Rect, button8FontSize);
            ResizeControl(btnLamMoi, button9Rect, button9FontSize);
            ResizeControl(label1, Label1Rect, Label1FontSize);
            ResizeControl(label2, Label2Rect, Label2FontSize);
            ResizeControl(label3, Label3Rect, Label3FontSize);
            ResizeControl(label4, Label4Rect, Label4FontSize);
            ResizeControl(label5, Label5Rect, Label5FontSize);
            ResizeControl(label6, Label6Rect, Label6FontSize);
            ResizeControl(label7, Label7Rect, Label7FontSize);
            ResizeControl(label8, Label8Rect, Label8FontSize);
            ResizeControl(label9, Label9Rect, Label9FontSize);
            ResizeControl(label10, Label10Rect, Label10FontSize);
            ResizeControl(label11, Label11Rect, Label11FontSize);
            ResizeControl(label12, Label12Rect, Label12FontSize);
            ResizeControl(label13, Label13Rect, Label13FontSize);
            ResizeControl(label15, Label15Rect, Label15FontSize);
            ResizeControl(label16, Label16Rect, Label16FontSize);
            ResizeControl(numberSL, numberric1Rect, numberric1FontSize);
            ResizeControl(txtHoten, Textbox1Rect, Textbox1FontSize);
            ResizeControl(txtTuoi, Textbox2Rect, Textbox2FontSize);
            ResizeControl(txtDiaChi, Textbox3Rect, Textbox3FontSize);
            ResizeControl(txtGhiChu, Textbox4Rect, Textbox4FontSize);
            ResizeControl(txtChuanDoan, Textbox5Rect, Textbox5FontSize);
            ResizeControl(txtXetNghiem, Textbox6Rect, Textbox6FontSize);
            ResizeControl(txtMaDonThuoc, Textbox7Rect, Textbox7FontSize);
            ResizeControl(txtCachDung, Textbox8Rect, Textbox8FontSize);
            ResizeControl(txtDongia, Textbox10Rect, Textbox10FontSize);
            ResizeControl(ccbDonVi, ComboBox4Rect, ComboBox4FontSize);

        }
        private void ResizeControl(Control control, Rectangle ControlRect, float FontSize)
            //Tính năng responsive
        {
            float xRatio = (float)this.ClientRectangle.Width / FormDonThuoc1.Width;
            float yRatio = (float)this.ClientRectangle.Height / FormDonThuoc1.Height;
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
        private void iconButton5_Click(object sender, EventArgs e)
            //Đóng form đơn thuốc
        {
            this.Close();
        }
        private void iconButton9_Click(object sender, EventArgs e)
            //Chức năng làm mới
        {
            txtMaDonThuoc.Text = "";
            ccbTenThuoc.Text = "";
            ccbGioiTinh.Text = "";
            numberSL.Text = "";
            txtCachDung.Text = "";
            txtDongia.Text = "";
            dateTimePickNgayKeDon.Text = "";
            tongtienthuoc();
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            //Kiểm tra id thuốc đã tồn tại hay chưa = dacheck
            SqlDataAdapter dacheck = new SqlDataAdapter("select idthuoc from donthuoc where idthuoc = '" + txtMaThuoc.Text + "'", connect);
            DataTable dtcheck = new DataTable();
            dacheck.Fill(dtcheck);
            DialogResult result = MessageBox.Show("Bạn có muốn THÊM không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
                //Khởi tạo điều kiện kiểm tra tác vụ nhập của người dùng
            {

                if (numberSL.Text == "0")
                {
                    MessageBox.Show("Nhập số lượng !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numberSL.Focus();
                }
                else if (txtCachDung.Text == "")
                {
                    MessageBox.Show("Nhập thiếu cách dùng thuốc !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCachDung.Focus();
                }
                else if (dtcheck.Rows.Count >= 1)
                {
                    MessageBox.Show("Thuốc này đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ccbTenThuoc.Focus();
                }
                else if (txtDongia.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Tiền thuốc !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDongia.Focus();
                }
                else
                {
                    //khởi tạo biến xử lý tiền thuốc, lấy số lượng x đơn giá = tiền thuốc
                    decimal a, b;
                    a = Decimal.Parse(numberSL.Text);
                    b = Decimal.Parse(txtDongia.Text);
                    txtTienThuoc.Text = (a * b).ToString();
                    command = connect.CreateCommand();
                    command.CommandText = "insert into donthuoc values (N'" + txtMaBN.Text + "'," 
                                                                       + "N'" + txtHoten.Text + "'," 
                                                                       + "N'" + txtTuoi.Text + "'," 
                                                                       + "N'" + ccbGioiTinh.Text + "'," 
                                                                       + "N'" + txtDiaChi.Text + "'," 
                                                                       + "N'" + txtXetNghiem.Text + "'," 
                                                                       + "N'" + txtChuanDoan.Text + "',"
                                                                       + "N'" + ccbBacSiKham.Text + "',"
                                                                       + "N'" + txtGhiChu.Text + "',"
                                                                       + "N'" + txtMaThuoc.Text + "',"
                                                                       + "N'" + ccbTenThuoc.Text + "',"
                                                                       + "N'" + numberSL.Text + "'," 
                                                                       + "N'" + ccbDonVi.Text + "',"
                                                                       + "N'" + txtCachDung.Text + "',"
                                                                       + "N'" + txtDongia.Text + "',"
                                                                       + "N'" + txtTienThuoc.Text + "',"
                                                                       + "N'" + DateTime.Now + "')";
                    command.ExecuteNonQuery();
                    Loaddata_donthuoc();
                    tongtienthuoc();
                }
            }
            else
            {
                MessageBox.Show("Đã hủy tác vụ !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            //Truyền dữ liệu từ datagridview vào các ô textbox
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            ccbTenThuoc.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
            numberSL.Text = dataGridView1.Rows[i].Cells[12].Value.ToString();
            ccbDonVi.Text = dataGridView1.Rows[i].Cells[13].Value.ToString();
            txtCachDung.Text = dataGridView1.Rows[i].Cells[14].Value.ToString();
            txtDongia.Text = dataGridView1.Rows[i].Cells[15].Value.ToString();
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chặn người dùng không được nhập chữ trong ô tiền thuốc
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void iconButton7_Click(object sender, EventArgs e)
        {
            //chức năng Sửa dữ liệu đơn thuốc
            DialogResult result = MessageBox.Show("Bạn có muốn Lưu những thông tin vừa sửa đổi không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (ccbTenThuoc.Text == "")
                {
                    MessageBox.Show("Thiếu tên thuốc !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ccbTenThuoc.Focus();
                }
                else if (numberSL.Text == "0")
                {
                    MessageBox.Show("Thiếu Số lượng thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numberSL.Focus();
                }
                else if (txtCachDung.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Cách dùng !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCachDung.Focus();
                }
                else
                {
                    //khởi tạo biến xử lý tiền thuốc, lấy số lượng x đơn giá = tiền thuốc
                    decimal a, b;
                    a = Decimal.Parse(numberSL.Text);
                    b = Decimal.Parse(txtDongia.Text);
                    txtTienThuoc.Text = (a * b).ToString();
                    command = connect.CreateCommand();
                    command.CommandText = "update donthuoc set sl = '" + numberSL.Text + "', " +
                                                    "cachdung = N'" + txtCachDung.Text + "'," +
                                                    "tienthuoc = N'" + txtTienThuoc.Text + "'" +
                                                    "where idthuoc = N'" + txtMaThuoc.Text + "'";
                    command.ExecuteNonQuery();
                    //load lại dữ liệu
                    Loaddata_donthuoc();
                    tongtienthuoc();
                }
            }
            else
            {
                MessageBox.Show("Đã hủy tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void iconButton8_Click(object sender, EventArgs e)
        {
            //Chức năng xóa dữ liệu đơn thuốc
            DialogResult result = MessageBox.Show("Bạn có muốn XÓA không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                command = connect.CreateCommand();
                command.CommandText = "delete from donthuoc where idthuoc = '" + txtMaThuoc.Text + "'";
                command.ExecuteNonQuery();
                Loaddata_donthuoc();
                tongtienthuoc();

            }
            else
            {
                MessageBox.Show("Đã HỦY tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //Chức năng in đơn thuốc
            PrintDonthuoc frmDonThuoc = new PrintDonthuoc(txtMaBN.Text);
            frmDonThuoc.Size = new Size(770, 850);
            frmDonThuoc.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
