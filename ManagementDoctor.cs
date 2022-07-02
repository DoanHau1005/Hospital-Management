using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class ManagementDoctor : Form
    {
        //Khởi tạo biến kết nối DATABASE
        SqlConnection connect;
        SqlCommand command;
        string str = Properties.Resources.connectString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public ManagementDoctor()
        {
            InitializeComponent();
            loadKhoa();

        }
       
        void loadKhoa()
        //Lấy dữ liệu từ bảng Khoa
        {
            SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
            cnn.Open();
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = "Select * from tKhoa";

            SqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add((reader.GetValue(1)).ToString() + " - " + reader.GetValue(0).ToString());
                }
            }
            reader.Close();
            cnn.Close();
        }

        void Loaddata_nhanvien()
        //Load dữ liệu nhanvien vào datagridview
        {
            command = connect.CreateCommand();
            command.CommandText = "select * from hosonhanvien ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvNhanVien.DataSource = table;

        }
        private void ManagementDoctor_Load(object sender, EventArgs e)
        //Load dữ liệu nhanvien vào datagridview
        {
            this.hosonhanvienTableAdapter1.Fill(this.cuoikicdDataSet1.hosonhanvien);
            connect = new SqlConnection(str);
            connect.Open();
            Loaddata_nhanvien();
        }
        public DataTable timdulieunhanvien(string sql)
            //Chức năng tìm kiếm dữ liệu
        {
            connect = new SqlConnection(str);
            SqlDataAdapter adapfind = new SqlDataAdapter(sql, connect);
            DataTable dtfind = new DataTable();
            adapfind.Fill(dtfind);
            return dtfind;
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
            //Truyền dữ liệu từ datagridview sang các ô textbox khi click
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txtIDNhanVien.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtHeSoLuong.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txtTenTrinhDo.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[i].Cells[10].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[i].Cells[11].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[i].Cells[12].Value.ToString();
            txtPhongKhoa.Text = dgvNhanVien.Rows[i].Cells[14].Value.ToString();
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        //chặn người dùng nhập chữ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHeSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        //chặn người dùng nhập
        {
            e.Handled = true;
        }
        private void btnSua1_Click(object sender, EventArgs e)
            //Chức năng sửa dữ liệu 
        {
            DialogResult result = MessageBox.Show("Bạn có muốn SỬA không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
                //Khởi tạo điều kiện kiểm tra tác vụ người dùng nhập
            {
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Nhập thiếu tên nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                }
                else if (txtGioiTinh.Text == "")
                {
                    MessageBox.Show("Nhập thiếu giới tính nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGioiTinh.Focus();
                }
                else if (txtCMND.Text == "")
                {
                    MessageBox.Show("Nhập thiếu CMND nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMND.Focus();
                }

                else if (txtSDT.Text == "")
                {
                    MessageBox.Show("Nhập thiếu SĐT nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Địa Chỉ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Email nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chuyên môn nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Khoa nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox2.Focus();
                }

                else if (txtHeSoLuong.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Hệ số lương nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeSoLuong.Focus();
                }
                else if (txtTenTrinhDo.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Trình độ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTrinhDo.Focus();
                }

                else if (txtChucVu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chức vụ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChucVu.Focus();
                }
                else
                {
                    command = connect.CreateCommand();
                    command.CommandText = "update hosonhanvien set chuyenmon = N'" + comboBox1.Text + "', " +
                                                    "khoa =  N'" + comboBox2.Text + "', " +
                                                    "ngaysinh = '" + dtpNgaySinh.Text + "'," +
                                                    "diachi = N'" + txtDiaChi.Text + "'," +
                                                    "socmnd ='" + txtCMND.Text + "'," +
                                                    "hesoluong ='" + txtHeSoLuong.Text + "'," +
                                                    "tentrinhdo = N'" + txtTenTrinhDo.Text + "'," +
                                                    "chucvu = N'" + txtChucVu.Text + "'," +
                                                    "hoten = N'" + txtHoTen.Text + "'," +
                                                    "gioitinh = N'" + txtGioiTinh.Text + "'," +
                                                    "sdt ='" + txtSDT.Text + "'," +
                                                    "email ='" + txtEmail.Text + "'," +
                                                    "sophongkhoa ='" + txtPhongKhoa.Text + "'" +
                                                    "where idnhanvien = '" + txtIDNhanVien.Text + "'";
                    command.ExecuteNonQuery();
                    Loaddata_nhanvien();

                }
            }
            else
            {
                MessageBox.Show("Đã HỦY tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        //Chức năng sửa dữ liệu 
        {
            DialogResult result = MessageBox.Show("Bạn có muốn SỬA không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            //Khởi tạo điều kiện kiểm tra tác vụ người dùng nhập
            {
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Nhập thiếu tên nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoTen.Focus();
                }
                else if (txtGioiTinh.Text == "")
                {
                    MessageBox.Show("Nhập thiếu giới tính nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGioiTinh.Focus();
                }
                else if (txtCMND.Text == "")
                {
                    MessageBox.Show("Nhập thiếu CMND nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCMND.Focus();
                }

                else if (txtSDT.Text == "")
                {
                    MessageBox.Show("Nhập thiếu SĐT nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Focus();
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Địa Chỉ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiaChi.Focus();
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Email nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chuyên môn nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                }
                else if (comboBox2.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Khoa nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox2.Focus();
                }

                else if (txtHeSoLuong.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Hệ số lương nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHeSoLuong.Focus();
                }
                else if (txtTenTrinhDo.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Trình độ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTrinhDo.Focus();
                }

                else if (txtChucVu.Text == "")
                {
                    MessageBox.Show("Nhập thiếu Chức vụ nhân viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChucVu.Focus();
                }
                else
                {
                    command = connect.CreateCommand();
                    command.CommandText = "update hosonhanvien set chuyenmon = N'" + comboBox1.Text + "', " +
                                                    "khoa =  N'" + comboBox2.Text + "', " +
                                                    "ngaysinh = '" + dtpNgaySinh.Text + "'," +
                                                    "diachi = N'" + txtDiaChi.Text + "'," +
                                                    "socmnd ='" + txtCMND.Text + "'," +
                                                    "hesoluong ='" + txtHeSoLuong.Text + "'," +
                                                    "tentrinhdo = N'" + txtTenTrinhDo.Text + "'," +
                                                    "chucvu = N'" + txtChucVu.Text + "'," +
                                                    "hoten = N'" + txtHoTen.Text + "'," +
                                                    "gioitinh = N'" + txtGioiTinh.Text + "'," +
                                                    "sdt ='" + txtSDT.Text + "'," +
                                                    "email ='" + txtEmail.Text + "'," +
                                                    "sophongkhoa ='" + txtPhongKhoa.Text + "'" +
                                                    "where idnhanvien = '" + txtIDNhanVien.Text + "'";
                    command.ExecuteNonQuery();
                    Loaddata_nhanvien();

                }
            }
            else
            {
                MessageBox.Show("Đã HỦY tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
            //Làm trống dữ liệu
        {
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtCMND.Text = "";
            dtpNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtChucVu.Text = "";
            txtHeSoLuong.Text = "";
            txtTenTrinhDo.Text = "";
            comboBox2.Text = "";
            txtTimKiem.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
            //chức năng xóa dữ liệu
        {
            DialogResult result = MessageBox.Show("Bạn có muốn XÓA không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                command = connect.CreateCommand();
                command.CommandText = "delete from hosonhanvien where idnhanvien = '" + txtIDNhanVien.Text + "'";
                command.ExecuteNonQuery();
                Loaddata_nhanvien();
                //countcanho();
            }
            else
            {
                MessageBox.Show("Đã HỦY tác vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtHeSoLuong_MouseEnter(object sender, EventArgs e)
            //Set hệ số lương theo role bác sĩ
        {
            if (comboBox1.Text == "Bác sĩ cao cấp")
            {
                txtHeSoLuong.Focus();
                txtHeSoLuong.Text = "6.92";
            }
            else if (comboBox1.Text == "Bác sĩ chính")
            {
                txtHeSoLuong.Text = "5.42";
            }
            else if (comboBox1.Text == "Bác sĩ")
            {
                txtHeSoLuong.Text = "3.33";
            }
            else if (comboBox1.Text == "Y tá")
            {
                txtHeSoLuong.Text = "2.06";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            //Lấy dữ liệu từ bảng Khoa
        {
            if (!String.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
            {
                String makhoa = comboBox2.SelectedItem.ToString().Substring(comboBox2.SelectedItem.ToString().Length - 1, 1);
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "Select sophongkhoa from tKhoa where idkhoa=" + "'" + makhoa + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "tKhoa");
                foreach (DataRow row in ds.Tables["tKhoa"].Rows)
                {
                    txtPhongKhoa.Text = row["sophongkhoa"].ToString();
                }
                con.Close();

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
            //Chức năng tìm kiếm
        {
            if (cbbTimKiem.Text == "Mã NV")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where idnhanvien like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Họ Tên")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where hoten like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Ngày Sinh")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where ngaysinh like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Giới Tính")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where gioitinh like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "CMND")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where socmnd like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "SĐT")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where sdt like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Địa Chỉ")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where diachi like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Email")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where email like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Chuyên môn")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where chuyenmon like 'N%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Khoa")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where khoa like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Hệ Số Lương")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where hesoluong like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Trình độ")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where tentrinhdo like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Phòng Khoa")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where sophongkhoa like '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbbTimKiem.Text == "Chức vụ")
            {
                dgvNhanVien.DataSource = timdulieunhanvien("select * from hosonhanvien where chucvu like '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
