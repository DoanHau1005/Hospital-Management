using CuoiKiCDCNPM.PhieuKhamBN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class QuanLyBenhNhan : Form
    {
        //Tạo session đăng nhập id xuyên suốt quá trình đăng nhập
        int account_id;
        //Tạo kết nối db Sql Server
        SqlConnection cnn;

        // Biến tạm dùng để lưu trữ vị trí các phần tử bên trong datagridview.
        // Giúp hiện thực việc thêm xóa sửa từng vị trí các phần tử trong datagridview.
        int tmp = 0;
        int count = 0;
        public QuanLyBenhNhan(int id)
        {
            InitializeComponent();
            account_id = id;
            this.Name = "Quản lý khám bệnh";

            //Set datetimepicker theo định dạng ngày/tháng/ năm
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            
            //Hàm dùng để load thông tin bệnh nhân trên Sql vào datagridview
            loadData();

            //Hàm dùng để load thông tin bác sỹ để chọn cho bệnh nhân trên Sql vào datagridview
            LoadBacsy();
            //Unable button delete nếu ko tồn tại dữ liệu maBN.
            
            // Set font chữ cho datagridview
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            }



            //Kiểm tra thông tin mã bênh nhân tồn tại để có thể nhấn được nút Xóa
            if (String.IsNullOrEmpty(boxMaBN.Text))
            {
                btnDelete.Enabled = false;
            }


            //Unable button update nếu ko tồn tại dữ liệu maBN.
            if (String.IsNullOrEmpty(boxMaBN.Text))
            {
                btnUpdate.Enabled = false;
            }
        }

        public void LoadBacsy()
        {

            //Tạo kết nối db Sql Server
            String sql_cnn = Properties.Resources.connectString;
            SqlConnection cnn = new SqlConnection(sql_cnn);
            
            //Mở kết nối database Sql
            cnn.Open();
            
            //Tạo command để truyền lệnh tương tương đến Sql Server.
            SqlCommand command = cnn.CreateCommand();

            //Tryền lệnh lấy dữ liệu tồn tại trong bảng hosonhanvien trong db
            command.CommandText = "Select * from dbo.hosonhanvien";

            //Biến dùng lưu dữ liệu đọc từ sql
            SqlDataReader reader;

            //Tạo kết nối với câu lệnh lấy dữ liệu từ sql
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //Tạo dataset lưu trũ dữ liệu 
            DataSet ds = new DataSet();

            //Dổ dữ liệu vào bảng Bacsy
            adapter.Fill(ds, "Bacsy");
            
            //Dùng vào lặp để lấy từng hàng dữ liệu bên trong bảng Bacsy
            foreach (DataRow row in ds.Tables["Bacsy"].Rows)
            {
                //Nếu chức vụ của nhân viên trong hệ thống là doctoc mới phép chọn
                if (row["chucvu"].ToString().Equals("Doctor"))
                {
                    //Thêm danh sách bác sỹ vào listview cho Y tá chọn cho bệnh nhân
                    boxBacsi.Items.Add((row["hoten"].ToString() + " - " + row["idnhanvien"].ToString()).Trim());
                    
                }

            }
        }

        public void loadData()
        {
            //Tạo kết nối db Sql Server
            String sql_cnn = Properties.Resources.connectString;
            SqlConnection cnn = new SqlConnection(sql_cnn);

            //Mở kết nối database Sql
            cnn.Open();

            //Tạo command để truyền lệnh tương tương đến Sql Server.
            SqlCommand command = cnn.CreateCommand();

            //Tryền lệnh lấy dữ liệu tồn tại trong bảng tBenhNhan trong db
            command.CommandText = "Select * from dbo.tBenhNhan";

            //Tạo kết nối với câu lệnh lấy dữ liệu từ sql
            SqlDataAdapter sdr = new SqlDataAdapter(command);

            //Tạo Datatable lưu trũ dữ liệu 
            DataTable dt = new DataTable();
            sdr.Fill(dt);

            //Đổ dữ liệu bảng search
            foreach (DataRow row in dt.Rows)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = row["tenBN"];
                dataGridView2.Rows[count].Cells[1].Value = row["tuoi"];
                dataGridView2.Rows[count].Cells[2].Value = row["diachi"];
                count++;
            }
            /*-------------*/


            //Đổ dữ liệu vào bảng thông tin bệnh nhân. Datagridview1
            SqlDataReader reader;
            reader = command.ExecuteReader();

            //Dùng lệnh đọc dữ liệu trong reader
            while (reader.Read())
            {
                //Khởi tạo các biến dùng để lưu trữ thông tin cho bệnh nhân.
                String maBN = reader[0].ToString();
                String hovaten = reader[1].ToString();
                String tuoi = reader[2].ToString();
                String gioitinh = reader[3].ToString();
                String nghenghiep = reader[4].ToString();
                String diachi = reader[5].ToString();
                String sdt = reader[6].ToString();
                String trieuchung = reader[7].ToString();
                String bhyt = reader[8].ToString();
                String phong = reader[9].ToString();
                String bacsikham = reader[10].ToString();
                String ngaykham = reader[11].ToString();
                String trangthai = reader[12].ToString();

                //Thêm từng dữ liệu bệnh nhân vào datagridview 
                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = maBN;
                dataGridView1.Rows[tmp].Cells[1].Value = hovaten;
                dataGridView1.Rows[tmp].Cells[2].Value = gioitinh;
                dataGridView1.Rows[tmp].Cells[3].Value = diachi;
                dataGridView1.Rows[tmp].Cells[4].Value = sdt;
                dataGridView1.Rows[tmp].Cells[5].Value = trieuchung;
                dataGridView1.Rows[tmp].Cells[6].Value = bacsikham;
                dataGridView1.Rows[tmp].Cells[7].Value = ngaykham;
                dataGridView1.Rows[tmp].Cells[8].Value = nghenghiep;
                dataGridView1.Rows[tmp].Cells[9].Value = tuoi;
                dataGridView1.Rows[tmp].Cells[9].Value = tuoi;
                dataGridView1.Rows[tmp].Cells[10].Value = bhyt;
                dataGridView1.Rows[tmp].Cells[11].Value = phong;
                dataGridView1.Rows[tmp].Cells[12].Value = phong;

                tmp++;
            }
            /*-------------*/
            cnn.Close();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            EditProfile editProfile = new EditProfile(account_id);
            editProfile.Show();
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagementMedicine managementMedicine = new ManagementMedicine(account_id);
            managementMedicine.Show();
        }

        private void quảnLýNộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNoiTruForm quanLyNoiTru = new QuanLyNoiTruForm(account_id);
            quanLyNoiTru.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanForm thanhToanForm = new ThanhToanForm(account_id);
            thanhToanForm.Show();

        }

        private void quảnLýThuốcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ManagementMedicine managementMedicine = new ManagementMedicine(account_id);
            managementMedicine.Show();

        }

        private void QuanLyBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Khởi tạo biến lưu dữ liệu của bệnh nhân để lưu vào hệ thống
            String tenBN, nghenghiep, diachi, sdt, trieuchung, bacsikham, bhyt, phong, tuoi;
            String gt = "";
            String ngaykham = DateTime.Now.ToString();
            //Gán dữ liệu từ các textbox chứa thông tin bệnh cho các biến khởi tạo.
            tenBN = boxTenBN.Text;
            tuoi = boxTuoi.Text;
            nghenghiep = boxNghenghiep.Text;
            diachi = boxDiachi.Text;
            sdt = boxSdt.Text;
            trieuchung = boxTrieuchung.Text;
            bacsikham = boxBacsi.Text;
            bhyt = boxBHYT.Text;
            phong = boxPhong.Text;


            //Khởi các biến chứa điều kiện kiểm tra thông tin nhập vào của bệnh nhân
            Regex regex = new Regex(@"^\d$");
            bool tenBN_containsNum = Regex.IsMatch(tenBN, @"\d");
            bool tuoi_containsNum = Regex.IsMatch(tuoi, @"\d");

            //Lấy dữ liệu thông tin khi nút giới tính của bệnh nhân check
            if (radioNam.Checked.Equals(true))
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";

            }
            
            //Kiểm tra thông tin nhập vào của bệnh nhân có phù hợp không!
            if (String.IsNullOrEmpty(tenBN))
            {
                MessageBox.Show("Tên bệnh nhân không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTenBN.Focus();

            }
            else if (tenBN_containsNum)
            {
                MessageBox.Show("Tên bệnh nhân không được phép chứa số kí tự!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTenBN.Focus();

            }
            else if (String.IsNullOrEmpty(boxTuoi.Text))
            {
                MessageBox.Show("Tuổi bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (!tuoi_containsNum)
            {
                MessageBox.Show("Tuổi bệnh nhân không được chứa kí tự!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (Int32.Parse(tuoi) < 0 || Int32.Parse(tuoi) > 100)
            {
                MessageBox.Show("Tuổi bệnh nhân phải nằm trong khoảng 1 -> 100!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (radioNam.Checked == false && radioNu.Checked == false)
            {
                MessageBox.Show("Giới tính bệnh nhân chưa có !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioNam.Focus();
            }
            else if (String.IsNullOrEmpty(bacsikham))
            {
                MessageBox.Show("Chưa chọn bác sĩ khám cho bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxBacsi.Focus();
            }
            else if (String.IsNullOrEmpty(trieuchung))
            {
                MessageBox.Show("Chưa điền triệu chứng cho bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTrieuchung.Focus();
            }
            else if (String.IsNullOrEmpty(nghenghiep))
            {
                MessageBox.Show("Nghề nghiệp bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxNghenghiep.Focus();
            }
            else if (String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Sđt bệnh nhân không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxSdt.Focus();
            }
            else if (String.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxDiachi.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, "^[0-9]*$"))
            {
                MessageBox.Show("Sđt bệnh nhân không hợp lệ!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxSdt.Focus();
            }
            else if (bhyt.Length > 15)
            {
                MessageBox.Show("Bảo hiểm y tế không hợp lệ. Vui lòng nhập lại!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxBHYT.Focus();

            }
            else
            {
                //Check nếu Bảo hiểm y tế không nhập thì có nghĩa là không có bảo hiểm y tế
                if (String.IsNullOrEmpty(bhyt))
                {
                    bhyt = "Không có";
                }


                //Khởi tạo kết nối Sql Server
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();

                //Khởi tạo lệnh thêm thông tin bệnh nhân vào Sql Server
                command.CommandText = "Insert into tBenhNhan(tenBN,tuoi,gioitinh,nghenghiep,diachi,sdt,trieuchung,bhyt,phong,bacsikham,ngaykham) values(@tenBN,@tuoi,@gt,@nn,@dc,@sdt,@tchung,@bhyt,@phong,@bskham,@ngaykham) SELECT SCOPE_IDENTITY();";

                //Gán từng dữ liệu vào biến trong câu lệnh để thêm vào hệ thốn.g
                command.Parameters.AddWithValue("@tenBN", tenBN);
                command.Parameters.AddWithValue("@tuoi", tuoi);
                command.Parameters.AddWithValue("@gt", gt);
                command.Parameters.AddWithValue("@nn", nghenghiep);
                command.Parameters.AddWithValue("@dc", diachi);
                command.Parameters.AddWithValue("@sdt", sdt);
                command.Parameters.AddWithValue("@tchung", trieuchung);
                command.Parameters.AddWithValue("@bhyt", bhyt);
                command.Parameters.AddWithValue("@phong", phong.Substring(0, 4));
                command.Parameters.AddWithValue("@bskham", bacsikham.Substring(0, boxBacsi.Text.Length - 6));
                command.Parameters.AddWithValue("@ngaykham", ngaykham);

                //Lấy ID bệnh nhân sau khi thêm vào hệ thống
                int ID = Convert.ToInt32(command.ExecuteScalar());

                con.Close();
                // Thêm thông tin bệnh nhân mới vào bảng datagridview1
                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = ID.ToString();
                dataGridView1.Rows[tmp].Cells[1].Value = tenBN;
                dataGridView1.Rows[tmp].Cells[2].Value = gt;
                dataGridView1.Rows[tmp].Cells[3].Value = diachi;
                dataGridView1.Rows[tmp].Cells[4].Value = sdt;
                dataGridView1.Rows[tmp].Cells[5].Value = trieuchung;
                dataGridView1.Rows[tmp].Cells[6].Value = bacsikham;
                dataGridView1.Rows[tmp].Cells[7].Value = ngaykham;
                dataGridView1.Rows[tmp].Cells[8].Value = nghenghiep;
                dataGridView1.Rows[tmp].Cells[9].Value = tuoi;
                dataGridView1.Rows[tmp].Cells[10].Value = bhyt;
                dataGridView1.Rows[tmp].Cells[11].Value = phong;

                tmp++;
                /*-----------------------------*/

                boxMaBN.Text = "";
                boxTenBN.Text = "";
                boxNghenghiep.Text = "";
                boxBacsi.Text = "";
                boxTuoi.Text = "";
                radioNam.Checked = false;
                radioNu.Checked = false;
                boxSdt.Text = "";
                boxTuoi.Text = "";
                boxBacsi.Text = "";
                boxDiachi.Text = "";
                boxTrieuchung.Text = "";
                boxBHYT.Text = "";
                boxPhong.Text = "";
                MessageBox.Show("Thêm bệnh nhân mới thành công !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*-----------------------------*/

                //Thêm thông tin bệnh nhân mới vào bảng search. bảng datagridview2.
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = tenBN;
                dataGridView2.Rows[count].Cells[1].Value = tuoi;
                dataGridView2.Rows[count].Cells[2].Value = diachi;
                count++;
                /*-----------------------------*/

                //In phieu kham benh
                frmPhieuKhamBenh frmBN = new frmPhieuKhamBenh(ID.ToString());
                frmBN.Size = new Size(870, 880);
                frmBN.Show();
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }


        //Hàm dùng để lấy thông tin bệnh nhân từ datagridview đổ vào textbox thông tin bệnh nhân
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Nếu thông tin được click vào không phải headerText của datagridview
            if (e.RowIndex >= 0)
            {

                //Khởi tạo biến lưu giữ liệu từ datagridview đã chọn
                String maBN = dataGridView1.Rows[e.RowIndex].Cells["txtMaso"].FormattedValue.ToString();
                String hovaten = dataGridView1.Rows[e.RowIndex].Cells["txtTenBN"].FormattedValue.ToString();
                String tuoi = dataGridView1.Rows[e.RowIndex].Cells["txtTuoir"].FormattedValue.ToString();
                String nghenghiep = dataGridView1.Rows[e.RowIndex].Cells["txtNghenghiep"].FormattedValue.ToString();
                String diachi = dataGridView1.Rows[e.RowIndex].Cells["txtDiachi"].FormattedValue.ToString();
                String sdt = dataGridView1.Rows[e.RowIndex].Cells["txtSdt"].FormattedValue.ToString();
                String trieuchung = dataGridView1.Rows[e.RowIndex].Cells["txtTrieuchung"].FormattedValue.ToString();
                String bacsikham = dataGridView1.Rows[e.RowIndex].Cells["txtBacsi"].FormattedValue.ToString();
                String ngaykham = dataGridView1.Rows[e.RowIndex].Cells["txtNgaykham"].FormattedValue.ToString();
                String bhyt = dataGridView1.Rows[e.RowIndex].Cells["txtBHYT"].FormattedValue.ToString();
                String phong = dataGridView1.Rows[e.RowIndex].Cells["txtPhong"].FormattedValue.ToString();
                String bacsyListview = dataGridView1.Rows[e.RowIndex].Cells["bacsilistview"].FormattedValue.ToString();

                //Gán dữ liệu đã chọn từ datagridview vào các textbox thông tin bệnh nhân.
                boxMaBN.Text = maBN;
                boxMaBN.ReadOnly = true;
                boxTenBN.Text = hovaten;
                boxNghenghiep.Text = nghenghiep;
                boxSdt.Text = sdt.Trim();
                boxTuoi.Text = tuoi;

                //Load thông tin bác sỹ khi chọn từ datagridview khi chứa ID bác sỹ.
                
                foreach (object item in boxBacsi.Items)
                {
                    if (item.ToString().Contains(bacsikham))
                    {
                        boxBacsi.Text = item.ToString();
                        break;
                    }
                }
                //Gán dữ liệu đã chọn từ datagridview vào các textbox thông tin bệnh nhân.
                boxDiachi.Text = diachi;
                boxTrieuchung.Text = trieuchung;
                boxBHYT.Text = bhyt;
                boxPhong.Text = phong;
                int check_day = 0;

                //Kiểm tra format thông tin datetimepicker để lấy dữ liệu
                foreach (char i in ngaykham)
                {
                    if (i == Char.Parse("/"))
                    {
                        break;
                    }
                    check_day++;
                }

                //Thêm datetimepicker thep đúng format dd/MM/year
                if (check_day == 1)
                {
                    ngaykham = "0" + ngaykham;
                }

                //Lấy ngày tháng năm từ thông tin ngày tạo từ datagridview
                String month = ngaykham.Substring(0, 2);
                String day = ngaykham.Substring(3, 2);
                String year = ngaykham.Substring(6, 4);

                //04/23/2022 8:39:35 PM
                dateTimePicker1.Value = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));

                String gioitinh = dataGridView1.Rows[e.RowIndex].Cells["txtGioitinh"].FormattedValue.ToString();
                String gt = Regex.Replace(gioitinh, @"\s+", "");
                //Nếu giới tính chọn từ datagridview thì chọn theo đúng giới tính.
                if (gt.Equals("Nam"))
                {
                    radioNam.Checked = true;
                }
                else
                {
                    radioNu.Checked = true;
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                /*-Clear những thông tin trên thanh nhập*/
                boxMaBN.Text = "";
                boxTenBN.Text = "";
                boxNghenghiep.Text = "";
                boxBacsi.Text = "";
                boxTuoi.Text = "";
                radioNam.Checked = false;
                radioNu.Checked = false;
                boxSdt.Text = "";
                boxTuoi.Text = "";
                boxBacsi.Text = "";
                boxDiachi.Text = "";
                boxTrieuchung.Text = "";
                boxBHYT.Text = "";
                boxPhong.Text = "";
                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                /*-----------------------------*/
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            /*Clear thông tin trên form search*/
            searchHoten.Text = "";
            searchTuoi.Text = "";
            searchDiachi.Text = "";
            /*-----------------------------*/
        }

        private void searchHoten_TextChanged(object sender, EventArgs e)
        {
            updateList(searchHoten.Text);
        }

        public void updateList(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.CommandText = "SELECT tenBN,tuoi,diachi  FROM dbo.tBenhNhan WHERE (tenBN LIKE @query OR tuoi LIKE @query or diachi LIKE @query)";
            command.Parameters.AddWithValue("@query", "%" + query + "%");

            SqlDataReader reader = command.ExecuteReader();
            dataGridView2.Rows.Clear();
            int count = 0;
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

        //Hàm xóa thông tin bệnh nhân từ việc chọn thông tin từ datagridview
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Hiển thị thông báo kiểm tra người dùng có thật sự muốn xóa thông tin người dùng.
            if (MessageBox.Show("Muốn xóa bệnh nhân có mã BN: " + boxMaBN.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Khởi tạo kết nối và tạo câu lệnh query để xóa bệnh nhân trong hệ thồng Sql
                cnn = new SqlConnection(Properties.Resources.connectString);

                //Lấy mã Nhân viên cần xóa trong hệ thống.
                String maBN = boxMaBN.Text;
                SqlCommand command = cnn.CreateCommand();
                cnn.Open();
                
                //Câu lệnh dùng để xóa thông tin bệnh nhân trong hệ thống.
                command.CommandText = "DELETE FROM dbo.tBenhNhan where maBN=" + maBN;
                command.ExecuteNonQuery();
                

                //thông báo xóa thông tin bệnh nhân thành công !!
                MessageBox.Show("Xóa bệnh nhân có mã: " + maBN + " thành công !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Các biến lưu trũ vị trí dữ liệu trong bảng datagridview bị giảm đi.
                tmp--;
                count--;


                //Xóa thông tin bệnh nhân chứa trong bảng datagridview.
                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }

                //Xóa thông tin bệnh nhân chứa trong bảng datagridview tìm kiếm.
                foreach (DataGridViewRow oneCell in dataGridView2.Rows)
                {
                    if (oneCell.Cells[0].Value.ToString() == boxTenBN.Text)
                    {
                        dataGridView2.Rows.RemoveAt(oneCell.Index);

                    }
                }

                //Clear các thông tin trên textbox của chứa thông tin bệnh nhân cần xóa.
                boxMaBN.Text = "";
                boxTenBN.Text = "";
                boxNghenghiep.Text = "";
                boxBacsi.Text = "";
                boxTuoi.Text = "";
                radioNam.Checked = false;
                radioNu.Checked = false;
                boxSdt.Text = "";
                boxTuoi.Text = "";
                boxBacsi.Text = "";
                boxDiachi.Text = "";
                boxTrieuchung.Text = "";
                boxBHYT.Text = "";
                boxPhong.Text = "";
            }
        }

        private void boxMaBN_TextChanged(object sender, EventArgs e)
        {

            //Unable button delete nếu ko tồn tại dữ liệu maBN.

            if (String.IsNullOrEmpty(boxMaBN.Text))
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

            /*--------------*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Tạo biến lưu trữ thông tin của các textbox
            String tenBN, nghenghiep, diachi, sdt, trieuchung, bacsikham, tuoi, ngaykham, maBN, bhyt;
            String gt = "";

            maBN = boxMaBN.Text;
            tenBN = boxTenBN.Text;
            tuoi = boxTuoi.Text;
            nghenghiep = boxNghenghiep.Text;
            diachi = boxDiachi.Text;
            sdt = boxSdt.Text;
            trieuchung = boxTrieuchung.Text;
            bacsikham = boxBacsi.Text;
            ngaykham = dateTimePicker1.Value.ToString();
            bhyt = boxBHYT.Text;

            //Tạo các biến kiểm tra điều để sửa thông tin bệnh nhân.
            Regex regex = new Regex(@"^\d$");
            bool tenBN_containsNum = Regex.IsMatch(tenBN, @"\d");
            bool tuoi_containsNum = Regex.IsMatch(tuoi, @"\d");


            //Các if dùng để kiểm tra thông tin bệnh nhân sửa có hợp lệ hay không !
            if (String.IsNullOrEmpty(tenBN))
            {
                MessageBox.Show("Tên bệnh nhân không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTenBN.Focus();

            }
            else if (tenBN_containsNum)
            {
                MessageBox.Show("Tên bệnh nhân không được phép chứa số kí tự!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTenBN.Focus();

            }
            else if (String.IsNullOrEmpty(boxTuoi.Text))
            {
                MessageBox.Show("Tuổi bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (!tuoi_containsNum)
            {
                MessageBox.Show("Tuổi bệnh nhân không được chứa kí tự!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (Int32.Parse(tuoi) < 0 || Int32.Parse(tuoi) > 100)
            {
                MessageBox.Show("Tuổi bệnh nhân phải nằm trong khoảng 1 -> 100!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTuoi.Focus();
            }
            else if (radioNam.Checked == false && radioNu.Checked == false)
            {
                MessageBox.Show("Giới tính bệnh nhân chưa có !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioNam.Focus();
            }
            else if (String.IsNullOrEmpty(bacsikham))
            {
                MessageBox.Show("Chưa chọn bác sĩ khám cho bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxBacsi.Focus();
            }
            else if (String.IsNullOrEmpty(trieuchung))
            {
                MessageBox.Show("Chưa điền triệu chứng cho bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxTrieuchung.Focus();
            }
            else if (String.IsNullOrEmpty(nghenghiep))
            {
                MessageBox.Show("Nghề nghiệp bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxNghenghiep.Focus();
            }
            else if (String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Sđt bệnh nhân không được phép để trống !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxSdt.Focus();
            }
            else if (String.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Địa chỉ bệnh nhân không được phép để trống!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxDiachi.Focus();
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, "^[0-9]*$"))
            {
                MessageBox.Show("Sđt bệnh nhân không hợp lệ!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxSdt.Focus();
            }
            else if (bhyt.Length > 15)
            {
                MessageBox.Show("Bảo hiểm y tế không hợp lệ. Vui lòng nhập lại!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                boxBHYT.Focus();

            }
            else
            {
                //Lấy thông tin theo giới tính chọn của bệnh nhân
                if (radioNam.Checked.Equals(true))
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";

                }

                //Thông báo cho người dùng có muốn sửa thông tin bệnh nhân hay không ?
                if (MessageBox.Show("Bạn có muốn sửa bệnh nhân có mã BN: " + boxMaBN.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    //Khởi tạo câu lệnh update thông tin bệnh nhân trong hệ thống !!
                    command.CommandText = "Update dbo.tBenhNhan set tenBN = @tenBN,tuoi=@tuoi,gioitinh=@gt,nghenghiep=@nn,diachi=@dc,sdt=@sdt,trieuchung=@tchung,bacsikham=@bskham,ngaykham=@ngaykham where maBN=@mabn";
                    command.Parameters.AddWithValue("@tenBN", tenBN);
                    command.Parameters.AddWithValue("@tuoi", tuoi);
                    command.Parameters.AddWithValue("@gt", gt);
                    command.Parameters.AddWithValue("@nn", nghenghiep);
                    command.Parameters.AddWithValue("@dc", diachi);
                    command.Parameters.AddWithValue("@sdt", sdt);
                    command.Parameters.AddWithValue("@tchung", trieuchung);
                    command.Parameters.AddWithValue("@bskham", bacsikham);
                    command.Parameters.AddWithValue("@ngaykham", ngaykham);
                    command.Parameters.AddWithValue("@mabn", maBN);

                    command.ExecuteNonQuery();

                    con.Close();

                    //// Thêm thông tin bệnh nhân mới vào bảng datagridview1
                    dataGridView2.Rows.Clear();
                    dataGridView1.Rows.Clear();
                    tmp = 0;
                    count = 0;
                    loadData();
                    MessageBox.Show("Sửa thông tin bệnh nhân thành công!!!","THÔNG BÁO",MessageBoxButtons.OK);
                    ///*-----------------------------*/

                }

            }
        }

        private void boxBacsi_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            //Chọn thông tin bác sỹ thì phòng theo bác sỹ sẽ được chọn theo.
            if (!String.IsNullOrEmpty(boxBacsi.SelectedItem.ToString()))
            {
                //Lấy ID từ việc chọn thông tin bác sỹ
                String id = boxBacsi.SelectedItem.ToString().Substring(boxBacsi.SelectedItem.ToString().Length - 4, 4);
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                
                //Câu lệnh query để chọn dữ liệu khoa theo id nhân viên để lấy sophongkhoa
                command.CommandText = "Select * from dbo.tKhoa  where sophongkhoa = (select sophongkhoa from dbo.hosonhanvien where idnhanvien = '"+id+"')";
              
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "phong");

                //Đổ dữ liệu khi chọn thông tin bác sỹ
                foreach (DataRow row in ds.Tables["phong"].Rows)
                {
                    boxPhong.Text = row["sophongkhoa"].ToString();
                }
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNộiTrúToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void quảnLýThuốcToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            
        }

        private void QuanLyBenhNhan_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchDiachi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
