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

namespace SuperMarket_Team
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Insert_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlcommand.CommandText = "insert into customer values (@fristName,@lastName,@phoneNumber)" ;
            sqlcommand.Parameters.AddWithValue("@fristName", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@lastName", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@phoneNumber",  int.Parse(textBox3.Text));
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
            SuperMarket f2 = new SuperMarket();
            f2.Show();
            


        }
            

        




        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select* from customer where  PhoneNumber=@PhoneNumber ", sqlConnection);
            sqlcommand.Parameters.AddWithValue("@fristName", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@lastName", textBox2.Text);
            sqlcommand.Parameters.AddWithValue("@PhoneNumber", int.Parse(textBox3.Text));
            SqlDataReader rd = sqlcommand.ExecuteReader();
            if (rd.HasRows)
            {

                this.Hide();
                SuperMarket f2 = new SuperMarket();
                f2.Show();

            }
            else
            { MessageBox.Show("Please sign in first"); }
        }
            }
    }


