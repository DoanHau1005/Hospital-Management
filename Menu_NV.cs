using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKiCDCNPM
{
    public partial class Menu_NV : Form
    {
        int id;

        public Menu_NV(int id,string name)
        {
            InitializeComponent();
            //Khởi tạo thông tin id user đăng nhập vào hệ thống
            this.id = id;
            
            //Lấy tên user đăng nhập hệ thống
            this.txtName.Text  = name;
        }
        private void customizeDesing()
        {
            SubpanelQLUser.Visible = false;

        }

        private Form activeForm = null;

        //Hàm dùng để hiển thị thông tin form nhỏ bên theo từng button hệ thống
        private void openChildForm(Form childForm)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void hideSubMenu()
        {
            //Ẩn thông tin Submenu
            if (SubpanelQL.Visible == true)
            {
                SubpanelQL.Visible = false;
            }

            if (SubpanelQLUser.Visible == false)
            {
                SubpanelQLUser.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }




        #region Quan Ly User 
        private void btManager_Click(object sender, EventArgs e)
        {
            showSubMenu(SubpanelQL);
            SubpanelQLUser.Visible = false;

        }

        private void btUser_Click(object sender, EventArgs e)
        {
            showSubMenu(SubpanelQLUser);

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //openChildForm(new QLSV(txtBasis.Text));

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            //openChildForm(new QLGV(txtBasis.Text));
        }


        private void btHistory_Click(object sender, EventArgs e)
        {
            //openChildForm(new LichSuThi(txtAuth.Text,txtName.Text));
        }
        #endregion

        #region System
        private void btSystem_Click(object sender, EventArgs e)
        {
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            //openChildForm(new ChuanBiThi(txtBasis.Text, txtName.Text));
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            //openChildForm(new LamBaiThi(txtBasis.Text, txtName.Text));
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //openChildForm(new InPhieuDiem(txtBasis.Text, txtName.Text));
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Login lg = new Login();
                //lg.Show();
                //this.Hide();
            }
        }
        #endregion



        private void Menu_Load(object sender, EventArgs e)
        {


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubpanelQLUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btFaculty_Click(object sender, EventArgs e)
        {
            //openChildForm(new QLKhoa(txtBasis.Text));
        }

        private void btClass_Click(object sender, EventArgs e)
        {
            //openChildForm(new QLLop(txtBasis.Text));
        }

        private void btSubject_Click(object sender, EventArgs e)
        {
            //openChildForm(new QLMonHoc(txtBasis.Text));
        }

        private void btQuestion_Click_1(object sender, EventArgs e)
        {
            //openChildForm(new QLDeThi(txtBasis.Text, txtName.Text));
        }

        private void panelBotton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            //Click nút sẽ hiển thị form Quản lý bệnh nhân
            QuanLyBenhNhan qlbn = new QuanLyBenhNhan(id);
            openChildForm(qlbn);
            btnQlyKham.BackColor = SystemColors.GradientActiveCaption;
            btnThanhtoan.BackColor = SystemColors.ControlLight;
            btnQuanlyNoitru.BackColor = SystemColors.ControlLight;
            btnQuanlyThuoc.BackColor = SystemColors.ControlLight;
            btnTTNV.BackColor = SystemColors.ControlLight;

        }

        private void btnQuanlyNv_Click(object sender, EventArgs e)
        {
            //Click nút sẽ hiển thị form Quản lý nội trú
            QuanLyNoiTruForm noitru = new  QuanLyNoiTruForm(id);
            openChildForm(noitru);
            btnQuanlyNoitru.BackColor = SystemColors.GradientActiveCaption;
            btnThanhtoan.BackColor = SystemColors.ControlLight;
            btnQlyKham.BackColor = SystemColors.ControlLight;
            btnQuanlyThuoc.BackColor = SystemColors.ControlLight;
            btnTTNV.BackColor = SystemColors.ControlLight;

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            //Click nút sẽ hiển thị form chỉnh sửa thông tin bệnh nhân
            EditProfile editProfile = new EditProfile(id);
            openChildForm(editProfile);

            btnTTNV.BackColor = SystemColors.GradientActiveCaption;
            btnThanhtoan.BackColor = SystemColors.ControlLight;
            btnQlyKham.BackColor = SystemColors.ControlLight;
            btnQuanlyNoitru.BackColor = SystemColors.ControlLight;
            btnQuanlyThuoc.BackColor = SystemColors.ControlLight;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            //Click nút sẽ hiển thị form quản lý thuốc
            ManagementMedicine medicine = new ManagementMedicine(id);
            openChildForm(medicine);
            btnQuanlyThuoc.BackColor = SystemColors.GradientActiveCaption;
            btnThanhtoan.BackColor = SystemColors.ControlLight;
            btnQlyKham.BackColor = SystemColors.ControlLight;
            btnQuanlyNoitru.BackColor = SystemColors.ControlLight;
            btnTTNV.BackColor = SystemColors.ControlLight;
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            //Click nút sẽ hiển thị form thanh toán
            ThanhToanForm thanhtoan = new ThanhToanForm(id);
            openChildForm(thanhtoan);
            btnThanhtoan.BackColor = SystemColors.GradientActiveCaption;
            btnQuanlyThuoc.BackColor = SystemColors.ControlLight;
            btnQlyKham.BackColor = SystemColors.ControlLight;
            btnQuanlyNoitru.BackColor = SystemColors.ControlLight;
            btnTTNV.BackColor = SystemColors.ControlLight;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            //Click nút quay lại trang Trang chủ
            pictureBox3.BringToFront();
           
            btnTTNV.BackColor = SystemColors.ControlLight;
            btnThanhtoan.BackColor = SystemColors.ControlLight;
            btnQuanlyNoitru.BackColor = SystemColors.ControlLight;
            btnQlyKham.BackColor = SystemColors.ControlLight;
            btnQuanlyThuoc.BackColor = SystemColors.ControlLight;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
