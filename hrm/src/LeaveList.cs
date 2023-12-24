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
    public partial class LeaveList : Form
    {
        private List<Request> requests;
        public LeaveList()
        {
            InitializeComponent();
        }

        private void LeaveList_Load(object sender, EventArgs e)
        {
            DB.con.Open();

            string sql_query = "select id ,type, startDate, endDate, motif, requestedAt, status, requestedBy from leaves WHERE requestedBy = @requestedBy";

            SqlCommand cmd = new SqlCommand(sql_query, DB.con);

            cmd.Parameters.AddWithValue("requestedBy", Login.userId);

            SqlDataReader reader = cmd.ExecuteReader();

            requests = new List<Request>(); // Create a new instance of the requests list

            while (reader.Read())
            {
                // Read the data from the reader and create a new Request object
                Request request = new Request
                {
                    id = reader.GetInt32(0),
                    type = reader.GetString(1),
                    startDate = reader.GetDateTime(2),
                    endDate = reader.GetDateTime(3),
                    motif = reader.GetString(4),
                    requestedAt = reader.GetDateTime(5),
                    status = reader.GetString(6),
                    requestedBy = reader.GetInt32(7)
                };

                requests.Add(request); // Add the request to the list
            }

            reader.Close();

            dataGridView.DataSource = requests;

            dataGridView.Columns["id"].Visible = false;
            dataGridView.Columns["firstName"].Visible = false;
            dataGridView.Columns["lastName"].Visible = false;
            dataGridView.Columns["requestedBy"].Visible = false;

            DB.con.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0].DataBoundItem as Request;

                if (selectedRow.status == "PENDING")
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir d'annuler cette demande ?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DB.con.Open();

                        String sqlQuery = "UPDATE leaves SET status = 'CANCELED' WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);
                        cmd.Parameters.AddWithValue("id", selectedRow.id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Le congé a été annuler.");

                        DB.con.Close();

                        if (selectedRow.type == "Congé Annuel")
                        {
                            try
                            {
                                // DateFuncs.CalculerJoursConges(convertedStartDate, convertedEndDate) retourne le nombre de jours ouvrables entre deux dates
                                Utils.UpdateLeaveBalance(Login.userId, DateFuncs.CalculerJoursConges(convertedStartDate, convertedEndDate));
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
