
namespace BowValleyCinemaRoom
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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

            RegisterQueries registerQueries = new RegisterQueries();

            var data = registerQueries.AddRegister(firstName, lastName, address, birthday, phone, email, password, confirmPassword, type);
            
            MessageBox.Show(data.Item2);

            if (data.Item1.Equals("success")) {
                this.Hide();
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
