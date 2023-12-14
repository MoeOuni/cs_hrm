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

            string sql_query = "select type, startDate, endDate, motif, requestedAt, status from leaves";

            SqlCommand cmd = new SqlCommand(sql_query, DB.con);

            SqlDataReader reader = cmd.ExecuteReader();

            requests = new List<Request>(); // Create a new instance of the requests list

            while (reader.Read())
            {
                // Read the data from the reader and create a new Request object
                Request request = new Request
                {
                    type = reader.GetString(0),
                    startDate = reader.GetDateTime(1),
                    endDate = reader.GetDateTime(2),
                    motif = reader.GetString(3),
                    requestedAt = reader.GetDateTime(4),
                    status = reader.GetString(5)
                };

                requests.Add(request); // Add the request to the list
            }

            reader.Close();

            dataGridView.DataSource = requests;
            DB.con.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Home page = new Home();

            page.Show();
            this.Hide();
        }
    }
}
