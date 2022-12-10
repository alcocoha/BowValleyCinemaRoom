using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowValleyCinemaRoom
{
    internal class RegisterQueries
    {
        private DBConnection dbConnection = new DBConnection();


        public (string, string) AddRegister(string firstName, string lastName, string address, string birthday, string phone, string email, string password, string confirmPassword, string type)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
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


        public DataTable GetRegisters()
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spGetRegisters", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtable);
                return dtable;
            }
        }

        public DataTable FilterRegisterBy(string sp, string field, string value)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sp, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(field, value);
                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtable);
                return dtable;
            }
        }


    }
}
