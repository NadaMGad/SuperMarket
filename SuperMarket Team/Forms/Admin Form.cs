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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
            
    }
  
    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "update  admins set passwords=@Passwords , username=@username ,dep_num=@dep_num where  Id=@Id";
            sqlcommand.Parameters.AddWithValue("@Id", int.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@Passwords", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@username", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@dep_num", int.Parse(textBox4.Text));
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
            sqlcommand.CommandText = "delete  admins  where  Id=@Id";
            sqlcommand.Parameters.AddWithValue("@Id", int.Parse(textBox3.Text));        
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" delete successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into  admins  values(@Id,@Passwords , @username,@dep_num)";
            sqlcommand.Parameters.AddWithValue("@Id", int.Parse(textBox3.Text));
            sqlcommand.Parameters.AddWithValue("@Passwords", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@username", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@dep_num", int.Parse(textBox4.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show(" add successfully ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
