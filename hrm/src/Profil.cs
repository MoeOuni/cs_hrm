using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Profil_Load(object sender, EventArgs e)
        {
            try
            {
                DB.con.Open();

                String sqlQuery = "SELECT firstName, lastName, matricule, leaveBalance,  post, role, email, phoneNumber, cin, adresse from users where id = @idUser";

                SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

                cmd.Parameters.AddWithValue("idUser", Login.userId);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    fullName.Text = dr["firstName"].ToString() + " " + dr["lastName"].ToString();
                    matricule.Text = dr["matricule"].ToString();
                    leaveBalance.Text = dr["leaveBalance"].ToString();
                    post.Text = dr["post"].ToString(); 
                    role.Text = dr["role"].ToString();
                    email.Text = dr["email"].ToString();
                    phone.Text = dr["phoneNumber"].ToString();
                    cin.Text = dr["cin"].ToString();
                    adr.Text = dr["adresse"].ToString();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                    // Show textBox
                }

                dr.Close();

                DB.con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }
    }
}
