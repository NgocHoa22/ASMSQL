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
    public partial class Employee : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asmm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Employee()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            sql.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sql = new SqlConnection(str);
            sql.Open();
            string add = ("Insert into Employee(employee_id, employee_name, position, authority) values(@employee_id, @employee_name, @position, @authority)");
            cmd = new SqlCommand(add, sql);
            cmd.Parameters.AddWithValue("@employee_id", txtcode.Text);
            cmd.Parameters.AddWithValue("@employee_name", txtname.Text);
            cmd.Parameters.AddWithValue("@position", txtpost.Text);
            cmd.Parameters.AddWithValue("@authority", txtautho.Text);
            cmd.ExecuteNonQuery();
            adt = new SqlDataAdapter(cmd);
            LoadData();
            sql.Close();
        }
        
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string Update = "UPDATE Employee SET employee_name = @employee_name, position = @position, authority = @authority WHERE employee_id = @employee_id";
            cmd = new SqlCommand(Update, sql);
            cmd.Parameters.AddWithValue("@employee_id", txtcode.Text);
            cmd.Parameters.AddWithValue("@employee_name", txtname.Text);
            cmd.Parameters.AddWithValue("@position", txtpost.Text);
            cmd.Parameters.AddWithValue("@authority", txtautho.Text);
            cmd.ExecuteNonQuery ();
            LoadData();
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string delete = ("delete from Employee where employee_id = @employee_id");
            cmd = new SqlCommand(delete, sql);
            cmd.Parameters.AddWithValue("@employee_id", txtcode.Text);
            cmd.ExecuteNonQuery();
            LoadData(); 
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("Select * from Employee", sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dtgrv.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void btseach_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            sql.Open();
            string seach = ("Select * from Employee where employee_id = @employee_id");
            cmd = new SqlCommand(seach, sql);
            cmd.Parameters.AddWithValue("@employee_id", txtcode.Text);
            //cmd.ExecuteNonQuery ();
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            if (dttb.Rows.Count > 0)
            {
                txtname.Text = dttb.Rows[0]["employee_name"].ToString();
                txtpost.Text = dttb.Rows[0]["position"].ToString();
                txtautho.Text = dttb.Rows[0]["authority"].ToString();
            }
            else
            {
                MessageBox.Show("Id khong ton tai");
            }
            LoadData();
            sql.Close();
        }
    }
}
