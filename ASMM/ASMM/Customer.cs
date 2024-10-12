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
    public partial class Customer : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asmm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Customer()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }
        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("select * from Customer", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string dele = ("delete from Customer where customer_id = @customer_id");
            cmd = new SqlCommand(dele, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            cmd.ExecuteNonQuery();
            //adt = new SqlDataAdapter(cmd); 
            //adt.Fill(dttb);
            //dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string update = ("update Customer set customer_id = @customer_id, customer_name = @customer_name, phone_number = @phone_number, address = @address");
            cmd = new SqlCommand(update, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            cmd.Parameters.AddWithValue("@customer_name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone_number", txtphone.Text);
            cmd.Parameters.AddWithValue("@address", txtadr.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string search = ("select * from Customer where customer_id = @customer_id");
            cmd = new SqlCommand(search, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            LoadData();
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["customer_name"].ToString();
                txtphone.Text = dttb.Rows[0]["phone_number"].ToString();
                txtadr.Text = dttb.Rows[0]["address"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Customer(customer_id, customer_name, phone_number, address) values(@customer_id, @customer_name, @phone_number, @address)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            cmd.Parameters.AddWithValue("@customer_name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone_number", txtphone.Text);
            cmd.Parameters.AddWithValue("@address", txtadr.Text);

            //adt = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataTable dttb = new DataTable();
            //adt.Fill(dttb);
            //dtgrv.DataSource = dttb;
            LoadData();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string update = ("update Customer set customer_id = @customer_id, customer_name = @customer_name, phone_number = @phone_number, address = @address where customer_id = @customer_id");
            cmd = new SqlCommand(update, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            cmd.Parameters.AddWithValue("@customer_name", txtname.Text);
            cmd.Parameters.AddWithValue("@phone_number", txtphone.Text);
            cmd.Parameters.AddWithValue("@address", txtadr.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string search = ("select * from Customer where customer_id = @customer_id");
            cmd = new SqlCommand(search, sql);
            cmd.Parameters.AddWithValue("@customer_id", txtcode.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            LoadData();
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["customer_name"].ToString();
                txtphone.Text = dttb.Rows[0]["phone_number"].ToString();
                txtadr.Text = dttb.Rows[0]["address"].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
