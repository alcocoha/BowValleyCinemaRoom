using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register screenRegister = new Register();
            this.Hide();
            screenRegister.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User screenUser = new User();
            Admin screenAdmin = new Admin();

            string email = textEmail.Text;
            string password = textPassword.Text;


            DBConnection dbconnection = new DBConnection();

            using (SqlConnection connection = new SqlConnection(dbconnection.GetConnectionString()))
            {

                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spLogin", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    //MessageBox.Show($"{dtable.Rows.Count}, {dtable.Rows[0][0].ToString()}, {dtable.Rows[0][1].ToString()}, {dtable.Rows[0][2].ToString()}");
                    if (dtable.Rows.Count > 0)
                    {
                        if (dtable.Rows[0][2].ToString() == "isClient") {
                            this.Hide();
                            screenUser.ShowDialog();
                            textEmail.Clear();
                            textPassword.Clear();
                            this.Show();
                        } else if (dtable.Rows[0][2].ToString() == "isAdmin"){
                            this.Hide();
                            screenAdmin.ShowDialog();
                            textEmail.Clear();
                            textPassword.Clear();
                            this.Show();
                        }
                    }
                    else {
                        MessageBox.Show("We did not find users with these credentials");
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show($"Error: {ex}");
                }
            }




            /*
                    if (email == "admin@admin.com" && password == "12345")
                {
                    this.Hide();
                    screenAdmin.ShowDialog();
                    textEmail.Clear();
                    textPassword.Clear();
                    this.Show();
                }
                else if (email == "user@user.com" && password == "asdf")
                {
                    this.Hide();
                    screenUser.ShowDialog();
                    textEmail.Clear();
                    textPassword.Clear();
                    this.Show();
                }
                else {
                    MessageBox.Show("We could found this register");
                }*/


        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
