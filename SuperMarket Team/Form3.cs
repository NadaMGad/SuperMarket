using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SuperMarket_Team
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)

        {
            string ConnectionString = "Data Source=WWW-PC\\NADA;Initial Catalog=Supermarket;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
           
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand("select* from adminS where  Passwords=@Passwords ", sqlConnection);
            sqlcommand.Parameters.AddWithValue("@username", textBox1.Text);
            sqlcommand.Parameters.AddWithValue("@Passwords", textBox2.Text);
            SqlDataReader rd = sqlcommand.ExecuteReader();
                if ( rd.HasRows )
                {
                   
                    Form4 f2 = new Form4();
                    f2.ShowDialog();
                   

            }
               else
                MessageBox.Show("error");
            
         sqlConnection.Close();
                
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

