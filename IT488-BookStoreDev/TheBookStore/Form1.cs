using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using TheBookStore;

namespace bookstoreapp
{
    public partial class Form1 : Form
    {
        private bool isLoggedIn = false; //Login State Tracker
        private string loggedInUsername;

        public Form1()
        {
            InitializeComponent();

            var initialBooks = GetBooks();
            CreateBookPanels(initialBooks);

            btnBookSearchResetButton.Click += btnBookSearchResetButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBookStock.Visible = true;

            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");
            System.Diagnostics.Debug.WriteLine("Startup...");

            try
            {
                var datasource = @"(local)\SQLExpress";
                var database = "Bookstoredb";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                System.Diagnostics.Debug.WriteLine("Connection Successful");
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error, " + ex);
            }
        }

        public void CreateBookPanels(List<Book> books)
        {
            int panelHeight = pnlBookCard.Height;
            int spacing = 5;

            for (int i = 0; i < books.Count; i++)
            {
                Book currentBook = books[i];

                Panel newPanel = new Panel
                {
                    Size = pnlBookCard.Size,
                    Location = new Point(0, i * (panelHeight + spacing))
                };

                foreach (Control control in pnlBookCard.Controls)
                {
                    Control newControl = (Control)Activator.CreateInstance(control.GetType());

                    newControl.Size = control.Size;
                    newControl.Location = control.Location;
                    newControl.Text = control.Text;
                    newControl.Font = control.Font;
                    newControl.ForeColor = control.ForeColor;
                    newControl.BackColor = control.BackColor;

                    if (control is Button && control.Name == "btnBookCardAddtoCart")
                    {
                        Button addToCartButton = (Button)newControl;
                        addToCartButton.Click += (sender, e) => AddBookToCart(currentBook);
                    }

                    if (control is System.Windows.Forms.Label)
                    {
                        System.Windows.Forms.Label label = newControl as System.Windows.Forms.Label;
                        label.TextAlign = ((System.Windows.Forms.Label)control).TextAlign;

                        if (control.Name == "lbl2BookCardTitle")
                        {
                            label.Text = books[i].Title;
                        }
                        else if (control.Name == "lbl2BookCardAuthor")
                        {
                            label.Text = books[i].Author;
                        }
                        else if (control.Name == "lbl2BookCardPrice")
                        {
                            label.Text = books[i].Price;
                        }
                        else if (control.Name == "lbl2BookCardSynopsis")
                        {
                            label.Text = books[i].Description;
                        }
                    }

                    newPanel.Controls.Add(newControl);
                }

                pnlBookStock.Controls.Add(newPanel);
            }
        }

        public List<Book> GetBooks(string author = null, string title = null, string maxPrice = null)
        {
            var books = new List<Book>();
            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            string sqlQuery = "SELECT [Book Title], [Book Author], [Description], [Price] FROM [Book Information] WHERE 1=1";
            decimal priceValue = 0;

            if (!string.IsNullOrWhiteSpace(author))
            {
                sqlQuery += " AND [Book Author] LIKE @Author";
            }
            if (!string.IsNullOrWhiteSpace(title))
            {
                sqlQuery += " AND [Book Title] LIKE @Title";
            }
            if (!string.IsNullOrWhiteSpace(maxPrice) && decimal.TryParse(maxPrice, out priceValue))
            {
                sqlQuery += " AND [Price] <= @MaxPrice";
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                if (!string.IsNullOrWhiteSpace(author))
                {
                    command.Parameters.AddWithValue("@Author", "%" + author + "%");
                }
                if (!string.IsNullOrWhiteSpace(title))
                {
                    command.Parameters.AddWithValue("@Title", "%" + title + "%");
                }
                if (!string.IsNullOrWhiteSpace(maxPrice))
                {
                    command.Parameters.AddWithValue("@MaxPrice", priceValue);
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var book = new Book
                        {
                            Title = reader["Book Title"].ToString(),
                            Author = reader["Book Author"].ToString(),
                            Price = reader["Price"].ToString(),
                            Description = reader["Description"].ToString()
                        };
                        books.Add(book);
                    }
                }

                conn.Close();
            }

            return books;
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Price { get; set; }
            public string Description { get; set; }
        }

        private void btnBookSearchSearchButton_Click(object sender, EventArgs e)
        {
            string author = txtBookSearchAuthor.Text;
            string title = txtBookSearchTitle.Text;
            string maxPrice = txtBookSearchMaxPrice.Text;

            var filteredBooks = GetBooks(author, title, maxPrice);

            pnlBookStock.Controls.Clear();
            CreateBookPanels(filteredBooks);
        }

        private void btnBookSearchResetButton_Click(object sender, EventArgs e)
        {
            pnlBookStock.Controls.Clear();

            var initialBooks = GetBooks();
            CreateBookPanels(initialBooks);

            txtBookSearchAuthor.Text = "";
            txtBookSearchTitle.Text = "";
            txtBookSearchMaxPrice.Text = "";
        }

        private void btnAccountPage_Click(object sender, EventArgs e)
        {
            ShowLoginForm();

            if (isLoggedIn)
            {
                //User successfully logs in
                pnlBookStock.Visible = false;
                pnlBookSearch.Visible = false;
                pnlAccountPage.Visible = true;
                pnlCartPage.Visible = false;
            }
            else
            {
                //User fails to log in
                pnlBookStock.Visible = true;
                pnlBookSearch.Visible = true;
                pnlAccountPage.Visible = false;
                pnlCartPage.Visible = false;
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlBookStock.Visible = true;
            pnlBookSearch.Visible = true;
            pnlAccountPage.Visible = false;
            pnlCartPage.Visible = false;
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            if (isLoggedIn)
            {
                return;
            }

            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Successful Login");

                    //Sets the logged in username
                    loggedInUsername = loginForm.LoggedInUsername;

                    btnLoginPage.Enabled = false;

                    //Login State Tracker Updated
                    isLoggedIn = true;

                    //Fetching User Details
                    User user = GetUserDetails(loginForm.LoggedInUsername);

                    //Label Update
                    if (user != null)
                    {
                        lbl2FirstNameAccount.Text = user.FirstName;
                        lbl2LastNameAccount.Text = user.LastName;
                        lbl2AddressAccount.Text = user.Address;
                        lbl2PhoneAccount.Text = user.PhoneNumber;
                        lbl2EmailAccount.Text = user.Email;
                    }
                }
                else
                {
                    MessageBox.Show("Login failed or canceled.");
                }
            }
        }

        private User GetUserDetails(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }

            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "SELECT FirstName, LastName, Address, PhoneNumber, Email FROM [Users] WHERE [FirstName] = @Username";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@Username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        public class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
        }

        private void btnLogOutAccount_Click(object sender, EventArgs e)
        {
            //Reset Login Tracker State
            isLoggedIn = false;

            lbl2FirstNameAccount.Text = "";
            lbl2LastNameAccount.Text = "";
            lbl2AddressAccount.Text = "";
            lbl2PhoneAccount.Text = "";
            lbl2EmailAccount.Text = "";

            btnLoginPage.Enabled = true;

            pnlBookStock.Visible = true;
            pnlBookSearch.Visible = true;
            pnlAccountPage.Visible = false;

            MessageBox.Show("You have logged out.");
        }

        private void btnChangePasswordAccount_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changePasswordForm = new ChangePasswordForm())
            {
                if (changePasswordForm.ShowDialog() == DialogResult.OK)
                {
                    //Calls password update method
                    string newPassword = changePasswordForm.NewPassword;
                    UpdateUserPassword(loggedInUsername, newPassword);
                }
            }
        }

        //Update Password Method
        private void UpdateUserPassword(string username, string newPassword)
        {
            string hashedPassword = PasswordUtility.HashPassword(newPassword);

            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "UPDATE [Users] SET [Password] = @NewPassword WHERE [FirstName] = @Username";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@NewPassword", hashedPassword);
                command.Parameters.AddWithValue("@Username", username);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated successfully");
                }
                else
                {
                    MessageBox.Show("Password update failed.");
                }
            }
        }

        private void btnEditInfoAccount_Click(object sender, EventArgs e)
        {
            //Convert labels to textboxes and populate with current info
            txtFirstNameAccount.Text = lbl2FirstNameAccount.Text;
            txtLastNameAccount.Text = lbl2LastNameAccount.Text;
            txtEmailAccount.Text = lbl2EmailAccount.Text;
            txtPhoneNumberAccount.Text = lbl2PhoneAccount.Text;
            txtAddressAccount.Text = lbl2AddressAccount.Text;

            //Make Save and Cancel button visible
            btnSaveChangesAccount.Visible = true;
            btnCancelAccount.Visible = true;

            //Make Edit Info, Log out, and change password button invisible
            btnEditInfoAccount.Visible = false;
            btnLogOutAccount.Visible = false;
            btnChangePasswordAccount.Visible = false;

            //Hide labels
            lbl2FirstNameAccount.Visible = false;
            lbl2LastNameAccount.Visible = false;
            lbl2EmailAccount.Visible = false;
            lbl2PhoneAccount.Visible = false;
            lbl2AddressAccount.Visible = false;

            //Make textboxes visible
            txtFirstNameAccount.Visible = true;
            txtLastNameAccount.Visible = true;
            txtEmailAccount.Visible = true;
            txtPhoneNumberAccount.Visible = true;
            txtAddressAccount.Visible = true;
        }

        private void btnSaveChangesAccount_Click(object sender, EventArgs e)
        {
            //FirstName Validation
            if (string.IsNullOrWhiteSpace(txtFirstNameAccount.Text) ||
                !char.IsUpper(txtFirstNameAccount.Text[0]) ||
                txtFirstNameAccount.Text.Length < 3 ||
                txtFirstNameAccount.Text.Length > 20)
            {
                MessageBox.Show("First name must start with a capital letter, minimum of 3 letters, maximum of 20 letters.");
                return;
            }

            //LastName Validation
            if (string.IsNullOrWhiteSpace(txtLastNameAccount.Text) ||
                !char.IsUpper(txtLastNameAccount.Text[0]) ||
                txtLastNameAccount.Text.Length < 2 ||
                txtLastNameAccount.Text.Length > 25)
            {
                MessageBox.Show("Last name must start with capital letter, minimum of 2 letters, maximum of 25 letters.");
                return;
            }

            //Email Validation
            if (string.IsNullOrWhiteSpace(txtEmailAccount.Text) ||
                !txtEmailAccount.Text.Contains("@") ||
                !txtEmailAccount.Text.EndsWith(".com") &&
                !txtEmailAccount.Text.EndsWith(".net") &&
                !txtEmailAccount.Text.EndsWith(".org"))
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
            if (txtPhoneNumberAccount.Text.Length < 10 ||
                !Regex.IsMatch(txtPhoneNumberAccount.Text, phoneNumberPattern))
            {
                MessageBox.Show("Phone number must have a minimum of 10 numbers.");
                return;
            }

            //Execute UpdateUserInfo method
            UpdateUserInfo(loggedInUsername,
                            txtFirstNameAccount.Text,
                            txtLastNameAccount.Text,
                            txtEmailAccount.Text,
                            txtPhoneNumberAccount.Text,
                            txtAddressAccount.Text);
        }

        //UpdateUserInfo Method
        private void UpdateUserInfo(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            var datasource = @"(local)\SQLExpress";
            var database = "Bookstoredb";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlQuery = "UPDATE [Users] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Address = @Address WHERE [FirstName] = @Username";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Username", username);

                command.ExecuteNonQuery();
            }

            //Update labels
            lbl2FirstNameAccount.Text = firstName;
            lbl2LastNameAccount.Text = lastName;
            lbl2EmailAccount.Text = email;
            lbl2PhoneAccount.Text = phoneNumber;
            lbl2AddressAccount.Text = address;

            //Switch textboxes back to labels
            lbl2FirstNameAccount.Text = txtFirstNameAccount.Text;
            lbl2LastNameAccount.Text = txtLastNameAccount.Text;
            lbl2EmailAccount.Text = txtEmailAccount.Text;
            lbl2PhoneAccount.Text = txtPhoneNumberAccount.Text;
            lbl2AddressAccount.Text = txtAddressAccount.Text;

            //Make Save and Cancel button invisible
            btnSaveChangesAccount.Visible = false;
            btnCancelAccount.Visible = false;

            //Make Edit Info, Log out, and change password button visible
            btnEditInfoAccount.Visible = true;
            btnLogOutAccount.Visible = true;
            btnChangePasswordAccount.Visible = true;

            //Make labels visible
            lbl2FirstNameAccount.Visible = true;
            lbl2LastNameAccount.Visible = true;
            lbl2EmailAccount.Visible = true;
            lbl2PhoneAccount.Visible = true;
            lbl2AddressAccount.Visible = true;

            //Make textboxes invisible
            txtFirstNameAccount.Visible = false;
            txtLastNameAccount.Visible = false;
            txtEmailAccount.Visible = false;
            txtPhoneNumberAccount.Visible = false;
            txtAddressAccount.Visible = false;
        }

        //Cancel the Edit Info View
        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            //Revert textboxes back to labels without saving
            lbl2FirstNameAccount.Text = txtFirstNameAccount.Text;
            lbl2LastNameAccount.Text = txtLastNameAccount.Text;
            lbl2EmailAccount.Text = txtEmailAccount.Text;
            lbl2PhoneAccount.Text = txtPhoneNumberAccount.Text;
            lbl2AddressAccount.Text = txtAddressAccount.Text;

            //Make Save and Cancel button invisible
            btnSaveChangesAccount.Visible = false;
            btnCancelAccount.Visible = false;

            //Make Edit Info, Log out, and Change Password button visible
            btnEditInfoAccount.Visible = true;
            btnLogOutAccount.Visible = true;
            btnChangePasswordAccount.Visible = true;

            //Make labels visible
            lbl2FirstNameAccount.Visible = true;
            lbl2LastNameAccount.Visible = true;
            lbl2EmailAccount.Visible = true;
            lbl2PhoneAccount.Visible = true;
            lbl2AddressAccount.Visible = true;

            //Make textboxes invisible
            txtFirstNameAccount.Visible = false;
            txtLastNameAccount.Visible = false;
            txtEmailAccount.Visible = false;
            txtPhoneNumberAccount.Visible = false;
            txtAddressAccount.Visible = false;
        }

        private List<Tuple<Book, int>> cartBooks = new List<Tuple<Book, int>>();

        private void AddBookToCart(Book book)
        {
            var existingEntry = cartBooks.FirstOrDefault(t => t.Item1 == book);
            if (existingEntry != null)
            {
                //Quantity increases when book already exists in cart
                int newQuantity = existingEntry.Item2 + 1;
                cartBooks[cartBooks.IndexOf(existingEntry)] = new Tuple<Book, int>(book, newQuantity);
            }
            else
            {
                //New book entered
                cartBooks.Add(new Tuple<Book, int>(book, 1));
            }
            RefreshCartDisplay();
            MessageBox.Show("Book added to cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CalculateCartTotal();
        }

        private void btnCartPage_Click(object sender, EventArgs e)
        {
            //Hide pnlBookSearch, pnlBookStock, pnlAccountPage
            pnlBookSearch.Visible = false;
            pnlBookStock.Visible = false;
            pnlAccountPage.Visible = false;

            //Show pnlCartPage
            pnlCartPage.Visible = true;

            //Refresh cart display
            RefreshCartDisplay();
        }

        private Panel CreateCartItemPanel(Book book, int quantity, int index)
        {
            int panelHeight = pnlCartItem.Height;
            int spacing = 5;
            int yPosition = index * (panelHeight + spacing);

            Panel cartItemPanel = new Panel
            {
                Size = pnlCartItem.Size,
                Location = new Point(0, yPosition)
            };

            foreach (Control control in pnlCartItem.Controls)
            {
                if (control is Label)
                {
                    Label clonedLabel = CloneLabel(control as Label);

                    if (control.Name == "lblTitleCartItem")
                        clonedLabel.Text = book.Title;
                    else if (control.Name == "lblAuthorCartItem")
                        clonedLabel.Text = book.Author;
                    else if (control.Name == "lblPriceCartItem")
                        clonedLabel.Text = book.Price;
                    else if (control.Name == "lblDescriptionCartItem")
                        clonedLabel.Text = book.Description;
                    else if (control.Name == "lblCartItemQuantity")
                        clonedLabel.Text = $"{quantity}";

                    cartItemPanel.Controls.Add(clonedLabel);
                }
                else if (control is Button)
                {
                    Button clonedButton = CloneButton(control as Button);
                    if (control.Name == "btnCartItemRemove")
                    {
                        clonedButton.Tag = new Tuple<Book, int>(book, quantity);
                        clonedButton.Click += btnCartItemRemove_Click;
                    }
                    cartItemPanel.Controls.Add(clonedButton);
                }
            }
            return cartItemPanel;
        }

        //CloneLabel attributes for CreateCartItemPanel
        private Label CloneLabel(Label original)
        {
            return new Label
            {
                AutoSize = original.AutoSize,
                ForeColor = original.ForeColor,
                BackColor = original.BackColor,
                Font = new Font(original.Font.FontFamily, original.Font.Size),
                Location = original.Location,
                Size = original.Size,
                TextAlign = original.TextAlign,
                Text = original.Text
            };
        }

        //CloneButton attributes for CreateCartItemPanel
        private Button CloneButton(Button original)
        {
            return new Button
            {
                Text = original.Text,
                Location = original.Location,
                Size = original.Size,
                BackColor = original.BackColor,
                ForeColor = original.ForeColor,
                Font = new Font(original.Font.FontFamily, original.Font.Size)
            };
        }

        private void btnCartItemRemove_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Tuple<Book, int> entry)
            {
                if (entry.Item2 > 1)
                {
                    //Decrease quantity
                    int newQuantity = entry.Item2 - 1;
                    cartBooks[cartBooks.IndexOf(entry)] = new Tuple<Book, int>(entry.Item1, newQuantity);
                }
                else
                {
                    //Remove from cart
                    cartBooks.Remove(entry);
                }
                RefreshCartDisplay();
                MessageBox.Show("Book successfully removed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CalculateCartTotal();
            }
        }

        private void RefreshCartDisplay()
        {
            pnlCart.Controls.Clear();

            for (int i = 0; i < cartBooks.Count; i++)
            {
                var cartItem = cartBooks[i];
                Panel cartItemPanel = CreateCartItemPanel(cartItem.Item1, cartItem.Item2, i);
                pnlCart.Controls.Add(cartItemPanel);
            }
            CalculateCartTotal();
        }

        private decimal CalculateCartTotal()
        {
            decimal total = 0;
            foreach (var entry in cartBooks)
            {
                if (decimal.TryParse(entry.Item1.Price, out decimal bookPrice))
                {
                    total += bookPrice * entry.Item2;
                }
            }
            lblCartTotal.Text = $"${total:F2}";
            return total;
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            //Cart is already empty check
            if (cartBooks.Count == 0)
            {
                MessageBox.Show("Your cart has already been emptied.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //Clear cart
            cartBooks.Clear();

            //Refresh cart panel
            RefreshCartDisplay();

            //Update total
            CalculateCartTotal();

            //Acknowledgement
            MessageBox.Show("Cart has been emptied.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCheckoutCart_Click(object sender, EventArgs e)
        {
            //Check if cart is empty
            if (cartBooks.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; //Early return
            }
            
            if (isLoggedIn)
            {
                //Show labels with user info
                User currentUser = GetUserDetails(loggedInUsername);
                lblFirstNameCheckout.Text = currentUser.FirstName;
                lblLastNameCheckout.Text = currentUser.LastName;
                lblAddressCheckout.Text = currentUser.Address;
                lblPhoneNumberCheckout.Text = currentUser.PhoneNumber;

                //Hide textboxes
                txtFirstNameCheckout.Visible = false;
                txtLastNameCheckout.Visible = false;
                txtAddressCheckout.Visible = false;
                txtPhoneNumberCheckout.Visible = false;

                //Show labels
                lblFirstNameCheckout.Visible = true;
                lblLastNameCheckout.Visible = true;
                lblAddressCheckout.Visible = true;
                lblPhoneNumberCheckout.Visible = true;

                //Hide Login Button
                btnLoginCheckout.Visible = false;
            }
            else
            {
                //Show textboxes for users to fill
                txtFirstNameCheckout.Visible = true;
                txtLastNameCheckout.Visible = true;
                txtAddressCheckout.Visible = true;
                txtPhoneNumberCheckout.Visible = true;

                //Hide labels
                lblFirstNameCheckout.Visible = false;
                lblLastNameCheckout.Visible = false;
                lblAddressCheckout.Visible = false;
                lblPhoneNumberCheckout.Visible = false;
            }

            //Update quantity and total
            lblQuantityCheckout.Text = cartBooks.Sum(item => item.Item2).ToString();
            lblTotalCheckout.Text = CalculateCartTotal().ToString("C2");

            //Hide current panels and show pnlCheckoutPage
            pnlCartPage.Visible = false;
            pnlCheckoutPage.Visible = true;
        }

        private void btnCancelCheckout_Click(object sender, EventArgs e)
        {
            pnlCheckoutPage.Visible = false;
            pnlCartPage.Visible = true;
        }

        private void btnLoginCheckout_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
            if (isLoggedIn)
            {
                btnCheckoutCart_Click(sender, e);
            }
        }

        private void btnConfirmCheckout_Click(object sender, EventArgs e)
        {
            string firstName;
            if (isLoggedIn)
            {
                //Use the text from the label of logged in user
                firstName = lblFirstNameCheckout.Text;
            }
            else
            {
                //Use the text from the entered first name field
                firstName = txtFirstNameCheckout.Text;
            }

            MessageBox.Show($"Thank you for shopping with us, {firstName}!");

            //Clear Textboxes
            txtFirstNameCheckout.Text = "";
            txtLastNameCheckout.Text = "";
            txtAddressCheckout.Text = "";
            txtPhoneNumberCheckout.Text = "";
            
            //Clear cart and go back to home page
            cartBooks.Clear();
            pnlCheckoutPage.Visible = false;
            pnlBookSearch.Visible = true;
            pnlBookStock.Visible = true;
        }
    }
}
