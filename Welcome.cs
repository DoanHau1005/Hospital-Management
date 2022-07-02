using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CuoiKiCDCNPM
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.textBox1.Text = "lucdz";
            this.textBox2.Text = "lucdz";
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        



        //Keo di chuyen

        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Tên tài khoản không được phép để trống!!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Mật khẩu không được phép để trống!!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else
            {
                //Khởi tạo kết nối Sql
                string connectionString = CuoiKiCDCNPM.Properties.Resources.connectString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand command = con.CreateCommand();

                //query thông tin user trong hệ thống
                command.CommandText = " SELECT user_id FROM [user] WHERE user_username=@username AND user_password=@password";
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                var result = command.ExecuteScalar();
                con.Close();

                //Nếu query tồn tại thông tin user đăng nhập trong hệ thống.
                if (result != null)
                {
                    //Nếu chức danh là admin thì sẽ vào form Admin
                    if (textBox1.Text == "admin")
                    {
                        this.Hide();
                        Menu_Admin menu = new Menu_Admin();
                        menu.Show();
                    }
                    else
                    {
                        con.Open();
                        //Query thông tin tài khoản để lấy thông tin và chức vụ
                        command.CommandText = "Select account_id, account_type,account_name, account_user_id FROM account WHERE account_user_id=@user_id";
                        command.Parameters.AddWithValue("@user_id", result.ToString());
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            int account_id = reader.GetInt32(0);
                            int account_type = reader.GetInt32(1);
                            String account_name = reader.GetString(2);
                            int account_user_id = reader.GetInt32(3);
                            con.Close();
                            if (account_type == 0)
                            {
                                // Nếu là y tá thì show form
                                this.Hide();
                                Menu_NV nv = new Menu_NV(account_id, account_name);
                                nv.Show();
                                //Show();
                            }
                            else if (account_type == 1)
                            {
                                // Nếu là doctor thì show form
                                this.Hide();
                                DoctorPanel doctorPanel = new DoctorPanel(account_user_id);
                                doctorPanel.Show();
                                //Show();
                            }
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Sai mật khẩu hoặc sai tên tài khoản!!!!", "THÔNG BÁO", buttons, MessageBoxIcon.Warning);
                }
            } 
        }

        private void iconButton1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                iconButton1.PerformClick();
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                iconButton1.PerformClick();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                iconButton1.PerformClick();
        }
    }
}
