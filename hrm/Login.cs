using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = this.email.Text;
            string password = this.password.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Entrez votre e-mail et votre mot de passe s'il vous plaît.");
            }
            else
            {
                DB.con.Open();

                string sql_request = "SELECT * FROM users WHERE email=@email AND password=@password";

                SqlCommand cmd = new SqlCommand(sql_request, DB.con);

                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Redirect to other page.
                    MessageBox.Show("Bienvenu !");
                    Home home = new Home();
                    home.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vérifier votre email ou mot de passe !");
                    // Show textBox
                }
                DB.con.Close();

            }
        }

       
    }
}
