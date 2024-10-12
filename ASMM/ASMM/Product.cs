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
    public partial class Product : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asmm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Product()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Product", sql);
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
            string delete = ("delete from Product where product_code = @product_code");
            cmd = new SqlCommand(delete, sql);
            cmd.Parameters.AddWithValue("@product_code", txtcode.Text);
            //cmd = new SqlCommand("Select * from Product_mamnagement");
            cmd.ExecuteNonQuery();
            //cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string add = ("insert into Product(product_code, product_name, entry_price, selling_price, quantity) values (@product_code, @product_name, @entry_price, @selling_price, @quantity)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@product_code", txtcode.Text);
            cmd.Parameters.AddWithValue("@product_name", txtname.Text);
            cmd.Parameters.AddWithValue("@entry_price", txtentry.Text);
            cmd.Parameters.AddWithValue("@selling_price", txtselling.Text);
            cmd.Parameters.AddWithValue("quantity", txtqtt.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string edit = ("update Product set product_code = @product_code, product_name = @product_name, entry_price = @entry_price, selling_price = @selling_price, quantity = @quantity where product_code = @product_code");
            cmd = new SqlCommand(edit, sql);
            cmd.Parameters.AddWithValue("@product_code", txtcode.Text);
            cmd.Parameters.AddWithValue("@product_name", txtname.Text);
            cmd.Parameters.AddWithValue("@entry_price", txtentry.Text);
            cmd.Parameters.AddWithValue("@selling_price", txtselling.Text);
            cmd.Parameters.AddWithValue("@quantity", txtqtt.Text);
            cmd.ExecuteNonQuery();
            LoadData();
            sql.Close();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string search = ("Select * from Product where product_code = @product_code");
            cmd = new SqlCommand(search, sql);
            cmd.Parameters.AddWithValue("@product_code", txtcode.Text);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["product_name"].ToString();
                txtentry.Text = dttb.Rows[0]["entry_price"].ToString();
                txtselling.Text = dttb.Rows[0]["selling_price"].ToString();
                txtqtt.Text = dttb.Rows[0]["quantity"].ToString();
            }
            else
            {
                MessageBox.Show("Mat Hang Nay Khong Ton Tai");
            }
            LoadData();
            sql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
