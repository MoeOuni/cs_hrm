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
        public AllLeaves()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }// j ai pas compris l erreur
    private void AllLeaves_Load(object sender, EventArgs e)
    {
        DB.con.Open();

        MessageBox.Show(Login.userId.ToString());

        String sqlQuery = "SELECT leaves.type, leaves.startDate, leaves.endDate, leaves.motif, leaves.requestedAt, leaves.status, users.firstName, users.lastName FROM leaves ";

        SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

        cmd.Parameters.AddWithValue("userId", Login.userId);

        SqlDataReader reader = cmd.ExecuteReader();

        requests = new List<Request>();

        while (reader.Read())
        {
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
            
            requests.Add(request); 
        }

        reader.Close();

        dataGridView.DataSource = requests;
        DB.con.Close();
    }
}



