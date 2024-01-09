namespace TheBookStore
{
    public partial class ChangePasswordForm : Form
    {
        public string NewPassword { get; private set; }

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        
        private void btnSubmitNewPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match.");
                return;
            }

            NewPassword = txtNewPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
