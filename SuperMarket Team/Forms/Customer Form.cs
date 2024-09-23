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
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "update  customer set firstName=@fristName , lastName=@lastName where  phoneNumber=@phoneNumber";
            sqlcommand.Parameters.AddWithValue("@fristName", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@lastName", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@phoneNumber", int.Parse(textBox3.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" update successfully ");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "delete customer  where  phoneNumber=@phoneNumber";
            sqlcommand.Parameters.AddWithValue("@phoneNumber", int.Parse( textBox3.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" delete successfully ");
        }
    }
}
