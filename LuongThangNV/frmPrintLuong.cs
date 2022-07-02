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

namespace CuoiKiCDCNPM.LuongThangNV
{
    public partial class frmPrintLuong : Form
    {
        String id, thangluong;
        public frmPrintLuong(String id,String thangluong)
        {
            InitializeComponent();
            this.id = id;
            this.thangluong = thangluong;
        }

        private void frmPrintLuong_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Khởi nối db Slq
            String connect_str = Properties.Resources.connectString;
            SqlConnection con = new SqlConnection(connect_str);
            
            //Query thông tin db Baocaoluong theo idnhanvien và thangluong
            SqlDataAdapter benhnhan = new SqlDataAdapter("Select * from dbo.baocaoluong where idnhanvien ='" + id + "' and thangluong = '"+thangluong+"'" , con);

            DataSet_LuongNV ds = new DataSet_LuongNV();

            //Đổ dữ liệu vào benhnhan
            benhnhan.Fill(ds, "DataTable_LuongNV");

            //Thêm thông tin vào ReportDataSource
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            reportViewer1.Size = new Size(890, 830);
            reportViewer1.LocalReport.DataSources.Clear();

            //Thêm thông tin vào reportViewr1
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }
            
    }
}
