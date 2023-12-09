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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
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
                DB.con.Open();

                string sql_query = "INSERT INTO leaves (type, startDate, endDate, motif) VALUES(@type, @startDate, @endDate, @motif)";

                SqlCommand cmd = new SqlCommand(sql_query, DB.con);

                cmd.Parameters.AddWithValue("type", type);
                cmd.Parameters.AddWithValue("startDate", startDate);
                cmd.Parameters.AddWithValue("endDate", endDate);
                cmd.Parameters.AddWithValue("motif", motif);

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
    }
}
