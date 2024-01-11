using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TheBookStore
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            pnlCreateAccount.Left = (this.ClientSize.Width - pnlCreateAccount.Width) / 2;
            pnlCreateAccount.Top = (this.ClientSize.Height - pnlCreateAccount.Height) / 2;
        }

        private void btnCreateSubmit_Click(object sender, EventArgs e)
        {
            //Make sure Password isn't blank
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Please create a password greater than or equal to 8 characters.");
                return;
            }

            //FirstName Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                !char.IsUpper(txtFirstName.Text[0]) ||
                txtFirstName.Text.Length < 3 ||
                txtFirstName.Text.Length > 20)
            {
                MessageBox.Show("First name must start with a capital letter, minimum of 3 letters, maximum of 20 letters.");
                return;
            }

            //LastName Validation
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                !char.IsUpper(txtLastName.Text[0]) ||
                txtLastName.Text.Length < 2 ||
                txtLastName.Text.Length > 25)
            {
                MessageBox.Show("Last name must start with capital letter, minimum of 2 letters, maximum of 25 letters.");
                return;
            }

            //Email Validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !txtEmail.Text.Contains("@") ||
                !txtEmail.Text.EndsWith(".com") && 
                !txtEmail.Text.EndsWith(".net") && 
                !txtEmail.Text.EndsWith(".org"))
            {
                MessageBox.Show("Email must contain an '@' symbol followed by a web domain.");
                return;
            }

            //PhoneNumber Validation
            /*****************************************
                ^ = string start
                \( and \) = parentheses presence
                \d{3} = first three digits
                \d{3} = second 3 digits
                - = hyphen presence
                \d{4} = last 4 digits
                $ = string end
            ***************************************/
            string phoneNumberPattern = @"^\(\d{3}\)\d{3}-\d{4}$";
            if (txtPhoneNumber.Text.Length < 10 ||
                !Regex.IsMatch(txtPhoneNumber.Text, phoneNumberPattern))
            {
                MessageBox.Show("Phone number must have a minimum of 10 numbers.");
                return;
            }

            //Password Match Validation
            if (txtPassword.Text != txtCreateConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = PasswordUtility.HashPassword(txtPassword.Text);

            if (InsertUserIntoDatabase(txtFirstName.Text, txtLastName.Text, txtEmail.Text, hashedPassword, txtPhoneNumber.Text, txtAddress.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account.");
            }
        }

        //Inserting information on form to Users table
        private bool InsertUserIntoDatabase(string firstName, string lastName, string email, string password, string phoneNumber, string address)
        {
            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "INSERT INTO [Users] (FirstName, LastName, Email, Password, PhoneNumber, Address) VALUES (@FirstName, @LastName, @Email, @Password, @PhoneNumber, @Address)";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrWhiteSpace(phoneNumber) ? DBNull.Value : (object)phoneNumber);
                command.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(address) ? DBNull.Value : (object)address);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; //Cancels result
            this.Close(); //Closees CreateAccountForm
        }
    }
}
