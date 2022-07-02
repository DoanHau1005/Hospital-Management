using CuoiKiCDCNPM.Invoice;
using Microsoft.Reporting.WinForms;
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
    public partial class ThanhToanForm : Form
    {
        //Khởi tạo thông tin để lưu trữ thanh toán.
        int id;
        int tmp;
        int tiengiuongbenh=0;
        int tiendieutri = 0;
        int tienbaohiem;
        int phithuoc=0;
        int phikhambenh;
        int phidichvu;
        string IDBaocao;
        public ThanhToanForm(int id)
        {
            InitializeComponent();
            this.id = id;
            loadData();
        }
        //Load thông thanh toán lên datagridview
        public void loadData()
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from dbo.tThanhtoan";
            SqlDataReader reader = command.ExecuteReader();

            while( reader.Read())
            {
                //khởi tạo biến lưu dữ liệu datagridview
                int idThanhtoan = reader.GetInt32(0);
                String maBN = reader.GetString(1);
                String maBA = reader.GetString(2);
                int phidichvu = reader.GetInt32(3);
                int phikhambenh = reader.GetInt32(4);
                int phithuoc = reader.GetInt32(5);
                int phigiuongbenh = reader.GetInt32(6);
                int phidieutri = reader.GetInt32(7);
                int phibhyt = reader.GetInt32(8);
                int tongchiphi = reader.GetInt32(9);
                String ngaylap = reader.GetString(10);

                //Thêm thông tin vào datagridview
                dataGridView1.Rows.Add();
                dataGridView1.Rows[tmp].Cells[0].Value = idThanhtoan;
                dataGridView1.Rows[tmp].Cells[1].Value = maBN;
                dataGridView1.Rows[tmp].Cells[2].Value = maBA;
                dataGridView1.Rows[tmp].Cells[3].Value = phidichvu;
                dataGridView1.Rows[tmp].Cells[4].Value = phikhambenh;
                dataGridView1.Rows[tmp].Cells[5].Value = phithuoc;
                dataGridView1.Rows[tmp].Cells[6].Value = phigiuongbenh;
                dataGridView1.Rows[tmp].Cells[7].Value = phidieutri;
                dataGridView1.Rows[tmp].Cells[8].Value = phibhyt;
                dataGridView1.Rows[tmp].Cells[9].Value = tongchiphi;
                dataGridView1.Rows[tmp].Cells[10].Value = ngaylap;
                tmp++;
            }
            con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //Chọn thông tin sau khi nhập mã Bệnh án
            if (!String.IsNullOrEmpty(boxMaBA.Text))
            {
                SqlConnection cn = new SqlConnection(Properties.Resources.connectString);
                SqlCommand command = cn.CreateCommand();

                //Tìm thông tin bệnh án của bệnh nhân
                command.CommandText = "Select * from dbo.tBenhNhanDone where maBA = '"+boxMaBA.Text.Trim()+"'";
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader!=null)
                {
                    while (reader.Read())
                    {
                        int maBN = reader.GetInt32(0);
                         phikhambenh = reader.GetInt32(17);
                        boxPhikham.Text = phikhambenh.ToString();

                        //Adapter để kết nối db Sql
                        SqlDataAdapter benhnhan = new SqlDataAdapter("Select * from dbo.tBenhNhan where maBN ='" + maBN + "'", cn);
                        SqlDataAdapter noitru = new SqlDataAdapter("Select * from dbo.quanlynoitru where maBN= '" + maBN + "'", cn);
                        SqlDataAdapter donthuoc = new SqlDataAdapter("Select * from dbo.donthuoc where maBN= '" + maBN + "'", cn);
                        
                        DataSet ds = new DataSet();
                        DataSet ds1 = new DataSet();
                        DataSet ds2 = new DataSet();

                        reader.Close();

                        //Đổ dữ liệu theo từng bảng Dataset
                        benhnhan.Fill(ds, "benhnhan");
                        noitru.Fill(ds1, "noitru");
                        donthuoc.Fill(ds2, "donthuoc");


                        //Lấy thông tin bệnh nhân từ bảng benhnhan
                        foreach (DataRow row in ds.Tables["benhnhan"].Rows)
                        {
                            //MessageBox.Show(row["TenBacSy"].ToString());
                            boxMaBN.Text = row["maBN"].ToString();
                            boxTuoi.Text = row["tuoi"].ToString();
                            boxTenBN.Text = row["tenBN"].ToString();
                            boxDiachi.Text = row["diachi"].ToString();
                            boxBHYT.Text = row["bhyt"].ToString();
                            boxSdt.Text = row["sdt"].ToString();
                            String gt = row["gioitinh"].ToString();
                            if (gt.Equals("Nam"))
                            {
                                radioNam.Checked = true;
                            }
                            else
                            {
                                radioNu.Checked = true;
                            }
                        }

                        //Lấy thông tin bệnh nhân từ bảng nội trú
                        foreach (DataRow row in ds1.Tables["noitru"].Rows)
                        {
                            if (!String.IsNullOrEmpty(row["PhiGB"].ToString()))
                            {
                                tiengiuongbenh = Int32.Parse(row["PhiGB"].ToString());
                            }
                            if (!String.IsNullOrEmpty(row["TongTienPhong"].ToString()))
                            {
                                tiendieutri = Int32.Parse(row["TongTienPhong"].ToString());
                            }


                        }

                        //Lấy thông tin bệnh nhân từ bảng donthuoc
                        foreach (DataRow row in ds2.Tables["donthuoc"].Rows)
                        {
                            if (!String.IsNullOrEmpty(row["tienthuoc"].ToString()))
                            {
                                phithuoc += Int32.Parse(row["tienthuoc"].ToString());
                                MessageBox.Show(row["tienthuoc"].ToString());
                            }
                            else
                            {
                                boxPhithuoc.Text = "0";
                                phithuoc = 0;

                            }
                        }


                        //Lưu dữ liệu các khoản phí vào trong textbox phí của thanh toán
                        boxPhiGB.Text = tiengiuongbenh.ToString();
                        boxPhidieutri.Text = tiendieutri.ToString();
                        boxPhithuoc.Text = phithuoc.ToString() ;
                        if (boxBHYT.Text.Trim().Contains("có"))
                        {
                            phiBhyt.Text = "0";
                            tienbaohiem = 0;
                        }
                        else
                        {
                            tienbaohiem = 5;
                        }
                    

                        break;

                    }
                }
                 else
                {
                    MessageBox.Show("Mã số bệnh án không tồn tại trong hệ thống.!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reader.Close();
                cn.Close();
            }
            else
            {
                MessageBox.Show("VUI LÒNG NHẬP MÃ BỆNH ÁN CỦA BỆNH NHÂN !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýNộiTrúToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void searchHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //Cộng dồn các thông tin khoản phí hiển thị trong hệ thống
            phidichvu = Int32.Parse(boxDichvu.Text);
            int tongchiphi = phidichvu + tiengiuongbenh + tiendieutri + phikhambenh + phithuoc;
            int giambaohiem=tongchiphi * 5/100 ;
            phiBhyt.Text = giambaohiem.ToString();
            boxTongchiphi.Text = (tongchiphi - giambaohiem).ToString();
        }

        //Hàm thêm thông tin thanh toán của bệnh nhân vào hệ thống
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(boxTongchiphi.Text))
            {
                MessageBox.Show("Chưa tính tổng chi phí của bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(boxDichvu.Text))
            {
                MessageBox.Show("Chưa thêm tiền dịch vụ của bệnh nhân!!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Khởi tạo biến lưu giữ liệu thanh toán
                String maBA, maBN, phidichvu, phikhambenh, phithuoc, phigiuongbenh, phidieutri, phibhyt, tongchiphi;
                maBA = boxMaBA.Text;
                maBN = boxMaBN.Text;
                phidichvu = boxDichvu.Text;
                phikhambenh = boxPhikham.Text;
                phigiuongbenh = boxPhiGB.Text;
                phidieutri = boxPhidieutri.Text;
                phibhyt = phiBhyt.Text;
                phithuoc = boxPhithuoc.Text;
                tongchiphi = boxTongchiphi.Text;

                SqlConnection cn = new SqlConnection(Properties.Resources.connectString);
                cn.Open();
                SqlCommand command = cn.CreateCommand();

                //Query dùng để thêm thông tin thanh toán vào hệ thống
                command.CommandText = "INSERT INTO dbo.tThanhtoan(maBN,maBA,phidichvu,phikhambenh,phithuoc,phigiuongbenh,phidieutri,phibhyt,tongchiphi,ngaylap) " +
                    "values(@maBN,@maBA,@phidichvu,@phikhambenh,@phithuoc,@phigiuongbenh,@phidieutri,@phibhyt,@tongchiphim,@ngaylap) SELECT SCOPE_IDENTITY();";
                command.Parameters.AddWithValue("@maBN", maBN);
                command.Parameters.AddWithValue("@maBA", maBA);
                command.Parameters.AddWithValue("@phidichvu",phidichvu);
                command.Parameters.AddWithValue("@phithuoc", phithuoc);
                command.Parameters.AddWithValue("@phikhambenh", phikhambenh);
                command.Parameters.AddWithValue("@phigiuongbenh", phigiuongbenh);
                command.Parameters.AddWithValue("@phidieutri", phidieutri);
                command.Parameters.AddWithValue("@phibhyt", phibhyt);
                command.Parameters.AddWithValue("@tongchiphim", tongchiphi);
                command.Parameters.AddWithValue("@ngaylap",DateTime.Now.ToString("dd-MM-yyyy"));

                int id = Convert.ToInt32(command.ExecuteScalar());


                dataGridView1.Rows.Add();

                // Thêm thông tin thanh toán sau khi thêm vào hệ thống.
                dataGridView1.Rows[tmp].Cells[0].Value = id;
                dataGridView1.Rows[tmp].Cells[1].Value = maBN;
                dataGridView1.Rows[tmp].Cells[2].Value = maBA;
                dataGridView1.Rows[tmp].Cells[3].Value = phidichvu;
                dataGridView1.Rows[tmp].Cells[4].Value = phikhambenh;
                dataGridView1.Rows[tmp].Cells[5].Value = phigiuongbenh;
                dataGridView1.Rows[tmp].Cells[6].Value = phigiuongbenh;
                dataGridView1.Rows[tmp].Cells[7].Value = phidieutri;
                dataGridView1.Rows[tmp].Cells[8].Value = phibhyt;
                dataGridView1.Rows[tmp].Cells[9].Value = tongchiphi;
                dataGridView1.Rows[tmp].Cells[10].Value = DateTime.Now.ToString("dd-MM-yyyy");
                

                tmp++;


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Chọn thông tin thanh toán từ datagridview
            if (e.RowIndex >= 0)
            {
                //Khởi tạo biến lưu dữ liệu
                 IDBaocao = dataGridView1.Rows[e.RowIndex].Cells["txtThanhtoan"].FormattedValue.ToString();
                String maBN = dataGridView1.Rows[e.RowIndex].Cells["txtMaBN"].FormattedValue.ToString();
                String maBA = dataGridView1.Rows[e.RowIndex].Cells["txtMaBA"].FormattedValue.ToString();
                String txtPhidichvu = dataGridView1.Rows[e.RowIndex].Cells["txtPhidichvu"].FormattedValue.ToString();
                String txtPhithuoc = dataGridView1.Rows[e.RowIndex].Cells["txtPhithuoc"].FormattedValue.ToString();
                String txtKhambenh = dataGridView1.Rows[e.RowIndex].Cells["txtKhambenh"].FormattedValue.ToString();
                String txtPhieudieutri = dataGridView1.Rows[e.RowIndex].Cells["txtDieutri"].FormattedValue.ToString();
                String txtPhiGB = dataGridView1.Rows[e.RowIndex].Cells["txtPhiGB"].FormattedValue.ToString();
                String txtBhyt = dataGridView1.Rows[e.RowIndex].Cells["txtBHYT"].FormattedValue.ToString();
                String txtTongchiphi = dataGridView1.Rows[e.RowIndex].Cells["txtTongchiphi"].FormattedValue.ToString();
                String datetime = dataGridView1.Rows[e.RowIndex].Cells["txtDatetime"].FormattedValue.ToString();

                //Gán dữ liệu vào các textbox thanh toán
                boxDichvu.Text = txtPhidichvu;
                boxPhikham.Text = txtKhambenh;
                boxPhithuoc.Text = txtPhithuoc;
                boxPhiGB.Text = txtPhiGB;
                phiBhyt.Text = txtBhyt;
                boxTongchiphi.Text = txtTongchiphi;
                boxPhidieutri.Text = txtPhieudieutri;
                boxMaBA.Text = maBA;

                SqlConnection cnn = new SqlConnection(Properties.Resources.connectString);
                cnn.Open();
                SqlCommand command1 = cnn.CreateCommand();
                //query dùng để lấy  các thông tin từ bảng Benhnhan
                command1.CommandText = "SELECT * FROM dbo.tBenhNhan WHERE maBN=@maBN";
                command1.Parameters.AddWithValue("@maBN", maBN);
                boxMaBN.Text = maBN;

                SqlDataReader reader1 = command1.ExecuteReader();
                //Đọc dữ liệu từ thông tin query
                while (reader1.Read())
                {
                    //Gán dữ liệu vào các textbox thanh toán
                    boxTenBN.Text = reader1.GetString(1);
                    boxTuoi.Text = reader1.GetInt32(2).ToString();
                    String gt = reader1.GetString(3);
                    boxDiachi.Text = reader1.GetString(5);
                    boxSdt.Text = reader1.GetString(6);
                    boxBHYT.Text = reader1.GetString(8);
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
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(IDBaocao))
            {
                if (MessageBox.Show("Bạn có muốn in hóa đơn bệnh nhân có tên: " + boxTenBN.Text+ " ? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //In thông tin thanh toán
                    PrintInvoice frmPrintInvoice = new PrintInvoice(IDBaocao, id.ToString(), boxMaBN.Text);
                    frmPrintInvoice.Size = new Size(880, 910);
                    frmPrintInvoice.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân để in hóa đơn !!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ThanhToanForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
