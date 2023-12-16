using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace hrm
{
    public partial class AddUser : Form
    {
        List<User> users;
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string firstName = textBoxFirstName.Text;
            string role = comboBoxRole.Text;
            string matricule = textBoxMatricule.Text;
            string poste = textBoxPoste.Text;
            int leaveBalance = int.Parse(textBoxLeaveBalance.Text);
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            int cin = int.Parse(textBoxCin.Text);
            string address = textBoxAdresse.Text;
            int idResponsable = 0;
            if (comboBoxUsers.SelectedIndex >= 0)
            {
                User selectedUser = (User)comboBoxUsers.SelectedItem;
                idResponsable = selectedUser.Id;
            }

            MessageBox.Show(idResponsable.ToString());
            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(role) &&
                !string.IsNullOrEmpty(matricule) &&
                !string.IsNullOrEmpty(poste) &&
                !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(phoneNumber) &&
                !string.IsNullOrEmpty(cin.ToString()) &&
                !string.IsNullOrEmpty(address))
            {
                // All fields are filled, proceed with the logic
                DB.con.Open();

                string query = "INSERT INTO users (firstName, lastName, role, matricule, post, leaveBalance, email, password, phoneNumber, cin, adresse, idManager) VALUES ( '" + firstName + "', '" + name + "', '" + role + "', '" + matricule + "', '" + poste + "', '" + leaveBalance + "', '" + email + "', '" + password + "', '" + phoneNumber + "', '" + cin + "', '" + address + "', '" + idResponsable +"')";

                SqlCommand cmd = new SqlCommand(query, DB.con);

                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    User user = new User();
                    user.firstName = firstName;
                    user.lastName = name;
                    user.role = role;
                    user.regNumber = matricule;
                    user.post = poste;
                    user.leaveBalance = leaveBalance;
                    user.email = email;
                    user.phoneNumber = phoneNumber;
                    user.cin = cin;
                    user.address = address;
                    this.users.Add(user);
                    MessageBox.Show("L'utilisateur a été enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'enregistrement de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DB.con.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            DB.con.Open();

            string query = "SELECT * FROM users";

            SqlCommand cmd = new SqlCommand(query, DB.con);

            SqlDataReader reader = cmd.ExecuteReader();

            this.users = new List<User>();

            while (reader.Read())
            {
                User user = new User();
                user.Id = Convert.ToInt32(reader["Id"]);
                user.firstName = reader["firstName"].ToString();
                user.lastName = reader["lastName"].ToString();
                user.role = reader["role"].ToString();
                user.regNumber = reader["matricule"].ToString();
                user.post = reader["post"].ToString();
                user.leaveBalance = Convert.ToInt32(reader["leaveBalance"]);
                user.email = reader["email"].ToString();
                user.phoneNumber = reader["phoneNumber"].ToString();
                user.cin = Convert.ToInt32(reader["cin"]);
                user.address = reader["adresse"].ToString();



                this.users.Add(user);
            }
            comboBoxUsers.DisplayMember = "firstName";
            comboBoxUsers.ValueMember = "Id";
            comboBoxUsers.DataSource = this.users;
            dataGridViewUsers.DataSource = this.users;
            reader.Close();
            DB.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }
    }
}
