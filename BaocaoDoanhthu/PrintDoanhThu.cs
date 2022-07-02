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

namespace CuoiKiCDCNPM.BaocaoDoanhthu
{
    public partial class PrintDoanhThu : Form
    {
        public PrintDoanhThu()
        {
            InitializeComponent();
        }

        private void PrintDoanhThu_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Kết nối Sql Server
            String connect_str = Properties.Resources.connectString;
            SqlConnection con = new SqlConnection(connect_str);
            //Query lấy thông tin liên kết giữa các bảng tBenhNhan, Doanhthu, tBenhNhanDone
            SqlDataAdapter benhnhan = new SqlDataAdapter("select t.IDThanhtoan,b.tenBN,b.gioitinh,b.tuoi,b.diachi,d.chuandoan,b.bacsikham,t.tongchiphi,b.ngaykham,t.ngaylap from dbo.tBenhNhan as b, dbo.tBenhNhanDone as d, dbo.tThanhtoan as t where b.maBN = d.maBN and t.maBN = b.maBN", con);

            DataSet_Baocao ds = new DataSet_Baocao();
            benhnhan.Fill(ds, "DataTable_Baocao");

            //Đổ dữ liệu vào report để hiện thị thông tin khi in doanhthu
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }
    }
}
