using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConsoleApp_GK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-366THI1;Initial Catalog=AdventureWorksLT2019;Integrated Security=True");
            string query = "Select * from Users Where username = '"+txtUsername.Text.Trim()+"' and password = '"+txtPassword.Text.Trim()+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form1 objForm1 = new Form1();
                this.Hide();
                objForm1.Show();
            }
            else
            {
                MessageBox.Show("Check Your Username or Password !! ");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
