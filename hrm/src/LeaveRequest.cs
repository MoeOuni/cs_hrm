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
    public partial class LeaveRequest : Form
    {
        public LeaveRequest()
        {
            InitializeComponent();
        }

        private void SubmitLeaveRequest(object sender, EventArgs e)
        {
            string type = this.type.Text;
            string startDate = this.startDate.Text;
            string endDate = this.endDate.Text;
            string motif = this.motif.Text;

            // Condition requis
            if (type == "")
            {
                MessageBox.Show("Veuillez remplir le type du congé.");
            }
            else if (startDate == "")
            {
                MessageBox.Show("Veuillez remplir la date de début.");
            }
            else if (endDate == "")
            {
                MessageBox.Show("Veuillez remplir la date de fin.");
            }
            else if (motif == "")
            {
                MessageBox.Show("Veuillez remplir motif du congé.");
            }
            else
            {
                DateTime convertedStartDate = DateTime.Parse(startDate);
                DateTime convertedEndDate = DateTime.Parse(endDate);

                try
                {
                    DateFuncs.ValiderPlageDeDates(convertedStartDate, convertedEndDate);
                }
                catch (System.Exception ex)
                {
                    // En cas d'erreur on affiche un message d'erreur et on arrete l'execution de la fonction
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si le congé et annuel on doit verifier le solde de congé.  
                if (type == "Congé Annuel")
                {
                    try
                    {
                        // DateFuncs.CalculerJoursConges(convertedStartDate, convertedEndDate) retourne le nombre de jours ouvrables entre deux dates
                        Utils.UpdateLeaveBalance(Login.userId, -DateFuncs.CalculerJoursConges(convertedStartDate, convertedEndDate));
                    }
                    catch (System.Exception ex)
                    {
                        // En cas d'erreur on affiche un message d'erreur et on arrete l'execution de la fonction
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DB.con.Open();

                string sql_query = "INSERT INTO leaves (type, startDate, endDate, motif, requestedBy) VALUES(@type, @startDate, @endDate, @motif, @requestedBy)";

                SqlCommand cmd = new SqlCommand(sql_query, DB.con);

                cmd.Parameters.AddWithValue("type", type);
                cmd.Parameters.AddWithValue("startDate", convertedStartDate);
                cmd.Parameters.AddWithValue("endDate", convertedEndDate);
                cmd.Parameters.AddWithValue("motif", motif);
                cmd.Parameters.AddWithValue("requestedBy", Login.userId);

                int rowsAffected = cmd.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Votre congé a été enregistré avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'enregistrement du congé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DB.con.Close();
            }


        }

        private void NavigateToHome(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }

        private void LeaveRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
