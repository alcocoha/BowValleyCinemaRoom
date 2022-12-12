
namespace BowValleyCinemaRoom
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            string firstName = textFirstName.Text;
            string lastName = textLastName.Text;
            string address = textAddress.Text;
            string birthday = $"{comboMonth.SelectedItem.ToString()}/{comboDay.SelectedItem.ToString()}/{comboYear.SelectedItem.ToString()}";
            string phone = textPhone.Text;
            string email = textEmail.Text;
            string password = textPassword.Text;
            string confirmPassword = textConfirmPassword.Text;
            string type = "isAdmin";

            RegisterQueries registerQueries = new RegisterQueries();

            var data = registerQueries.AddRegister(firstName, lastName, address, birthday, phone, email, password, confirmPassword, type);

            MessageBox.Show(data.Item2);

            if (data.Item1.Equals("success"))
            {
                textFirstName.Clear();
                textLastName.Clear();
                textAddress.Clear();
                comboMonth.SelectedIndex = -1;
                comboDay.SelectedIndex = -1;
                comboYear.SelectedIndex = -1;
                textPhone.Clear();
                textEmail.Clear();
                textPassword.Clear();
                textConfirmPassword.Clear();
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
