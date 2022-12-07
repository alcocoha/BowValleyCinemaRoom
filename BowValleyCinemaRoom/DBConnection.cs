using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BowValleyCinemaRoom
{
    internal class DBConnection
    {
        private const string connectionString = "Data Source=WSAMZN-1IFU9CTT;Initial Catalog=BowValleyCinemaRoom;"
        + "Integrated Security=true";

        public string GetConnectionString() {
            return connectionString;
        }

        public (string, string) AddRegister(string firstName, string lastName, string address, string birthday, string phone, string email, string password, string confirmPassword, string type ) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    if (password != confirmPassword)
                    {
                        return ("error", "Password and confirm password must match");
                    }
                    else
                    {

                        connection.Open();
                        SqlCommand cmd = new SqlCommand("spInsertRegister", connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Birthday", birthday);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Type", type);

                        var result = cmd.ExecuteNonQuery();

                        if (result == 1)
                        {
                            return ("success", "Successful registration");
                        }
                        else
                        {
                            return ("error", "Registration could not be done");
                        }

                    }
                }
                catch (Exception ex)
                {
                    return ("error", $"Error: {ex}");
                }

            }
        }
    
        
        
    
    
    }
}
