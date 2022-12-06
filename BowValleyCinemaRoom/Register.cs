using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace BowValleyCinemaRoom
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string address = textAddress.Text;
            string birthday = $"{comboMonth.SelectedItem.ToString()}/{comboDay.SelectedItem.ToString()}/{comboYear.SelectedItem.ToString()}";
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string type = "isClient";


            DBConnection dbconnection = new DBConnection();

            using (SqlConnection connection = new SqlConnection(dbconnection.GetConnectionString()) ) {

                try
                {
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Review your password again");
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
                            MessageBox.Show("Successful registration");
                            this.Hide();
                        }
                        else {
                            MessageBox.Show("Registration could not be done");
                        }

                    }
                }
                catch (Exception ex){
                    MessageBox.Show("Somenthing went wrong");
                }

            }

        }
    }
}
