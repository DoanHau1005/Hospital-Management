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
    public partial class EditProfile : Form
    {
        //Session id user đăng nhập  hệ thống
        int account_id;
        public EditProfile(int account)
        {
            InitializeComponent();
            //Session id user đăng nhập  hệ thống
            this.account_id = account;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        SqlConnection con = new SqlConnection(Properties.Resources.connectString);
        private void EditProfile_Load(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();

            //Câu lệnh Query thông tin account đăng nhập hệ thống.
            command.CommandText = "SELECT user_username, account_name,account_dob,account_phone,account_type,account_notes,account_creation_date FROM [user], account WHERE account_user_id = user_id AND account_id = @account_id";
            command.Parameters.AddWithValue("@account_id", account_id);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) 
            {
                //Gán thông tin dữ liệu vào các textbox thông tin nhân viên
                textBox1.Text = account_id.ToString();
                textBox2.Text = reader.GetValue(0).ToString();
                textBox3.Text = reader.GetValue(1).ToString();
                try
                {
                    dateTimePicker1.Value = DateTime.Parse(reader.GetValue(2).ToString());

                }
                catch(Exception) 
                {

                }
                textBox4.Text = reader.GetValue(3).ToString();
                if (reader.GetInt32(4) == 0)
                {
                    textBox5.Text = "Secretary";
                }
                else if (reader.GetInt32(4) == 1) 
                {
                    textBox5.Text = "Doctor";
                }
                textBox6.Text = reader.GetValue(5).ToString();
                textBox7.Text = reader.GetValue(6).ToString();
            }
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

     
        //Update thông tin nhân viên
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter a name!");
                return;
            }

            SqlCommand command = con.CreateCommand();

            //Query Update thông tin nhân viên
            command.CommandText = "Update account SET account_name=@name,account_dob=@dob,account_notes=@notes,account_phone = @phone WHERE account_id=@account_id";
            command.Parameters.AddWithValue("@name", textBox3.Text);
            command.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("phone", textBox4.Text);
            command.Parameters.AddWithValue("notes", textBox6.Text);
            command.Parameters.AddWithValue("@account_id", account_id);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Account was update");
            }
            else
            {
                MessageBox.Show("Account was not update!");
            }
            con.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyBenhNhan quanLyBenhNhan = new QuanLyBenhNhan(account_id);
            quanLyBenhNhan.Show();
        }

        private void quảnLýThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagementMedicine managementMedicine = new ManagementMedicine(account_id);
            managementMedicine.Show();
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToanForm thanhToanForm = new ThanhToanForm(account_id);
            thanhToanForm.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
