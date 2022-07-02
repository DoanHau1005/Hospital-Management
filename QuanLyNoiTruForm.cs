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
    public partial class QuanLyNoiTruForm : Form
    {

        //Khởi tạo kết nối hệ thống Sql Server
        SqlConnection cnn;

        //Biến tạm dùng để lưu trữ vị trí các hàng trong datagridview
        int tmp = 0;
        int count = 0;
        int account_id;

        String maGBenh;

        public QuanLyNoiTruForm(int account)
        {
            InitializeComponent();
            //Sesion của người đăng nhập suyên suốt quá trình sử dụng code 
            this.account_id = account;

            //Load thông tin bác sỹ
            LoadBacsy();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";

            //Load thông tin bệnh nhân
            LoadBN();

        }
        public void LoadBN()
        {

            //Khởi tạo biến kết nối Sql
            SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
            cnn.Open();

            SqlCommand command = cnn.CreateCommand();
            
            //Câu lệnh truy vẫn dữ liệu trong bảng quanlynoitru
            command.CommandText = "Select * from dbo.quanlynoitru";

            SqlDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Khởi tạo biến lưu trữ liệu thông tin bệnh nhân nội trú
                int maNoitru = reader.GetInt32(0);
                int maBN = reader.GetInt32(1);
                String hoten = reader.GetString(2);
                String maGB = reader.GetString(3);
                String tinhtrangGB = reader.GetString(4);
                String phiGB = reader.GetString(5);
                String ngaynhanphong = reader.GetString(6);
                String ngaytraphong = reader.GetString(7);
                int tongtien = reader.GetInt32(8);

                //Lưu trữ thông tin bệnh nhân nội trú vào datagriview
                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = maBN;
                dataGridView1.Rows[tmp].Cells[1].Value = hoten;
                dataGridView1.Rows[tmp].Cells[2].Value = maGB;
                dataGridView1.Rows[tmp].Cells[3].Value = tinhtrangGB;
                dataGridView1.Rows[tmp].Cells[4].Value = phiGB;
                dataGridView1.Rows[tmp].Cells[5].Value = ngaynhanphong;
                dataGridView1.Rows[tmp].Cells[6].Value = ngaytraphong;
                dataGridView1.Rows[tmp].Cells[7].Value = tongtien;
                dataGridView1.Rows[tmp].Cells[14].Value = maNoitru;
                tmp++;
            }

            if (String.IsNullOrEmpty(boxMaBN.Text))
            {
                btnDelete.Enabled = false;
            }


            //Unable button update nếu ko tồn tại dữ liệu maBN.
            if (String.IsNullOrEmpty(boxMaBN.Text))
            {
                btnUpdate.Enabled = false;
            }
            reader.Close();
            cnn.Close();
        }

        //Load thông tin bác sỹ
        public void LoadBacsy()
        {
            String sql_cnn = Properties.Resources.connectString;
            SqlConnection cnn = new SqlConnection(sql_cnn);
            cnn.Open();
            SqlCommand command = cnn.CreateCommand();
            
            //Sử dụng câu lệnh query bảng quanlygiuong
            command.CommandText = "Select * from quanlygiuong";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "quanlygiuong");

            //Đổ dữ liệu các giường bệnh còn trống vào hệ thống.
            foreach (DataRow row in ds.Tables["quanlygiuong"].Rows)
            {
                if (row["TinhTrang"].ToString() == "Còn")
                    boxGB.Items.Add((row["TenGB"].ToString() + " - " + row["MaGB"].ToString()).Trim());
            }
            
            cnn.Close();
        }


        private void QuanLyNoiTruForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }

        private void searchHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxGB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn thông tin giường bệnh sẽ ra thông tin phòng theo thông tin giường bệnh.
            if (!String.IsNullOrEmpty(boxGB.SelectedItem.ToString()))
            {
                String mabs = boxGB.SelectedItem.ToString().Substring(boxGB.SelectedItem.ToString().Length - 4, 4);
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "Select * from quanlygiuong where MaGB=" + "'" + mabs + "'";
                //MessageBox.Show("Select * from dbo.tPhong  where MaBacsy=" + "'"+mabs+"'");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "quanlygiuong");

                //Hiển thị thông lên textbox sau khi chọn thông tin giường bệnh
                foreach (DataRow row in ds.Tables["quanlygiuong"].Rows)
                {
                    boxGbenh.Text = row["TinhTrang"].ToString();
                    boxPhiGB.Text = row["PhiGB"].ToString();
                }

                //Kiểm tra cho phép người dùng có thể thêm thông tin giường bệnh hay không ?
                if (boxGbenh.Text == "Hết")
                {
                    btnAdd.Enabled = false;
                }
                else 
                {
                    btnAdd.Enabled = true;
                }
                con.Close();
            }
        }

       


        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            //Query lấy thông tin table tBenhNhan
            command.CommandText = "SELECT maBN,tuoi,tenBN,gioitinh,nghenghiep,bhyt,sdt FROM dbo.tBenhNhan WHERE maBN=@maBN";
            command.Parameters.AddWithValue("@maBN", maBN.Text);


            //Ghi dữ liệu query vào reader.
            SqlDataReader reader = command.ExecuteReader();
            if (reader != null)
            {
                //Đọc thông tin từ reader
                while (reader.Read())
                {

                    //Đổ dữ liệu vào các textbox thông tin bệnh nhân
                    boxMaBN.Text = reader.GetValue(0).ToString();
                    boxTuoi.Text = reader.GetValue(1).ToString();
                    boxTenBN.Text = reader.GetValue(2).ToString();
                    if (reader.GetValue(3).ToString() == "Nam")
                    {
                        radioNam.Checked = true;
                    }
                    else
                    {
                        radioNu.Checked = true;
                    }
                    boxNghenghiep.Text = reader.GetValue(4).ToString();
                    bhyt.Text = reader.GetValue(5).ToString();
                    boxSdt.Text = reader.GetValue(6).ToString();
                }
            }
            else
            {
                MessageBox.Show("Mã số bệnh nhân không tồn tại trong hệ thống.!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            reader.Close();

            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
   
      
            
            //Dữ liệu thông tin ngày nhập viện và ngày ra
            //Dùng để tính tiền thông tin nội trú.
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;

            TimeSpan t = d2 - d1;
            double day = t.TotalDays;
            int days = Convert.ToInt32(day);

            int tienphong = Convert.ToInt32(boxPhiGB.Text);
            tongTien.Text = (days * tienphong).ToString();
         
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.MinDate = DateTime.Now;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker2.MinDate = DateTime.Now;
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

            //Kiểm tra thông tin bệnh nhân để thêm nội trú
            if (String.IsNullOrEmpty(boxMaBN.Text))
            {
                MessageBox.Show("Chưa chọn thông tin bệnh nhân nội trú !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxGB.Text))
            {
                MessageBox.Show("Chưa chọn giường bệnh cho bệnh nhân !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxGbenh.Text))
            {
                MessageBox.Show("Tình trạng giường bệnh đã đầy vui lòng chọn giường bệnh khác !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxPhiGB.Text))
            {
                MessageBox.Show("Vui lòng chọn ngày ra viện để được tính phí !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(tongTien.Text))
            {
                MessageBox.Show("Vui lòng ấn nút tính Tính tổng để hệ thống tính tiền viện phí !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {

                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();

                //Sử dụng câu lệnh query để thêm thông tin bệnh nhân vào hệ thống Sql
                command.CommandText = "INSERT INTO dbo.quanlynoitru VALUES(@maBN, @hoten, @maGB, @tinhtrang, @phiGB, @ngaynhan, @ngaytra, @tongtien) SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@maBN", boxMaBN.Text);
                command.Parameters.AddWithValue("@hoten", boxTenBN.Text);
                command.Parameters.AddWithValue("@maGB", boxGB.Text.Substring(boxGB.Text.Length - 4, 4));
                command.Parameters.AddWithValue("@tinhtrang", boxGbenh.Text);
                command.Parameters.AddWithValue("@phiGB", boxPhiGB.Text);
                command.Parameters.AddWithValue("@ngaynhan", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@ngaytra", dateTimePicker2.Text);
                command.Parameters.AddWithValue("@tongtien", tongTien.Text);
                //command.ExecuteNonQuery();
                
                //Láy ID của bệnh nhân vừa mới thêm vào thông tin nội trú
                int ID = Convert.ToInt32(command.ExecuteScalar());

                con.Close();
                
                //Khởi tạo biến lưu trữ dữ liệu từ các textbox bệnh nhân nội trú.
                String maBN1 = boxMaBN.Text;
                String hoten = boxTenBN.Text;
                String maGB = boxGB.Text.Substring(boxGB.Text.Length - 4, 4);
                String tinhtrangGB = boxGbenh.Text;
                String phiGB = boxPhiGB.Text;
                String ngaynhanphong = dateTimePicker1.Text;
                String ngaytraphong = dateTimePicker2.Text;
                String tongtien = tongTien.Text;
                String tenMaGB = boxGB.Text;

               
                boxMaBN.Text = "";
                boxTuoi.Text = "";
                boxTenBN.Text = "";
                boxNghenghiep.Text = "";
                bhyt.Text = "";
                boxSdt.Text = "";
                maBN.Text = "";
                radioNam.Checked = false;
                radioNu.Checked = false;
                boxGB.Text = "";
                boxGbenh.Text = "";
                boxPhiGB.Text = "";
                tongTien.Text = "";
                dateTimePicker2.Value = DateTime.Now;
                MessageBox.Show("Thêm thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);



                //thêm các thông tin nội trú của bệnh nhân vào datagridview
                dataGridView1.Rows.Add();

                dataGridView1.Rows[tmp].Cells[0].Value = maBN1;
                dataGridView1.Rows[tmp].Cells[1].Value = hoten;
                dataGridView1.Rows[tmp].Cells[2].Value = maGB;
                dataGridView1.Rows[tmp].Cells[3].Value = tinhtrangGB;
                dataGridView1.Rows[tmp].Cells[4].Value = phiGB;
                dataGridView1.Rows[tmp].Cells[5].Value = ngaynhanphong;
                dataGridView1.Rows[tmp].Cells[6].Value = ngaytraphong;
                dataGridView1.Rows[tmp].Cells[7].Value = tongtien;
                dataGridView1.Rows[tmp].Cells[8].Value = tenMaGB;
                dataGridView1.Rows[tmp].Cells[14].Value = ID;


                tmp++;

                //Sửa thông tin giường bệnh khi thêm thông tin bệnh nhân nội trú vào Sql
                changeStateGiuongBenh(maGB);
            }

        }
        public void changeStateGiuongBenh(String id)
        {
            try
            {
                //Udpate thông tin giường bệnh thì trạng thái của giường bệnh sẽ thay đổi
                // Từ Còn -> hết
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "UPDATE quanlygiuong set TinhTrang = @tinhtrang where MaGB = @magb";
                command.Parameters.AddWithValue("@magb", id);
                command.Parameters.AddWithValue("@tinhtrang", "Hết");
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực thi: "+ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            //Làm mới thông tin bệnh nhân nội trú thêm vào hệ thống.
            boxMaBN.Text = "";
            boxNoitru.Text = "";
            boxTuoi.Text = "";
            boxTenBN.Text = "";
            boxNghenghiep.Text = "";
            bhyt.Text = "";
            boxSdt.Text = "";
            maBN.Text = "";
            radioNam.Checked = false;
            radioNu.Checked = false;
            boxGB.Text = "";
            boxGbenh.Text = "";
            boxPhiGB.Text = "";
            tongTien.Text = "";
            dateTimePicker2.Value = DateTime.Now;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAddBN.Enabled = true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn thông tin bệnh nhân nội trú rồi hiển thị lên textbox.
            if (e.RowIndex >= 0)
            {
                //Khởi tạo biến lưu trữ thông tin bệnh nhân
                String maBN1 = dataGridView1.Rows[e.RowIndex].Cells["txtMaso"].FormattedValue.ToString();
                String hovaten = dataGridView1.Rows[e.RowIndex].Cells["txtHoten"].FormattedValue.ToString();
                String maGB = dataGridView1.Rows[e.RowIndex].Cells["txtMaGB"].FormattedValue.ToString();
                String tinhtrang = dataGridView1.Rows[e.RowIndex].Cells["txtTinhtrang"].FormattedValue.ToString();
                String phi = dataGridView1.Rows[e.RowIndex].Cells["txtPhi"].FormattedValue.ToString();
                String ngaynhan = dataGridView1.Rows[e.RowIndex].Cells["txtNgaynhan"].FormattedValue.ToString();
                String ngaytra = dataGridView1.Rows[e.RowIndex].Cells["txtNgaytra"].FormattedValue.ToString();
                String tongtien = dataGridView1.Rows[e.RowIndex].Cells["txtTongtien"].FormattedValue.ToString();
                String id = dataGridView1.Rows[e.RowIndex].Cells["txtNoitru"].FormattedValue.ToString();

                SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
                cnn.Open();

                //Lấy thông tin tBenhnhan theo maBN1
                SqlCommand command1 = cnn.CreateCommand();
                command1.CommandText = "SELECT maBN,tuoi,tenBN,gioitinh,nghenghiep,bhyt,sdt FROM dbo.tBenhNhan WHERE maBN=@maBN";
                command1.Parameters.AddWithValue("@maBN", maBN1);
                boxMaBN.Text = maBN1;
                boxTenBN.Text = hovaten;
                maBN.Text = maBN1;

                boxGbenh.Text = tinhtrang;
                boxPhiGB.Text = phi;
                tongTien.Text = tongtien;
             
                //Lưu dữ liệu từ Sql vào reader.
                SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {

                    boxTuoi.Text = reader1.GetValue(1).ToString();
                    String gioitinh = reader1.GetValue(3).ToString();
                    if (gioitinh == "Nam")
                    {
                        radioNam.Checked = true;
                    }
                    else
                    {
                        radioNu.Checked = true;
                    }
                    boxNghenghiep.Text = reader1.GetValue(4).ToString();
                    bhyt.Text = reader1.GetValue(5).ToString();
                    boxSdt.Text = reader1.GetValue(6).ToString();
                }
                reader1.Close();

                //Chọn thông tin giường bệnh khi có được thông tin từ datagridview
                foreach (object item in boxGB.Items)
                {
                    if (item.ToString().Contains(maGB))
                    {
                        maGBenh = item.ToString() ;
                    }
                    continue;
                }
                boxNoitru.Text = id;
                boxGB.Text = maGBenh;
                //20-05-2022
                //Ngày nhập viện
                int day = Int32.Parse(ngaynhan.Substring(0,2));
                int month = Int32.Parse(ngaynhan.Substring(3,2));
                int year = Int32.Parse(ngaynhan.Substring(6,4));
                dateTimePicker1.Value = new DateTime(year, month,day );

                //Ngày ra viện 
                int day_out = Int32.Parse(ngaytra.Substring(0, 2));
                int month_out = Int32.Parse(ngaytra.Substring(3, 2));
                int year_out = Int32.Parse(ngaytra.Substring(6, 4));
                dateTimePicker2.Value = new DateTime(year_out, month_out, day_out);

                cnn.Close();


            }
        
        }

        private void maBN_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void boxMaBN_TextChanged(object sender, EventArgs e)
        {
           
         
        }

        //Xóa thông tin bệnh nhân nội trú
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Muốn xóa bệnh nhân có mã nội trú: " + boxNoitru.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                //Khởi tạo lệnh query dùng để xóa thông tin bệnh nhân nội trú
                command.CommandText = "DELETE FROM DBO.quanlynoitru where MaNoiTru = @maNoitru";
                command.Parameters.AddWithValue("@maNoitru", boxNoitru.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thông tin thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                tmp--;

                //Xóa thông tin bệnh nhân trên datagridview 
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }
                //Chuyển trạng thái giường bệnh khi xóa bệnh nhân
                changeStateGiuongBenhBack(boxGB.Text.Substring(boxGB.Text.Length - 4, 4));
                clear();
            }
        }
        //Thay đổi trạng thái giường bệnh 
        public void changeStateGiuongBenhBack(String id)
        {
            try
            {
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "UPDATE quanlygiuong set TinhTrang = @tinhtrang where MaGB = @magb";
                command.Parameters.AddWithValue("@magb", id);
                command.Parameters.AddWithValue("@tinhtrang", "Còn");
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực thi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void boxNoitru_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(boxNoitru.Text))
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAddBN.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAddBN.Enabled = false;
            }
        }
        //Update thông tin bệnh nhân nội trú
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Xác nhận thông bệnh nhân cần sửa trong hệ thống.
            if (MessageBox.Show("Bạn có muốn sửa bệnh nhân có mã nội trú: " + boxNoitru.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Khởi tạo biến Lưu giữ thông tin bệnh nhân nội trsu
                String hoten, maGB, tinhtrang, phi, ngaynhan, ngaytra, tongtien;
                hoten = boxTenBN.Text;
                maGB = boxGB.Text;
                tinhtrang = boxGbenh.Text;
                phi = boxPhiGB.Text;
                ngaynhan = dateTimePicker1.Text;
                ngaytra = dateTimePicker2.Text;
                tongtien = tongTien.Text;

                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                //Query update thông tin bệnh nhân nội trú.
                command.CommandText = "UPDATE dbo.quanlynoitru set HoTen = @hoten,  MaGB = @maGB, TinhTrang = @tinhtrang, PhiGB = @phi,NgayNhanPhong = @ngaynhan,NgayTraPhong = @ngaytra,TongTienPhong = @tongtien where MaNoiTru = @maBN";
                command.Parameters.AddWithValue("@hoten", hoten);
                command.Parameters.AddWithValue("@maGB", boxGB.Text.Substring(boxGB.Text.Length - 4, 4));
                command.Parameters.AddWithValue("@tinhtrang", tinhtrang);
                command.Parameters.AddWithValue("@phi", phi);
                command.Parameters.AddWithValue("@ngaynhan", ngaynhan);
                command.Parameters.AddWithValue("@ngaytra", ngaytra);
                command.Parameters.AddWithValue("@tongtien", tongtien);
                command.Parameters.AddWithValue("@maBN", boxNoitru.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thông tin nội trú thành công !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                con.Close();
                dataGridView1.Rows.Clear();
                tmp = 0;
                LoadBN();


            }
        }

        private void QuanLyNoiTruForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
