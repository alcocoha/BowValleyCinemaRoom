using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowValleyCinemaRoom
{
    public partial class UpdateRegister : Form
    {
        int RegisterID;
        public UpdateRegister(int Id)
        {
            InitializeComponent();
            RegisterID = Id;
        }

        public UpdateRegister()
        {
            InitializeComponent();
        }

        private void UpdateRegister_Load_1(object sender, EventArgs e)
        {
            RegisterQueries registerQueries = new RegisterQueries();
            DataTable dtable = new DataTable();
            dtable = registerQueries.GetRegisterById(RegisterID);
            textFirstName.Text = dtable.Rows[0].Field<string>("FirstName");
            textLastName.Text = dtable.Rows[0].Field<string>("LastName");
            textAddress.Text = dtable.Rows[0].Field<string>("Address");
            string[] date = dtable.Rows[0].Field<string>("Birthday").Split('/');
            comboMonth.SelectedItem = date[0];
            comboDay.SelectedItem = date[1];
            comboYear.SelectedItem = date[2];
            textPhone.Text = dtable.Rows[0].Field<string>("Phone");
            textEmail.Text = dtable.Rows[0].Field<string>("Email");
            textPassword.Text = dtable.Rows[0].Field<string>("Password");
            textConfirmPassword.Text = dtable.Rows[0].Field<string>("Password");
        }

        private void btnUpdateRegister_Click(object sender, EventArgs e)
        {
            int id = RegisterID;
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string address = textAddress.Text;
            string birthday = $"{comboMonth.SelectedItem.ToString()}/{comboDay.SelectedItem.ToString()}/{comboYear.SelectedItem.ToString()}";
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;

            RegisterQueries registerQueries = new RegisterQueries();

            var data = registerQueries.UpdateRegister(id, firstName, lastName, address, birthday, phone, email, password, confirmPassword);

            MessageBox.Show(data.Item2);
        }
    }
}
