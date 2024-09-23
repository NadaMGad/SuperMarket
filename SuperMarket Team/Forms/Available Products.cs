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

namespace SuperMarket_Team.Forms
{
    public partial class Available_Products : Form
    {
        public Available_Products()
        {
            InitializeComponent();
        }

        private void Available_Products_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select name, price ,serial_number,production_date,expire_date,quantity from  Product where dept_num=@dept_num", sqlConnection);
            sqlcommand.Parameters.AddWithValue("@dept_num", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }
    }
}
