using Azure.Core;
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
    public partial class AllLeaves : Form
    {
        private List<Request> requests;
        public AllLeaves()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }


        private void AllLeaves_Load_1(object sender, EventArgs e)
        {
            DB.con.Open();

            String sqlQuery = "SELECT leaves.type, leaves.startDate, leaves.endDate, leaves.motif, leaves.requestedAt, leaves.status, users.firstName, users.lastName FROM leaves JOIN users ON leaves.requestedBy = users.id";

            SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

            cmd.Parameters.AddWithValue("userId", Login.userId);

            SqlDataReader reader = cmd.ExecuteReader();

            requests = new List<Request>();

            while (reader.Read())
            {
                // Read the data from the reader and create a new Request object
                Request request = new Request
                {
                    firstName = reader.GetString(6),
                    lastName = reader.GetString(7),
                    type = reader.GetString(0),
                    startDate = reader.GetDateTime(1),
                    endDate = reader.GetDateTime(2),
                    motif = reader.GetString(3),
                    requestedAt = reader.GetDateTime(4),
                    status = reader.GetString(5),
                };
                requests.Add(request); // Add the request to the list
            }

            reader.Close();
                 

            dataGridViewAllLeaves.DataSource = requests;
            DB.con.Close();
        }
    } 
}


