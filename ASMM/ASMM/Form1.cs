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
    public partial class Form1 : Form
    {
        string str = @"Data Source=TRUONG-NGOC-HOA\SQLEXPRESS;Initial Catalog=asmm;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sql;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dttb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            sql = new SqlConnection(str);
            sql.Open();
            cmd = new SqlCommand("select * from interest",sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();   
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            sql.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            sql = new SqlConnection(str);
            string nhap = ("insert into interest(product_name, interest, day) select product_name, sum(selling_price - entry_price), convert(varchar(50), getdate(), 103) from Product group by product_name");
            cmd = new SqlCommand(nhap,sql);
            adt = new SqlDataAdapter(cmd);
            DataTable dttb = new DataTable();
            adt.Fill(dttb);
            dataGridView1.DataSource = dttb;
            LoadData();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
