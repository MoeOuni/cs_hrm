using Microsoft.Data.SqlClient;

namespace hrm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnPageLoad(object sender, EventArgs e)
        {
            
        }

        private void OnLogin(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if(email == "" || password == "")
            {
                MessageBox.Show("Entrez votre e-mail et votre mot de passe s'il vous plaît.");
            } else
            {
                DB.con.Open();

                string sql_request = "SELECT * FROM users WHERE email=@email AND password=@password";

                SqlCommand cmd = new SqlCommand(sql_request, DB.con);

                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue ("password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    // Redirect to other page.
                    MessageBox.Show("Bienvenu !");
                } else
                {
                    MessageBox.Show("Data invalid !");
                    // Show textBox
                }
                DB.con.Close();
            }
        }

    }
}
