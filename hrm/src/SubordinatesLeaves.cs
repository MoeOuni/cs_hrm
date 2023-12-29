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
    public partial class SubordinatesLeaves : Form
    {
        private List<Request> requests;
        public SubordinatesLeaves()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home page = new Home();
            page.Show();

            this.Hide();
        }

        private void SubordinatesLeaves_Load(object sender, EventArgs e)
        {
            DB.con.Open();

            MessageBox.Show(Login.userId.ToString());

            String sqlQuery = "SELECT leaves.Id, leaves.type, leaves.startDate, leaves.endDate, leaves.motif, leaves.requestedAt, leaves.status, users.firstName, users.lastName, users.id FROM leaves JOIN users ON leaves.requestedBy = users.id WHERE leaves.requestedBy IN (SELECT id FROM users WHERE idManager = @userId)";

            SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

            cmd.Parameters.AddWithValue("userId", Login.userId);

            SqlDataReader reader = cmd.ExecuteReader();

            requests = new List<Request>();

            while (reader.Read())
            {
                // Read the data from the reader and create a new Request object
                Request request = new Request
                {
                    id = reader.GetInt32(0),
                    firstName = reader.GetString(7),
                    lastName = reader.GetString(8),
                    type = reader.GetString(1),
                    startDate = reader.GetDateTime(2),
                    endDate = reader.GetDateTime(3),
                    motif = reader.GetString(4),
                    requestedAt = reader.GetDateTime(5),
                    status = reader.GetString(6),
                    requestedBy = reader.GetInt32(9)
                };

                requests.Add(request); // Add the request to the list
            }

            reader.Close();

            dataGridView.DataSource = requests;

            dataGridView.Columns["requestedBy"].Visible = false;
            dataGridView.Columns["id"].Visible = false;
            DB.con.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridView.SelectedRows[0].DataBoundItem as Request;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0].DataBoundItem as Request;

                if (selectedRow.status == "PENDING")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir approuver ce congé ?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DB.con.Open();

                        String sqlQuery = "UPDATE leaves SET status = 'APPROVED' WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);
                        cmd.Parameters.AddWithValue("id", selectedRow.id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Congé approuvé avec succès.");

                        DB.con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cette demande a déjà été traitée ou annulée.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0].DataBoundItem as Request;

                if (selectedRow.status == "PENDING")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir rejeter ce congé ?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DB.con.Open();

                        String sqlQuery = "UPDATE leaves SET status = 'REJECTED' WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);
                        cmd.Parameters.AddWithValue("id", selectedRow.id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Le congé a été refusé.");

                        DB.con.Close();


                        if (selectedRow.type == "Congé Annuel")
                        {
                
                            try
                            {
                                // DateFuncs.CalculerJoursConges(selectedRow.startDate, selectedRow.endDate) retourne le nombre de jours ouvrables entre deux dates
                                Utils.UpdateLeaveBalance(selectedRow.requestedBy, DateFuncs.CalculerJoursConges(selectedRow.startDate, selectedRow.endDate));
                            }
                            catch (System.Exception ex)
                            {
                                // En cas d'erreur on affiche un message d'erreur et on arrete l'execution de la fonction
                                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cette demande a déjà été traitée ou annulée.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }
    }
}
