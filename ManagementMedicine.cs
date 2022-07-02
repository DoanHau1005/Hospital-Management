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
    public partial class ManagementMedicine : Form
    {

        //Khởi tạo biến kết nối Sql
        String connect_str = Properties.Resources.connectString;
        SqlConnection cnn;
        int pos_gridview = 0;
        int pos_searchgridview = 0;


        int account_id;
        public ManagementMedicine(int account)
        {
            InitializeComponent();
            this.account_id = account;
            cnn = new SqlConnection(connect_str);

            //Load thông tin thuốc vào datagridview
            loadThuoc();


            //Load thông tin thuốc vào datagridview Search
            loadSearchThuoc();
            foreach (DataGridViewColumn c in dataGridView2.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            }
        }
        private void loadThuoc()
        {

            
            SqlDataReader reader;
            cnn.Open();
            SqlCommand command = cnn.CreateCommand();
            command.CommandText = "Select * from dbo.Thuoc";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                //Khởi tạo lưu trữ thông tin thuốc

                string maThuoc = reader[0].ToString();
                string tenthuoc = reader[1].ToString();
                string nhomthuoc = reader[2].ToString();
                string donvitinh = reader[3].ToString();
                string hamluong = reader[4].ToString();
                string cachdung = reader[5].ToString();
                string soluong = reader[6].ToString();
                string ncc = reader[7].ToString();
                string ghichu = reader[8].ToString();
                string dongia = reader[9].ToString();

                //Khởi tạo lưu trữ thông tin thuốc
                dataGridView1.Rows.Add();
                dataGridView1.Rows[pos_gridview].Cells[0].Value = maThuoc;
                dataGridView1.Rows[pos_gridview].Cells[1].Value = tenthuoc;
                dataGridView1.Rows[pos_gridview].Cells[2].Value = nhomthuoc;
                dataGridView1.Rows[pos_gridview].Cells[3].Value = donvitinh;
                dataGridView1.Rows[pos_gridview].Cells[4].Value = hamluong;
                dataGridView1.Rows[pos_gridview].Cells[5].Value = cachdung;
                dataGridView1.Rows[pos_gridview].Cells[6].Value = soluong;
                dataGridView1.Rows[pos_gridview].Cells[7].Value = ncc;
                dataGridView1.Rows[pos_gridview].Cells[8].Value = ghichu;
                dataGridView1.Rows[pos_gridview].Cells[9].Value = dongia;
                pos_gridview++;
            }
            cnn.Close();
        }

        //Hàm load thông tin datagridview Search thuoc
        private void loadSearchThuoc()
        {
            SqlDataReader reader;
            cnn.Open();
            SqlCommand command = cnn.CreateCommand();
            
            //query thông tin thuốc
            command.CommandText = "Select * from dbo.Thuoc";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maThuoc = reader[0].ToString();
                string tenthuoc = reader[1].ToString();
                string nhomthuoc = reader[2].ToString();

                dataGridView2.Rows.Add();
                dataGridView2.Rows[pos_searchgridview].Cells[0].Value = maThuoc;
                dataGridView2.Rows[pos_searchgridview].Cells[1].Value = tenthuoc;
                dataGridView2.Rows[pos_searchgridview].Cells[2].Value = nhomthuoc;
                pos_searchgridview++;
            }

            cnn.Close();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            //Xóa thông tin đã chọn từ datagridview
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            //Tạo dự đoán thông tin nhập vào
            tenThuocComplet(boxTenthuoc.Text);
            nhomThuocComplete(boxNhomthuoc.Text);
            nccComplete(boxNcc.Text);
            hamLuongComplete(boxHamluong.Text);

            //Modify các nút nếu mã thuốc ko tồn tại thì các nút xóa và sửa ko được phép click
            if (String.IsNullOrEmpty(boxMaThuoc.Text))
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
            }
        }



        private void ManagementMedicine_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }

        private void ManagementMedicine_Load_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn thông tin từ datagridview 
            if (e.RowIndex >= 0)
            {
                //Khởi tạo biến lưu dữ liệu thuốc
                String maThuoc, tenthuoc, nhomthuoc, donvitinh, hamluong, cachdung, soluong, ncc, ghichu, dongia;

                maThuoc = dataGridView1.Rows[e.RowIndex].Cells["gridMathuoc"].FormattedValue.ToString();
                tenthuoc = dataGridView1.Rows[e.RowIndex].Cells["gridTenthuoc"].FormattedValue.ToString();
                nhomthuoc = dataGridView1.Rows[e.RowIndex].Cells["gridNhomthuoc"].FormattedValue.ToString();
                donvitinh = dataGridView1.Rows[e.RowIndex].Cells["gridDonvitinh"].FormattedValue.ToString();
                hamluong = dataGridView1.Rows[e.RowIndex].Cells["gridHamluong"].FormattedValue.ToString();
                cachdung = dataGridView1.Rows[e.RowIndex].Cells["gridCachdung"].FormattedValue.ToString();
                soluong = dataGridView1.Rows[e.RowIndex].Cells["gridSoluong"].FormattedValue.ToString();
                ncc = dataGridView1.Rows[e.RowIndex].Cells["gridNcc"].FormattedValue.ToString();
                ghichu = dataGridView1.Rows[e.RowIndex].Cells["gridGhichu"].FormattedValue.ToString();
                dongia = dataGridView1.Rows[e.RowIndex].Cells["gridDongia"].FormattedValue.ToString();



                //Load dữ liệu thuốc vào các textbox
                boxMaThuoc.Text = maThuoc;
                boxTenthuoc.Text = tenthuoc;
                boxNhomthuoc.Text = nhomthuoc;
                listDonvi.Text = donvitinh;
                boxHamluong.Text = hamluong;
                boxCachdung.Text = cachdung;
                boxSoluong.Text = soluong;
                boxNcc.Text = ncc;
                boxGhichu.Text = ghichu;
                boxDongia.Text = dongia;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            boxMaThuoc.Text = "";
            boxSoluong.Text = "";
            boxTenthuoc.Text = "";
            boxNhomthuoc.Text = "";
            boxCachdung.Text = "";
            boxCachdung.ClearSelected();
            boxHamluong.Text = "";
            boxDongia.Text = "";
            listDonvi.Text = "";
            listDonvi.ClearSelected();
            boxNcc.Text = "";
            boxGhichu.Text = "";
            dataGridView1.ClearSelection();
        }

        private void boxMaThuoc_TextChanged(object sender, EventArgs e)
        {
            //Enabled and Disabled các nút trong hệ thống thông tin
            if (String.IsNullOrEmpty(boxMaThuoc.Text))
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

        private void iconButton4_Click(object sender, EventArgs e)
        {
            searchMaThuoc.Text = "";
            searchTenthuoc.Text = "";
            searchNhomthuoc.Text = "";
            dataGridView2.ClearSelection();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                String maThuoc, tenthuoc, nhomthuoc;

                maThuoc = dataGridView2.Rows[e.RowIndex].Cells["txtMathuoc"].FormattedValue.ToString();
                tenthuoc = dataGridView2.Rows[e.RowIndex].Cells["txtTenthuoc"].FormattedValue.ToString();
                nhomthuoc = dataGridView2.Rows[e.RowIndex].Cells["txtNhomThuoc"].FormattedValue.ToString();


                searchMaThuoc.Text = maThuoc;


            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked!!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String maThuoc, tenthuoc, nhomthuoc, donvitinh, hamluong, cachdung, soluong, ncc, ghichu, dongia;
            maThuoc = boxMaThuoc.Text;
            tenthuoc = boxTenthuoc.Text;
            nhomthuoc = boxNhomthuoc.Text;
            donvitinh = listDonvi.Text;
            hamluong = boxHamluong.Text;
            cachdung = boxCachdung.Text;
            soluong = boxSoluong.Text;
            ncc = boxNcc.Text;
            ghichu = boxGhichu.Text;
            dongia = boxDongia.Text;

            bool soluong_containsNum = Regex.IsMatch(soluong, @"\bhi\b");
            bool donvitinh_containsNum = Regex.IsMatch(donvitinh, @"\d");
            bool dongia_containsNum = Regex.IsMatch(dongia, @"\d");

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (String.IsNullOrEmpty(tenthuoc))
            {
                MessageBox.Show("Tên thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxTenthuoc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Số lượng thuốc chưa được điền !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxSoluong.Focus();
                return;
            }
            else if (!IsDigitsOnly(soluong))
            {
                MessageBox.Show("Số lượng thuốc nhập chưa phù hợp !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxSoluong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(nhomthuoc))
            {
                MessageBox.Show("Nhóm thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxNhomthuoc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cachdung))
            {
                MessageBox.Show("Chưa chọn cách dùng thuốc !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxCachdung.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(hamluong))
            {
                MessageBox.Show("Hàm lượng thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxHamluong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(donvitinh))
            {
                MessageBox.Show("Đơn vị tính không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                listDonvi.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(ncc))
            {
                MessageBox.Show("Chưa có nhà cung cấp !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxNcc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(dongia))
            {
                MessageBox.Show("Đơn giá chưa được điền !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxDongia.Focus();
                return;
            }
            else if (!dongia_containsNum)
            {
                MessageBox.Show("Đơn giá không hợp lệ !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxDongia.Focus();
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "Insert into dbo.Thuoc(tenThuoc,nhomThuoc,donvi,hamluong,cachdung,soluong,ncc,ghichu,dongia) values(@tenThuoc,@nhomThuoc,@donvi,@hamluong,@cachdung,@soluong,@ncc,@ghichu,@dongia) SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@tenThuoc", tenthuoc);
                command.Parameters.AddWithValue("@nhomThuoc", nhomthuoc);
                command.Parameters.AddWithValue("@donvi", donvitinh);
                command.Parameters.AddWithValue("@hamluong", hamluong);
                command.Parameters.AddWithValue("@cachdung", cachdung);
                command.Parameters.AddWithValue("@soluong", soluong);
                command.Parameters.AddWithValue("@ncc", ncc);
                command.Parameters.AddWithValue("@ghichu", ghichu);
                command.Parameters.AddWithValue("@dongia", dongia);

                int ID = Convert.ToInt32(command.ExecuteScalar());

                con.Close();
                MessageBox.Show("Thêm thông tin thuốc thành công !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Information);

                // Thêm thông tin bệnh nhân mới vào bảng datagridview1
                dataGridView1.Rows.Add();
                dataGridView1.Rows[pos_gridview].Cells[0].Value = ID.ToString();
                dataGridView1.Rows[pos_gridview].Cells[1].Value = tenthuoc;
                dataGridView1.Rows[pos_gridview].Cells[2].Value = nhomthuoc;
                dataGridView1.Rows[pos_gridview].Cells[3].Value = donvitinh;
                dataGridView1.Rows[pos_gridview].Cells[4].Value = hamluong;
                dataGridView1.Rows[pos_gridview].Cells[5].Value = cachdung;
                dataGridView1.Rows[pos_gridview].Cells[6].Value = soluong;
                dataGridView1.Rows[pos_gridview].Cells[7].Value = ncc;
                dataGridView1.Rows[pos_gridview].Cells[8].Value = ghichu;
                dataGridView1.Rows[pos_gridview].Cells[9].Value = dongia;

                pos_gridview++;

                /*-----------------------------*/

                //Thêm thông tin bệnh nhân mới vào bảng search. bảng datagridview2.
                dataGridView2.Rows.Add();
                dataGridView2.Rows[pos_searchgridview].Cells[0].Value = ID;
                dataGridView2.Rows[pos_searchgridview].Cells[1].Value = tenthuoc;
                dataGridView2.Rows[pos_searchgridview].Cells[2].Value = nhomthuoc;
                pos_searchgridview++;
                /*-----------------------------*/

            }
        }
        public void tenThuocComplet(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Select tenThuoc,hamluong,ncc from dbo.Thuoc";
            SqlDataReader sdr = command.ExecuteReader();
            AutoCompleteStringCollection autotext_TenThuoc = new AutoCompleteStringCollection();
            //AutoCompleteStringCollection autotext_Hamluong = new AutoCompleteStringCollection();
            //AutoCompleteStringCollection autotext_Ncc = new AutoCompleteStringCollection();

            while (sdr.Read())
            {
                autotext_TenThuoc.Add(sdr.GetString(0));
                //autotext_Hamluong.Add(sdr.GetString(1));
                //autotext_TenThuoc.Add(sdr.GetString(2));
            }
            //Thêm dữ liệu dự đoán vào Textbox - Tên thuốc.
            boxTenthuoc.AutoCompleteCustomSource = autotext_TenThuoc;
            boxTenthuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            boxTenthuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            /*---------------------------*/

        }

        public void nhomThuocComplete(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Select nhomThuoc from dbo.Thuoc";
            SqlDataReader sdr = command.ExecuteReader();
            AutoCompleteStringCollection autotext_nhomThuoc = new AutoCompleteStringCollection();

            while (sdr.Read())
            {
                autotext_nhomThuoc.Add(sdr.GetString(0));
            }
            //Thêm dữ liệu dự đoán vào Textbox - Nhóm thuốc.
            boxNhomthuoc.AutoCompleteCustomSource = autotext_nhomThuoc;
            boxNhomthuoc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            boxNhomthuoc.AutoCompleteMode = AutoCompleteMode.Suggest;
            /*---------------------------*/
        }

        public void hamLuongComplete(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Select hamluong from dbo.Thuoc";
            SqlDataReader sdr = command.ExecuteReader();
            AutoCompleteStringCollection autotext_hamLuong = new AutoCompleteStringCollection();

            while (sdr.Read())
            {
                autotext_hamLuong.Add(sdr.GetString(0));
            }
            //Thêm dữ liệu dự đoán vào Textbox - Hàm lượng thuốc.
            boxHamluong.AutoCompleteCustomSource = autotext_hamLuong;
            boxHamluong.AutoCompleteSource = AutoCompleteSource.CustomSource;
            boxHamluong.AutoCompleteMode = AutoCompleteMode.Suggest;
            /*---------------------------*/
        }


        public void nccComplete(String query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Select ncc from dbo.Thuoc";
            SqlDataReader sdr = command.ExecuteReader();
            AutoCompleteStringCollection autotext_ncc = new AutoCompleteStringCollection();

            while (sdr.Read())
            {
                autotext_ncc.Add(sdr.GetString(0));
            }
            //Thêm dữ liệu dự đoán vào Textbox - Nhà cung cấp thuốc.
            boxNcc.AutoCompleteCustomSource = autotext_ncc;
            boxNcc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            boxNcc.AutoCompleteMode = AutoCompleteMode.Suggest;
            /*---------------------------*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Muốn xóa thuốc có mã: " + boxMaThuoc.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                cnn = new SqlConnection(Properties.Resources.connectString);
                String maThuoc = boxMaThuoc.Text;
                SqlCommand command = cnn.CreateCommand();
                cnn.Open();
                command.CommandText = "DELETE FROM dbo.Thuoc where ID=" + maThuoc;
                command.ExecuteNonQuery();
                //MessageBox.Show("Xóa bệnh nhân có mã: " + maThuoc + " thành công !!!");
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                pos_gridview--;
                pos_searchgridview--;

                foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                    }
                }

                foreach (DataGridViewRow oneCell in dataGridView2.Rows)
                {
                    //MessageBox.Show(oneCell.Cells[0].Value.ToString());
                    if (oneCell.Cells[0].Value.ToString() == boxMaThuoc.Text)
                    {
                        dataGridView2.Rows.RemoveAt(oneCell.Index);
                        //MessageBox.Show(oneCell.Index.ToString());

                    }
                }
                MessageBox.Show("Xóa thuốc có mã: " + maThuoc + " thành công !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Information);
                boxMaThuoc.Text = "";
                boxSoluong.Text = "";
                boxTenthuoc.Text = "";
                boxNhomthuoc.Text = "";
                boxCachdung.Text = "";
                boxCachdung.ClearSelected();
                boxHamluong.Text = "";
                boxDongia.Text = "";
                listDonvi.Text = "";
                listDonvi.ClearSelected();
                boxNcc.Text = "";
                boxGhichu.Text = "";
                dataGridView1.ClearSelection();
            }

        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String maThuoc, tenthuoc, nhomthuoc, donvitinh, hamluong, cachdung, soluong, ncc, ghichu, dongia;
            maThuoc = boxMaThuoc.Text;
            tenthuoc = boxTenthuoc.Text;
            nhomthuoc = boxNhomthuoc.Text;
            donvitinh = listDonvi.Text;
            hamluong = boxHamluong.Text;
            cachdung = boxCachdung.Text;
            soluong = boxSoluong.Text;
            ncc = boxNcc.Text;
            ghichu = boxGhichu.Text;
            dongia = boxDongia.Text;

            bool soluong_containsNum = Regex.IsMatch(soluong, @"\bhi\b");
            bool donvitinh_containsNum = Regex.IsMatch(donvitinh, @"\d");
            bool dongia_containsNum = Regex.IsMatch(dongia, @"\d");

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (String.IsNullOrEmpty(tenthuoc))
            {
                MessageBox.Show("Tên thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxTenthuoc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Số lượng thuốc chưa được điền !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxSoluong.Focus();
                return;
            }
            else if (!IsDigitsOnly(soluong))
            {
                MessageBox.Show("Số lượng thuốc nhập chưa phù hợp !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxSoluong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(nhomthuoc))
            {
                MessageBox.Show("Nhóm thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxNhomthuoc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cachdung))
            {
                MessageBox.Show("Chưa chọn cách dùng thuốc !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxCachdung.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(hamluong))
            {
                MessageBox.Show("Hàm lượng thuốc không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxHamluong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(donvitinh))
            {
                MessageBox.Show("Đơn vị tính không được phép để trống !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                listDonvi.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(ncc))
            {
                MessageBox.Show("Chưa có nhà cung cấp !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxNcc.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(dongia))
            {
                MessageBox.Show("Đơn giá chưa được điền !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxDongia.Focus();
                return;
            }
            else if (!dongia_containsNum)
            {
                MessageBox.Show("Đơn giá không hợp lệ !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                boxDongia.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa thuốc có mã: " + boxMaThuoc.Text + " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection(Properties.Resources.connectString);
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    command.CommandText = "Update dbo.Thuoc set tenThuoc = @tenThuoc,nhomThuoc = @nhomThuoc ,donvi = @donvi ,hamluong = @hamluong ,cachdung = @cachdung ,soluong = @soluong ,ncc = @ncc ,ghichu = @ghichu ,dongia = @dongia where ID= @mathuoc";
                    command.Parameters.AddWithValue("@tenThuoc", tenthuoc);
                    command.Parameters.AddWithValue("@nhomThuoc", nhomthuoc);
                    command.Parameters.AddWithValue("@donvi", donvitinh);
                    command.Parameters.AddWithValue("@hamluong", hamluong);
                    command.Parameters.AddWithValue("@cachdung", cachdung);
                    command.Parameters.AddWithValue("@soluong", soluong);
                    command.Parameters.AddWithValue("@ncc", ncc);
                    command.Parameters.AddWithValue("@ghichu", ghichu);
                    command.Parameters.AddWithValue("@dongia", dongia);
                    command.Parameters.AddWithValue("@maThuoc", maThuoc);


                    command.ExecuteNonQuery();

                    con.Close();

                    dataGridView2.Rows.Clear();
                    dataGridView1.Rows.Clear();

                    pos_gridview = 0;
                    pos_searchgridview = 0;

                    loadThuoc();
                    loadSearchThuoc();


                    MessageBox.Show("Cập nhật thông tin thuốc thành công !!!", "THÔNG BÁO", buttons, MessageBoxIcon.Information);
                }

            }

        }

        private void searchMaThuoc_TextChanged(object sender, EventArgs e)
        {
            updateSearchList(searchMaThuoc.Text, searchTenthuoc.Text, searchNhomthuoc.Text);
        }

        String query = "";
        public void updateSearchList(String maThuoc, String tenThuoc, String nhomThuoc)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            query = "";

            /*TH1: Có 1 trong 3 ô textbox Search được điền.*/
            if (!String.IsNullOrEmpty(maThuoc) && String.IsNullOrEmpty(nhomThuoc) && String.IsNullOrEmpty(tenThuoc))
            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE ID LIKE @query";
                command.CommandText = query;
                command.Parameters.AddWithValue("@query", "%" + maThuoc + "%");
            }
            if (String.IsNullOrEmpty(maThuoc) && !String.IsNullOrEmpty(nhomThuoc) && String.IsNullOrEmpty(tenThuoc))

            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE nhomThuoc LIKE @query";
                command.CommandText = query;
                command.Parameters.AddWithValue("@query", "%" + nhomThuoc + "%");
            }
            if (String.IsNullOrEmpty(maThuoc) && String.IsNullOrEmpty(nhomThuoc) && !String.IsNullOrEmpty(tenThuoc))

            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE tenThuoc Like @query";
                command.CommandText = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE tenThuoc Like @query";
                command.Parameters.AddWithValue("@query", "%" + tenThuoc + "%");
            }
            /*--------------------------------------------*/


            /*TH2: Có 2 trong 3 ô textbox Search được điền.*/
            if (!String.IsNullOrEmpty(maThuoc) && !String.IsNullOrEmpty(nhomThuoc) && String.IsNullOrEmpty(tenThuoc))
            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE (ID LIKE @maThuoc and nhomThuoc LIKE @nhomThuoc)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@maThuoc", "%" + maThuoc + "%");
                command.Parameters.AddWithValue("@nhomThuoc", "%" + nhomThuoc + "%");

            }
            if (!String.IsNullOrEmpty(maThuoc) && String.IsNullOrEmpty(nhomThuoc) && !String.IsNullOrEmpty(tenThuoc))

            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE (ID LIKE @maThuoc and tenThuoc LIKE @tenThuoc)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@maThuoc", "%" + maThuoc + "%");
                command.Parameters.AddWithValue("@tenThuoc", "%" + tenThuoc + "%");

            }
            if (String.IsNullOrEmpty(maThuoc) && !String.IsNullOrEmpty(nhomThuoc) && !String.IsNullOrEmpty(tenThuoc))

            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE (nhomThuoc LIKE @nhomThuoc and tenThuoc LIKE @tenThuoc)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@nhomThuoc", "%" + nhomThuoc + "%");
                command.Parameters.AddWithValue("@tenThuoc", "%" + tenThuoc + "%");
            }
            /*--------------------------------------------*/

            /*TH3: Các 3 ô textbox Search đều được điền  */
            if (!String.IsNullOrEmpty(maThuoc) && !String.IsNullOrEmpty(nhomThuoc) && !String.IsNullOrEmpty(tenThuoc))
            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc WHERE (ID LIKE @maThuoc and tenThuoc LIKE @tenThuoc and nhomThuoc LIKE @nhomThuoc)";
                command.CommandText = query;
                command.Parameters.AddWithValue("@maThuoc", "%" + maThuoc + "%");
                command.Parameters.AddWithValue("@tenThuoc", "%" + tenThuoc + "%");
                command.Parameters.AddWithValue("@nhomThuoc", "%" + nhomThuoc + "%");
            }
            /*--------------------------------------------*/

            //Query thông tin thuốc từ Sql
            if (!String.IsNullOrEmpty(query))
            {
                SqlDataReader reader = command.ExecuteReader();
                dataGridView2.Rows.Clear();
                int pos_searchgridview = 0;
                while (reader.Read())
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[pos_searchgridview].Cells[0].Value = reader[0].ToString();
                    dataGridView2.Rows[pos_searchgridview].Cells[1].Value = reader[1].ToString();
                    dataGridView2.Rows[pos_searchgridview].Cells[2].Value = reader[2].ToString();
                    pos_searchgridview++;
                }
                con.Close();
            }

            //Query thông tin thuốc từ Sql
            if (String.IsNullOrEmpty(maThuoc) && String.IsNullOrEmpty(tenThuoc) && String.IsNullOrEmpty(nhomThuoc))
            {
                query = "SELECT ID,tenThuoc,nhomThuoc  FROM dbo.Thuoc";
                command.CommandText = query;
                command.Parameters.AddWithValue("@query", "%" + query + "%");
                SqlDataReader reader = command.ExecuteReader();
                dataGridView2.Rows.Clear();
                int pos_searchgridview = 0;

                while (reader.Read())
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[pos_searchgridview].Cells[0].Value = reader[0].ToString();
                    dataGridView2.Rows[pos_searchgridview].Cells[1].Value = reader[1].ToString();
                    dataGridView2.Rows[pos_searchgridview].Cells[2].Value = reader[2].ToString();
                    pos_searchgridview++;
                }
                con.Close();
            }
        }

        private void searchNhomthuoc_TextChanged(object sender, EventArgs e)
        {
            updateSearchList(searchMaThuoc.Text, searchTenthuoc.Text, searchNhomthuoc.Text);
        }

        private void searchTenthuoc_TextChanged(object sender, EventArgs e)
        {
            updateSearchList(searchMaThuoc.Text, searchTenthuoc.Text, searchNhomthuoc.Text);
        }

        private void listDonvi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfile = new EditProfile(account_id);
            editProfile.Show();
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanForm thanhToanForm = new ThanhToanForm(account_id);
            thanhToanForm.Show();
        }

        private void quảnLýNộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNoiTruForm quanLyNoiTru = new QuanLyNoiTruForm(account_id);
            quanLyNoiTru.Show();
        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }
    }
}
