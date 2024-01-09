using System.Data.SqlClient;
using System.Security.Cryptography;

namespace TheBookStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string LoggedInUsername { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //Username Validation
            if (string.IsNullOrWhiteSpace(username) ||
                username.Length < 3 ||
                username.Length > 20 ||
                !char.IsUpper(username[0]))
            {
                MessageBox.Show("Username must start with a capital letter, have a minimum of 3 letters, and a maximum of 20 letters.");
                return;
            }

            //Password Validation
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                MessageBox.Show("Password must have a minimum of 8 characters.");
                return;
            }

            if (ValidateCredentials(username, password))
            {
                LoggedInUsername = username;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "SELECT [Password] FROM [Users] WHERE [FirstName] = @Username";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedHashedPassword = reader["Password"].ToString();
                        return VerifyPassword(password, storedHashedPassword); //Compares enterd password to stored password
                    }
                }
            }
            return false;
        }

        //Password verification method
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash); //Converts stored hash from Base64 to a byte array
            int saltSize = 16; //Gathers salt size
            
            //Gets salt from the beginning of the stored hash
            byte[] salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            //Uses the same salt and iteration in the PasswordUtility but applied to entered password
            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000))
            {
                byte[] enteredHash = pbkdf2.GetBytes(20); //Size of the hash minus the salt

                //Result comparison
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + saltSize] != enteredHash[i])
                    {
                        return false; //Entered hashed password doesn't match
                    }
                }
            }
            return true; //Entered hashed password matches
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hides LoginForm after clicking "Create Account"
            using (CreateAccountForm createAccountForm = new CreateAccountForm())
            {
                var result = createAccountForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Account creation successful.");
                }
            }
            this.Show(); //Shows the LoginForm after CreateAccountForm is closed
        }
    }
}
