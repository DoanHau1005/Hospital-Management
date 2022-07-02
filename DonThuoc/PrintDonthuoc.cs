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

namespace CuoiKiCDCNPM.DonThuoc
{
    public partial class PrintDonthuoc : Form
    {
        String id;
        public PrintDonthuoc(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void PrintDonthuoc_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Kết nối Sql Server
            String connect_str = Properties.Resources.connectString;
            SqlConnection con = new SqlConnection(connect_str);
            //Query thông tin maBN từ bảng donthuoc
            SqlDataAdapter donthuoc = new SqlDataAdapter("select * from dbo.donthuoc where maBN = '"+id+"'", con);

            //Query thông tin maBN từ bảng BenhNhanDone
            SqlDataAdapter benhnhanDone = new SqlDataAdapter("select * from dbo.tBenhNhanDone where maBN = '"+id+"'", con);

            DataSet_DonThuoc ds = new DataSet_DonThuoc();
            donthuoc.Fill(ds, "DataTable_DonThuoc");
            benhnhanDone.Fill(ds, "DataTable_BNDone");

            //Đổ dữ liệu 2 bảng query vào reportViewer1 để hiển thị khi in thông tin
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            ReportDataSource datasource1 = new ReportDataSource("DataSet2", ds.Tables[1]);
            reportViewer1.Size = new Size(740, 780);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.LocalReport.DataSources.Add(datasource1);
            reportViewer1.RefreshReport();
        }
    }
}
