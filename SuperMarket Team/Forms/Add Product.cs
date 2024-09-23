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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }
        private void Add_Product_Load(object sender, EventArgs e)
        {

        }

        private void Product_Name_Click(object sender, EventArgs e)
        {

        }

        private void Product_Price_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = " update  Product set  name=@name,price=@price,quantity=@quantity,production_date=@production_date,expire_date = @expire_date ,dept_num = @dept_num where serial_number = @serial_number";
            sqlcommand.Parameters.AddWithValue("@serial_number", int.Parse( textBox1.Text));
            sqlcommand.Parameters.AddWithValue("@name", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@price", float.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@quantity", float.Parse(textBox7.Text));
            sqlcommand.Parameters.AddWithValue("@production_date", DateTime.Parse(dateTimePicker1.Text));
            sqlcommand.Parameters.AddWithValue("@expire_date", DateTime.Parse(dateTimePicker2.Text));
            sqlcommand.Parameters.AddWithValue("@dept_num", int.Parse(textBox9.Text));
            sqlcommand.Parameters.AddWithValue("@Id", int.Parse(textBox6.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" update successfully ");
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
  
        private void Add_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into Product values(@serial_number,@name,@price,@quantity,@production_date,@expire_date,@dept_num,@Id)";
            sqlcommand.Parameters.AddWithValue("@serial_number", int.Parse( textBox1.Text));
            sqlcommand.Parameters.AddWithValue("@name", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@price", float.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@quantity", float.Parse( textBox7.Text));
            sqlcommand.Parameters.AddWithValue("@production_date",DateTime.Parse (dateTimePicker1.Text));
            sqlcommand.Parameters.AddWithValue("@expire_date", DateTime.Parse( dateTimePicker2.Text));
            sqlcommand.Parameters.AddWithValue("@dept_num", int.Parse(textBox9.Text));
            sqlcommand.Parameters.AddWithValue("@Id", int.Parse(textBox6.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" Add successfully ");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "delete product   where  serial_number=@serial_number";
            sqlcommand.Parameters.AddWithValue("@serial_number", int.Parse(textBox1.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("delete successfully ");
        }
    }
}
