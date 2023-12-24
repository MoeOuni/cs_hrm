using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hrm
{
    internal class Utils
    {
        public static void UpdateLeaveBalance(int userId, int leaveBalanceChange)
        {
            // Get the user's current leave balance from the database
            int currentLeaveBalance = GetUserLeaveBalance(userId);

            // Check if the current leave balance is sufficient
            if (currentLeaveBalance + leaveBalanceChange < 0)
            {
                throw new Exception("Votre solde de congés n'est pas suffisant.");
            }

            // Update the leave balance in the database
            UpdateUserLeaveBalance(userId, currentLeaveBalance + leaveBalanceChange);
        }

        private static int GetUserLeaveBalance(int userId)
        {
            DB.con.Open();

            String sqlQuery = "SELECT leaveBalance FROM users WHERE id = @userId";

            SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

            cmd.Parameters.AddWithValue("userId", userId);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                int leaveBalance = reader.GetInt32(0);
                reader.Close();
                DB.con.Close();
                return leaveBalance;
            }
            else
            {
                reader.Close();
                DB.con.Close();
                throw new Exception("L'utilisateur n'existe pas.");
            }
        }

        private static void UpdateUserLeaveBalance(int userId, int newLeaveBalance)
        {
            DB.con.Open();

            String sqlQuery = "UPDATE users SET leaveBalance = @newLeaveBalance WHERE id = @userId";

            SqlCommand cmd = new SqlCommand(sqlQuery, DB.con);

            cmd.Parameters.AddWithValue("newLeaveBalance", newLeaveBalance);
            cmd.Parameters.AddWithValue("userId", userId);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected == 0)
            {
                throw new Exception("Une erreur s'est produite lors de la mise à jour du solde des congés de l'utilisateur.");
            }

            DB.con.Close();
        }
    }
}

