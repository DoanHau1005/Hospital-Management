using CuoiKiCDCNPM.BaocaoDoanhthu;
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
    public partial class Menu_Admin : Form
    {

        public Menu_Admin()
        {
            InitializeComponent();
        }
    

        private void customizeDesing()
        {
            SubpanelQLUser.Visible = false;
           

        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            //Hàm dùng để hiển thị thông tin form nhỏ bên theo từng button hệ thống
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
            //Hiển thị thông tin Submenu
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
            //Click nút hiển thông tin form quản lý nhân viên
            AdminPanel admin = new AdminPanel();
            openChildForm(admin);
            btnQlytk.BackColor = SystemColors.GradientActiveCaption;
            btnBaocao.BackColor = SystemColors.ControlLight;
            btnQuanlyNv.BackColor = SystemColors.ControlLight;
            btnThongke.BackColor = SystemColors.ControlLight;
            

        }

        private void btnQuanlyNv_Click(object sender, EventArgs e)
        {
            //Click nút hiển thông tin form quản lý nhân viên
            ManagementDoctor doctor = new ManagementDoctor();
            openChildForm(doctor);
            btnQuanlyNv.BackColor = SystemColors.GradientActiveCaption;
            btnBaocao.BackColor = SystemColors.ControlLight;
            btnQlytk.BackColor = SystemColors.ControlLight;
            btnThongke.BackColor = SystemColors.ControlLight;
           

        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            //Click nút trang chủ để hiển thị Form Trang chủ
            pictureBox1.BringToFront();
            btnTrangchu.BackColor = SystemColors.ControlLight;
            btnBaocao.BackColor = SystemColors.ControlLight;
            btnQuanlyNv.BackColor = SystemColors.ControlLight;
            btnQlytk.BackColor = SystemColors.ControlLight;
            btnThongke.BackColor = SystemColors.ControlLight;
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome();
            welcome.Show();
            
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            //Click nút baocaoluong hiển thông tin form baocaoluong
            Baocaoluong baocaoluong = new Baocaoluong();
            openChildForm(baocaoluong);
            btnBaocao.BackColor = SystemColors.GradientActiveCaption;
            btnQuanlyNv.BackColor = SystemColors.ControlLight;
            btnQlytk.BackColor = SystemColors.ControlLight;
            btnThongke.BackColor = SystemColors.ControlLight;
           
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            //Click nút doanh thu hiển thông tin form Doanh thu
            PrintDoanhThu doanhthu = new PrintDoanhThu();
            openChildForm(doanhthu);
            btnThongke.BackColor = SystemColors.GradientActiveCaption;
            btnQuanlyNv.BackColor = SystemColors.ControlLight;
            btnQlytk.BackColor = SystemColors.ControlLight;
            btnBaocao.BackColor = SystemColors.ControlLight;
        }
    }
}
