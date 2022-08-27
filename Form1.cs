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


namespace LOGIN_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) 
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\HER EXCELLENCY\OneDrive\Documents\logindb.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sqlDataAdapter sda = sqlDataAdapter("Select Count(*) From Login where Username =' "+USERNAME.Text+"' and Password ='" + PASSWORD.Text + "'" , con);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                main ss = new main();
                ss.Show();
            }

        else
            {
                MessageBox.Show("Please check your username and password");
        }
        }
    }
}
