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

namespace CuoiKiCDCNPM.PhieuKhamBN
{
    public partial class frmPhieuKhamBenh : Form
    {
        String id;
        public frmPhieuKhamBenh(String id)
        {
            this.id = id;
            InitializeComponent();
        }



        private void frmPhieuKhamBenh_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //Khởi tạo kết nối dữ liệu
            String connect_str = Properties.Resources.connectString;
            SqlConnection con = new SqlConnection(connect_str);

            //Query dữ liệu bệnh nhân trong Sql Server
            SqlDataAdapter BN = new SqlDataAdapter("Select * from dbo.tBenhNhan where maBN ='" + id + "'", con);


            DataSet_KhamBenh ds = new DataSet_KhamBenh();

            //File dữ liệu bệnh nhân Datatable_Benhnhan
            BN.Fill(ds, "Datatable_Benhnhan");

            //File dữ liệu bệnh nhân ReportDataSource
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);

            this.reportViewer1.Size = new Size(830, 820);
            reportViewer1.LocalReport.DataSources.Clear();
            //Thêm dữ liệu vào ReportViewer1
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }
    }
}
