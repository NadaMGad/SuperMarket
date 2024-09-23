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
    public partial class Add_Department : Form
    {
        public Add_Department()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into departments values(@name,@dept_num)";
            sqlcommand.Parameters.AddWithValue("@name", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@dept_num", int.Parse(textBox1.Text));
           
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("add successfully ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "delete departments   where  dept_num=@dept_num";
            sqlcommand.Parameters.AddWithValue("@dept_num", int.Parse(textBox1.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("delete successfully ");
        }
    }
}
