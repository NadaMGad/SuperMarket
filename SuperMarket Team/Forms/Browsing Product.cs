using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket_Team.Forms
{
    public partial class Browsing_Product : Form
    {
        public Browsing_Product()
        {
            InitializeComponent();

        }

        private void Product_Name_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select* from  Product where name=@name", sqlConnection);
            sqlcommand.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into buy values (@serial_number,@phoneNumber,@Tdate)";
            sqlcommand.Parameters.AddWithValue("@serial_number", int.Parse(textBox2.Text));
            sqlcommand.Parameters.AddWithValue("@phoneNumber", int.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@Tdate", DateTime.Parse(dateTimePicker1.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into buy values (@serial_number,@phoneNumber,@Tdate)";
            sqlcommand.Parameters.AddWithValue("@serial_number", int.Parse(textBox2.Text));
            sqlcommand.Parameters.AddWithValue("@phoneNumber", int.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@Tdate", DateTime.Parse(dateTimePicker1.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("add successfully");
        }
    }
}
