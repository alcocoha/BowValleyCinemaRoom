using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BowValleyCinemaRoom
{

    internal class MovieQueries
    {
        private DBConnection dbConnection = new DBConnection();

        public (string, string) AddMovie(string title, string category, string description, string year, int totalCopies, int price)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {

                try
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spInsertMovie", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@TotalCopies", totalCopies);
                    cmd.Parameters.AddWithValue("@Price", price);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return ("success", "Movie added successfully");
                    }
                    else
                    {
                        return ("error", "Error found while adding movie to DB");
                    }

                }
                catch (Exception ex)
                {
                    return ("error", $"Error: {ex}");
                }

            }
        }

        public DataTable GetMovies()
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spGetMovies", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtable);
                cmd.Connection.Close();
                return dtable;
            }
        }
        public DataTable GetMovieById(int id)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("spGetMovieById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtable);
                return dtable;
            }
        }

        public (string,string) DeleteMovieById(int id)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {
                try { 
                SqlCommand cmd = new SqlCommand("spDeleteMovieById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection.Open();
                var result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return ("success", "Movie updated successfully");
                    }
                    else
                    {
                        return ("error", "Error found while updating movie to DB");
                    }

                }
                catch (Exception ex)
                {
                    return ("error", $"Error: {ex}");
                }
               
            }
        }

        public (string, string) UpdateMovie(int id, string title, string category, string description, string year, int totalCopies, int price)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateMovie", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@TotalCopies", totalCopies);
                    cmd.Parameters.AddWithValue("@Price", price);

                    
                    var result = cmd.ExecuteNonQuery();

                    if (result == -1)
                    {
                        return ("success", "Movie updated successfully");
                    }
                    else
                    {
                        return ("error", "Error found while updating movie to DB");
                    }

                }
                catch (Exception ex)
                {
                    return ("error", $"Error: {ex}");
                }

            }
        }

        public DataTable FilterMoviesBy(string sp, string field, string value)
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

        public (string, string) RentMovie(string movieID, int registerID, string rentDate, string returnDate)
        {
            using (SqlConnection connection = new SqlConnection(dbConnection.GetConnectionString()))
            {

                try
                {

                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spInsertRentalMovie", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MovieID", movieID);
                    cmd.Parameters.AddWithValue("@RegisterID", registerID);
                    cmd.Parameters.AddWithValue("@RentDate", rentDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return ("success", "Movie rented successfully");
                    }
                    else
                    {
                        return ("error", "Error found while renting movie to DB");
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
