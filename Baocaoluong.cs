using CuoiKiCDCNPM.LuongThangNV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class Baocaoluong : Form
    {
        //Khởi tạo kết nối hệ thống
        SqlConnection cnn;
        int tmp = 0;
        int account_id;


        //Khởi các thông tin lưu dữ liệu thanh toán
        String hoTen;
        String luongCoBan;
        int count = 0;
        String thangluongNV;
        public Baocaoluong()
        {
            InitializeComponent();

            //Load thông tin nhân viên
            LoadBN();

            //Load thông tin nhân viên cần báo cáo lương
            LoadNV();
          
        }
        public void LoadNV()
        {
            SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
            cnn.Open();


            //Câu lệnh query thông tin bảng báo cáo lương
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = "Select * from baocaoluong";

            SqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Khởi tạo biến lưu dữ liệu thanh toán
                int manv = reader.GetInt32(1);
                String hoten = reader.GetString(2);
                String chuyenmon = reader.GetString(4);
                String khoa = reader.GetString(3);
                double hesoluong = reader.GetDouble(5);
                int songaycong = reader.GetInt32(6);
                int luongcoban = reader.GetInt32(7);
                int tienbaohiem = reader.GetInt32(8);
                int tienphucap = reader.GetInt32(9);
                int cackhoantru = reader.GetInt32(10); 
                double tongluong = reader.GetDouble(11);
                String thangluong = reader.GetString(12);


                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = manv;
                dataGridView1.Rows[tmp].Cells[1].Value = hoten;
                dataGridView1.Rows[tmp].Cells[2].Value = chuyenmon;
                dataGridView1.Rows[tmp].Cells[3].Value = khoa;
                dataGridView1.Rows[tmp].Cells[4].Value = hesoluong;
                dataGridView1.Rows[tmp].Cells[5].Value = songaycong;
                dataGridView1.Rows[tmp].Cells[6].Value = luongcoban;
                dataGridView1.Rows[tmp].Cells[7].Value = tienbaohiem;
                dataGridView1.Rows[tmp].Cells[8].Value = tienphucap;
                dataGridView1.Rows[tmp].Cells[9].Value = cackhoantru;
                dataGridView1.Rows[tmp].Cells[10].Value = tongluong;
                dataGridView1.Rows[tmp].Cells[11].Value = thangluong;
                tmp++;
            }

            //Không tồn tại thông tin họ tên thì nút xóa sẽ không được phép ấn
            if (String.IsNullOrEmpty(boxHoten.Text))
            {
                btnDelete.Enabled = false;
            }
            if (String.IsNullOrEmpty(boxHoten.Text))
            {
                btnUpdate.Enabled = false;
            }
            reader.Close();
            cnn.Close();
        }



        public void LoadBN()
        {
            SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
            cnn.Open();

            


            SqlCommand command = cnn.CreateCommand();
            //Query thông tin nhân viên từ bảng hosonhanvien
            command.CommandText = "Select idnhanvien,chuyenmon,khoa,hoten,hesoluong from hosonhanvien";
            SqlDataReader reader;
            reader = command.ExecuteReader();
            if (reader != null)
            {
                //Lấy thông tin kèm theo id nhân viên
                while (reader.Read())
                {
                    boxHoten.Items.Add((reader.GetValue(3)).ToString() + " - " + reader.GetValue(0).ToString());
                }
            }

            reader.Close();
            cnn.Close();
        }


        private void boxBacsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(boxHoten.SelectedItem.ToString()))
            {
                //Lấy thông tin của nhân viên
                String mabs = boxHoten.SelectedItem.ToString().Substring(boxHoten.SelectedItem.ToString().Length - 4, 4);
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();

                //Query thông tin nhân viên
                command.CommandText = "Select chuyenmon,khoa,hesoluong from hosonhanvien where idnhanvien=" + "'" + mabs + "'";
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "hosonhanvien");
                //Đổ dữ liệu nhân viên vào các textbox
                foreach (DataRow row in ds.Tables["hosonhanvien"].Rows)
                {
                    boxKhoa.Text = row["khoa"].ToString();
                    boxChuyenmon.Text = row["chuyenmon"].ToString();
                    boxHeSoLuong.Text = row["hesoluong"].ToString();
                }

                con.Close();

            }
            


        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            //Khởi biến lưu dữ liệu lương của nhân viên
            decimal a, b;
            decimal luongcoban;
            decimal hesoluong;
            decimal tienphucap;
            decimal tienbaohiem;
            decimal cackhoantru;
            decimal songaycong;
            if (boxSoNgayCong.Text == "")
            {
                MessageBox.Show("Nhập thiếu số ngày công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxSoNgayCong.Focus();
            }
            else if (boxLuongCoBan.Text == "")
            {
                MessageBox.Show("Nhập thiếu lương cơ bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxLuongCoBan.Focus();
            }
            else if (boxTienBaoHiem.Text == "")
            {
                MessageBox.Show("Nhập thiếu tiền bảo hiểm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTienBaoHiem.Focus();
            }
            else if (boxTienPhuCap.Text == "")
            {
                MessageBox.Show("Nhập thiếu tiền bảo hiểm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTienPhuCap.Focus();
            }
            else if (boxCacKhoanTru.Text == "")
            {
                MessageBox.Show("Nhập thiếu các khoản trừ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxCacKhoanTru.Focus();
            }
            else if (boxHeSoLuong.Text == "")
            {
                MessageBox.Show("Thiếu hệ số lương", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxHeSoLuong.Focus();
            }
            else
            {
                //Tính các thông tin lương của nhân viên
                luongcoban = decimal.Parse(boxLuongCoBan.SelectedItem.ToString());
                hesoluong = decimal.Parse(boxHeSoLuong.Text);

                tienphucap = decimal.Parse(boxTienPhuCap.Text);
                tienbaohiem = decimal.Parse(boxTienBaoHiem.Text);
                cackhoantru = decimal.Parse(boxCacKhoanTru.Text);
                songaycong = decimal.Parse(boxSoNgayCong.Text);


                //Kiểm tra số ngày công của nhân viên cho phép trong một tháng 
                if (songaycong < 22)
                {
                    a =  (22 - songaycong)*50000;
                    boxTongLuong.Text = ((luongcoban * hesoluong) + tienphucap - tienbaohiem - cackhoantru - a).ToString();
                }
                else if (songaycong >= 22)
                {
                    b = (songaycong - 22)*50000;
                    boxTongLuong.Text = ((luongcoban * hesoluong) + tienphucap - tienbaohiem - cackhoantru + b).ToString();
                }

                
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Thêm thông tin lương nhân viên vào hệ thống
            if (String.IsNullOrEmpty(boxHoten.Text))
            {
                MessageBox.Show("Chưa chọn tên nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxSoNgayCong.Text))
            {
                MessageBox.Show("Chưa nhập số ngày công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxSoNgayCong.Text))
            {
                MessageBox.Show("Chưa nhập số ngày công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (String.IsNullOrEmpty(boxLuongCoBan.Text))
            {
                MessageBox.Show("Chưa chọn lương cơ bản", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxTienBaoHiem.Text))
            {
                MessageBox.Show("Chưa nhập tiền bảo hiểm", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxTienPhuCap.Text))
            {
                MessageBox.Show("Chưa nhập tiền phụ cấp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxCacKhoanTru.Text))
            {
                MessageBox.Show("Chưa nhập các khoản trừ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxHeSoLuong.Text))
            {
                MessageBox.Show("Chưa nhập hệ số lương", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();

                //Query thêm thông tin lương nhân viên
                command.CommandText = "INSERT INTO baocaoluong VALUES(@idnhanvien, @hoten, @chuyenmon, @khoa, @hesoluong, @songaycong, @luongcoban, @tienbaohiem, @tienphucap,@cackhoantru, @tongluong,@thangluong) SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@idnhanvien", boxHoten.Text.Substring(boxHoten.Text.Length - 4, 4));
                command.Parameters.AddWithValue("@hoten", boxHoten.Text.Substring(0, boxHoten.Text.Length - 6));
                command.Parameters.AddWithValue("@khoa", boxKhoa.Text);
                command.Parameters.AddWithValue("@chuyenmon", boxChuyenmon.Text);
                command.Parameters.AddWithValue("@hesoluong", boxHeSoLuong.Text);
                command.Parameters.AddWithValue("@songaycong", boxSoNgayCong.Text);
                command.Parameters.AddWithValue("@luongcoban", boxLuongCoBan.Text);
                command.Parameters.AddWithValue("@tienbaohiem", boxTienBaoHiem.Text);
                command.Parameters.AddWithValue("@tienphucap", boxTienPhuCap.Text);
                command.Parameters.AddWithValue("@cackhoantru", boxCacKhoanTru.Text);
                command.Parameters.AddWithValue("@tongluong", boxTongLuong.Text);
                command.Parameters.AddWithValue("@thangluong", (DateTime.Now.ToString("MM-yyyy")));
                


                command.ExecuteNonQuery();
                con.Close();

                //Khởi tạo dữ liệu lưu thông tin lương nhân viên vừa được thêm
                String manv = boxHoten.Text.Substring(boxHoten.Text.Length - 4, 4);
                String hoten = boxHoten.Text.Substring(0, boxHoten.Text.Length - 6);
                String chuyenmon = boxChuyenmon.Text;
                String khoa = boxKhoa.Text;
                String hesoluong = boxHeSoLuong.Text;
                String songaycong = boxSoNgayCong.Text;
                String luongcoban = boxLuongCoBan.Text;
                String tienbaohiem = boxTienBaoHiem.Text;
                String tienphucap = boxTienPhuCap.Text;
                String cackhoantru = boxCacKhoanTru.Text;
                String tongluong = boxTongLuong.Text;


                thangluongNV = DateTime.Now.ToString("MM-yyyy");

                //Thêm dữ liệu vào datagridview
                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = manv;
                dataGridView1.Rows[tmp].Cells[1].Value = hoten;
                dataGridView1.Rows[tmp].Cells[2].Value = khoa;
                dataGridView1.Rows[tmp].Cells[3].Value = chuyenmon;
                
                dataGridView1.Rows[tmp].Cells[4].Value = hesoluong;
                dataGridView1.Rows[tmp].Cells[5].Value = songaycong;
                dataGridView1.Rows[tmp].Cells[6].Value = luongcoban;
                dataGridView1.Rows[tmp].Cells[7].Value = tienbaohiem;
                dataGridView1.Rows[tmp].Cells[8].Value = tienphucap;
                dataGridView1.Rows[tmp].Cells[9].Value = cackhoantru;
                dataGridView1.Rows[tmp].Cells[10].Value = tongluong;

                tmp++;

                //Clear thông tin nhân viên sau khi thêm thành công
                boxHoten.Text = "";
                boxKhoa.Text = "";
                boxChuyenmon.Text = "";
                boxHeSoLuong.Text = "";
                boxSoNgayCong.Text = "";
                boxLuongCoBan.SelectedIndex = -1;
                boxTienBaoHiem.Text = "";
                boxTienPhuCap.Text = "";
                boxCacKhoanTru.Text = "";
                boxTongLuong.Text = "";
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                MessageBox.Show("Thêm Lương nhân viên mới thành công !!!");


                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = hoten;
                dataGridView2.Rows[count].Cells[1].Value = chuyenmon;
                dataGridView2.Rows[count].Cells[2].Value = tongluong;
                count++;

                frmPrintLuong frmLuongNV = new frmPrintLuong(manv, thangluongNV);
                frmLuongNV.Size = new Size(930, 900);
                frmLuongNV.Show();

            }
        }

        private void Baocaoluong_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Khởi tạo biến lưu dữ liệu thông tin Lương nhân viên 
                String manv = dataGridView1.Rows[e.RowIndex].Cells["gridMaNV"].FormattedValue.ToString();
                String hoten = dataGridView1.Rows[e.RowIndex].Cells["gridHoTen"].FormattedValue.ToString();
                String songaycong = dataGridView1.Rows[e.RowIndex].Cells["gridSoNgayCong"].FormattedValue.ToString();
                String luongcoban = dataGridView1.Rows[e.RowIndex].Cells["gridLuongCoBan"].FormattedValue.ToString();
                String tienbaohiem = dataGridView1.Rows[e.RowIndex].Cells["gridTienBaoHiem"].FormattedValue.ToString();
                String tienphucap = dataGridView1.Rows[e.RowIndex].Cells["gridTienPhuCap"].FormattedValue.ToString();
                String cackhoantru = dataGridView1.Rows[e.RowIndex].Cells["gridCacKhoanTru"].FormattedValue.ToString();
                String tongluong = dataGridView1.Rows[e.RowIndex].Cells["gridTongLuong"].FormattedValue.ToString();
                thangluongNV = dataGridView1.Rows[e.RowIndex].Cells["thangluong"].FormattedValue.ToString();


                //Chọn lương cơ bản từ hệ thống theo thông tin lương cơ bản được chọn từ datagridview
                foreach (object item1 in boxLuongCoBan.Items)
                {
                    if (item1.ToString().Contains(luongcoban))
                    {

                        luongCoBan = item1.ToString();
                    }
                    continue;
                }

                //Chọn lương cơ bản từ hệ thống theo họ tên được chọn từ datagridview

                foreach (object item in boxHoten.Items)
                {
                    if (item.ToString().Contains(hoten))
                    {
                        hoTen = item.ToString();
                    }
                    continue;
                }
                textBox1.Text = manv;
                boxHoten.Text = hoTen;
                boxSoNgayCong.Text = songaycong;
                boxLuongCoBan.Text = luongCoBan;
                boxTienBaoHiem.Text = tienbaohiem;
                boxTienPhuCap.Text = tienphucap;
                boxCacKhoanTru.Text = cackhoantru;
                boxTongLuong.Text = tongluong;
            }
        }
        public void clear()
        {
            boxHoten.Text = "";
            boxKhoa.Text = "";
            boxChuyenmon.Text = "";
            boxHeSoLuong.Text = "";
            boxSoNgayCong.Text = "";
            boxLuongCoBan.SelectedIndex = -1;
            boxTienBaoHiem.Text = "";
            boxTienPhuCap.Text = "";
            boxCacKhoanTru.Text = "";
            boxTongLuong.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Thông báo kiểm tra người dùng có muốn xóa thông tin lương của nhân vien
            if (MessageBox.Show("Muốn xóa nhân viên " + boxHoten.Text.Substring(0, boxHoten.Text.Length - 6) + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                //Query dùng xóa thông tin nhân viên trong hệ thống.
                command.CommandText = "DELETE FROM baocaoluong where idnhanvien = @manv";
                command.Parameters.AddWithValue("@manv", boxHoten.Text.Substring(boxHoten.Text.Length - 4, 4));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tmp--;

                //Xóa thông tin nhân viên trong bảng datagridview
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Hỏi người dùng có muốn sửa thông tin Lương nhân viên
            if (MessageBox.Show("Bạn có muốn sửa nhân viên : " + boxHoten.Text.Substring(0, boxHoten.Text.Length - 6) + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String songaycong, luongcoban, tienbaohiem, tienphucap, cackhoantru, tongluong;
                songaycong = boxSoNgayCong.Text;
                luongcoban = boxLuongCoBan.Text;
                tienbaohiem = boxTienBaoHiem.Text;
                tienphucap = boxTienPhuCap.Text;
                cackhoantru = boxTienPhuCap.Text;
                tongluong = boxTongLuong.Text;
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();

                //Query sửa thông tin lương nhân viên
                command.CommandText = "UPDATE baocaoluong set songaycong = @songaycong, luongcoban = @luongcoban, tienbaohiem = @tienbaohiem, tienphucap = @tienphucap,cackhoantru = @cackhoantru,tongluong = @tongluong where idnhanvien = @manv";
                command.Parameters.AddWithValue("@songaycong", songaycong);
                command.Parameters.AddWithValue("@luongcoban", luongcoban);
                command.Parameters.AddWithValue("@tienbaohiem", tienbaohiem);
                command.Parameters.AddWithValue("@tienphucap", tienphucap);
                command.Parameters.AddWithValue("@cackhoantru", cackhoantru);
                command.Parameters.AddWithValue("@tongluong", tongluong);
                
                command.Parameters.AddWithValue("@manv", boxHoten.Text.Substring(boxHoten.Text.Length - 4, 4));
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin nhân viên thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                con.Close();
                dataGridView1.Rows.Clear();
                tmp = 0;
                LoadNV();


            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            searchHoten.Text = "";
            searchTuoi.Text = "";
            searchDiachi.Text = "";
        }

        private void boxHoten_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void boxKhoa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void boxSoNgayCong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxHeSoLuong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Kiểm tra thông tin bệnh nhân để enabled hoặc disabled các nút thêm, xóa, sửa.
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void searchHoten_TextChanged(object sender, EventArgs e)
        {
            //Update thông tin tìm kiếm thống tin
            updateList(searchHoten.Text);
        }

        public void updateList(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            //Query lấy thông tin nhân viên từ baocaoluong
            command.CommandText = "SELECT hoten,chuyenmon,tongluong FROM baocaoluong WHERE (hoten LIKE @query OR chuyenmon LIKE @query or tongluong LIKE @query)";
            command.Parameters.AddWithValue("@query", "%" + query + "%");

            SqlDataReader reader = command.ExecuteReader();
            dataGridView2.Rows.Clear();
            int count = 0;

            //Thêm thông tin Lương nhân viên vào datagridviw
            while (reader.Read())
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = reader[0].ToString();
                dataGridView2.Rows[count].Cells[1].Value = reader[1].ToString();
                dataGridView2.Rows[count].Cells[2].Value = reader[2].ToString();
                count++;
            }
            con.Close();
        }

        private void searchTuoi_TextChanged(object sender, EventArgs e)
        {
            //Update thông tin tìm kiếm thống tin
            updateList(searchTuoi.Text);
        }

        private void searchDiachi_TextChanged(object sender, EventArgs e)
        {
            //Update thông tin tìm kiếm thống tin
            updateList(searchDiachi.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(boxHoten.Text))
            {
                if (MessageBox.Show("Bạn có muốn in báo cáo lương nhân viên có tên: " + boxHoten.Text.Substring(0, boxHoten.Text.Length - 6) + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //In thông tin lương nhân viên
                    frmPrintLuong frmLuongNV = new frmPrintLuong(boxHoten.Text.Substring(boxHoten.Text.Length - 4, 4).Trim(),thangluongNV);
                    frmLuongNV.Size = new Size(930, 900);
                    frmLuongNV.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhân viên để in Lương", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
