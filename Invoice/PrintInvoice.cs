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

namespace CuoiKiCDCNPM.Invoice
{
    public partial class PrintInvoice : Form
    {
        string id, idNV, idBN;
        public PrintInvoice(String id, String idNV, String idBN)
        {
            this.id = id;
            this.idNV = idNV;
            this.idBN = idBN;
            InitializeComponent();
        }

        private void PrintInvoice_Load(object sender, EventArgs e)
        {
            this.reportViewer2.RefreshReport();
        }   

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            //Kết nối thông tin Sql
            String connect_str = Properties.Resources.connectString;
            SqlConnection con = new SqlConnection(connect_str);

            //Sử dụng query để lấy dữ liệu từ Slq
            SqlDataAdapter benhnhan = new SqlDataAdapter("Select * from dbo.tBenhNhan where maBN ='" + idBN + "'", con);
            SqlDataAdapter thanhtoan = new SqlDataAdapter("Select * from dbo.tThanhtoan where IDThanhtoan ='" + id + "'", con);
            SqlDataAdapter nhanvien = new SqlDataAdapter("Select * from dbo.hosonhanvien where idnhanvien ='" + idNV + "'", con);
            SqlDataAdapter chitietBN = new SqlDataAdapter("Select * from dbo.tBenhNhanDone where maBN ='" + idBN + "'", con);

            DataSet_Invoice ds = new DataSet_Invoice();
            benhnhan.Fill(ds, "DataTable_BN");
            thanhtoan.Fill(ds, "DataTable_Invoice");
            nhanvien.Fill(ds, "DataTable_HosoNV");
            chitietBN.Fill(ds, "DataTable_ChitietBN");


            ReportDataSource datasource = new ReportDataSource("DataSet2", ds.Tables[1]);
            ReportDataSource datasource1 = new ReportDataSource("DataSet1", ds.Tables[0]);
            ReportDataSource datasource2 = new ReportDataSource("DataSet3", ds.Tables[2]);
            ReportDataSource datasource3 = new ReportDataSource("DataSet4", ds.Tables[3]);


            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.Size = new Size(850, 850);
            //Đổ dữ liệu vào bảng reportViewer2 để in ra cho bệnh nhân

            reportViewer2.LocalReport.DataSources.Add(datasource);
            reportViewer2.LocalReport.DataSources.Add(datasource1);
            reportViewer2.LocalReport.DataSources.Add(datasource2);
            reportViewer2.LocalReport.DataSources.Add(datasource3);

            reportViewer2.RefreshReport();
        }
    }
}
