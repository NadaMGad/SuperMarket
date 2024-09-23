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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select * from  Product where quantity<50 ", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select distinct phoneNumber,count(phoneNumber)as counts from buy  group by phoneNumber having count(*)>1; ", sqlConnection);                  SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select name , count(buy.serial_number) from Product inner join buy on Product.serial_number = buy.serial_number group by buy.serial_number order by  Product.serial_number", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select* from Product where serial_number   not  in(select serial_number from buy where TDate not between 2022-06-04  and 2022-06-05 )", sqlConnection); 
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select* from customer where PhoneNumber    in (select phoneNumber from buy where  TDate not between   2022-06-4 and 2022-07-4)  ", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand(" declare elecric INT set electric = (select COUNT(serial_number) FROM buy where(buy.serial_number = product.serial_number and Product.dept_num = 3))declare food INT set electric = (select COUNT(serial_number) FROM buy where(buy.serial_number = Product.serial_number and Product.dept_num = 1)) case when elec> food then 'the supermarket sells electric appliances more then food products 'else 'the supermarket sells food products more then electric appliances'end ", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();/* */
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("Select serial_number,count(buy.serial_number) as counts From buy group by buy.serial_number  having count(buy.serial_number)>=2 order by buy.serial_number desc;", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("Select phoneNumber,count(buy.phoneNumber) as counts From buy group by buy.phoneNumber  having count(buy.phoneNumber)>=2 order by buy.phoneNumber desc;", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("Select buy.phoneNumber,Product.serial_number, Product.name, Product.quantity, Product.price, Product.production_date, Product.expire_date,count(Product.serial_number) as counts from(Product Inner join buy on Product.serial_number = buy.serial_number) Group by Product.serial_number, buy.phoneNumber, Product.serial_number,Product.name, Product.quantity, Product.price, Product.production_date, Product.expire_date order by counts", sqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
