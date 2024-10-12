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

namespace ASMM
{
    public partial class Login : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asmm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string login = ("Select * from information where user_name = @user_name and password = @password");
            cmd = new SqlCommand(login, sql);
            cmd.Parameters.AddWithValue("@user_name", txtname.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                System.Windows.Forms.MessageBox.Show("Success");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tài Khoản Không Tôn Tại");
            }
            rdr.Close();
            sql.Close();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from information", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            sql.Close();
        }
        private void btcreate_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == txtcf.Text)
            {
                sql = new SqlConnection(str);
                sql.Open();
                string add = ("Insert into information(user_name, password) values (@user_name, @password)");
                cmd = new SqlCommand(add, sql);
                cmd.Parameters.AddWithValue("@user_name", txtname.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.ExecuteNonQuery();
                LoadData();
                System.Windows.Forms.MessageBox.Show("Tạo Tài Khoản Thành Công");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tài khoản và mật khẩu không trùng");
            }
            button1.Visible = true;
            btcreate.Visible = false;
            txtcf.Visible = false;
            lblcf.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btcreate.Visible = true;
            lblcf.Visible = true;
            txtcf.Visible = true;
            button1.Visible = false;
        }
    }
}
