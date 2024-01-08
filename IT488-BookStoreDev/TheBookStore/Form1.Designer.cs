namespace bookstoreapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            btnAccountPage = new Button();
            btnCartPage = new Button();
            pnlNavBar = new Panel();
            btnHomePage = new Button();
            btnLoginPage = new Button();
            pnlBookSearch = new Panel();
            btnBookSearchResetButton = new Button();
            label3 = new Label();
            btnBookSearchSearchButton = new Button();
            lblBookSearchMaxPrice = new Label();
            lblBookSearchTitle = new Label();
            txtBookSearchMaxPrice = new TextBox();
            txtBookSearchTitle = new TextBox();
            lblBookSearchAuthor = new Label();
            txtBookSearchAuthor = new TextBox();
            panel3 = new Panel();
            pnlBookStock = new Panel();
            pnlBookCard = new Panel();
            btnBookCardDetailedViewButton = new Button();
            btnBookCardAddtoCartButton = new Button();
            lblBookCardDivider = new Label();
            lbl2BookCardSynopsis = new Label();
            lbl2BookCardPrice = new Label();
            lbl2BookCardAuthor = new Label();
            lbl2BookCardTitle = new Label();
            lblBookCardSynopsis = new Label();
            lblBookCardPrice = new Label();
            textBox6 = new TextBox();
            lblBookCardAuthor = new Label();
            lblBookCardTitle = new Label();
            picBookCardCover = new PictureBox();
            lblAppName = new Label();
            txtDebugText = new TextBox();
            pnlAccountPage = new Panel();
            btnLogOutAccount = new Button();
            btnChangePasswordAccount = new Button();
            btnEditInfoAccount = new Button();
            lbl2EmailAccount = new Label();
            lbl2PhoneAccount = new Label();
            lbl2AddressAccount = new Label();
            lbl2UsernameAccount = new Label();
            lbl2LastNameAccount = new Label();
            lbl2FirstNameAccount = new Label();
            lblUsernameAccount = new Label();
            lblAddressAccount = new Label();
            lblPhoneAccount = new Label();
            lblEmailAccount = new Label();
            lblLastNameAccount = new Label();
            lblFirstNameAccount = new Label();
            label1 = new Label();
            pnlNavBar.SuspendLayout();
            pnlBookSearch.SuspendLayout();
            pnlBookStock.SuspendLayout();
            pnlBookCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCardCover).BeginInit();
            pnlAccountPage.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(2196, 984);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 43);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(2202, 990);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 43);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(2208, 996);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(92, 43);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(2214, 1002);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(92, 43);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnAccountPage
            // 
            btnAccountPage.BackColor = Color.Chocolate;
            btnAccountPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccountPage.ForeColor = Color.Black;
            btnAccountPage.Location = new Point(375, 13);
            btnAccountPage.Margin = new Padding(2);
            btnAccountPage.Name = "btnAccountPage";
            btnAccountPage.Size = new Size(157, 66);
            btnAccountPage.TabIndex = 6;
            btnAccountPage.Text = "Account";
            btnAccountPage.UseVisualStyleBackColor = false;
            btnAccountPage.Click += btnAccountPage_Click;
            // 
            // btnCartPage
            // 
            btnCartPage.BackColor = Color.Chocolate;
            btnCartPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCartPage.ForeColor = Color.Black;
            btnCartPage.Location = new Point(722, 13);
            btnCartPage.Margin = new Padding(2);
            btnCartPage.Name = "btnCartPage";
            btnCartPage.Size = new Size(157, 66);
            btnCartPage.TabIndex = 8;
            btnCartPage.Text = "Cart";
            btnCartPage.UseVisualStyleBackColor = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = SystemColors.InactiveCaption;
            pnlNavBar.Controls.Add(btnHomePage);
            pnlNavBar.Controls.Add(btnCartPage);
            pnlNavBar.Controls.Add(btnAccountPage);
            pnlNavBar.Controls.Add(btnLoginPage);
            pnlNavBar.Location = new Point(0, 97);
            pnlNavBar.Margin = new Padding(2);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1282, 91);
            pnlNavBar.TabIndex = 9;
            // 
            // btnHomePage
            // 
            btnHomePage.BackColor = Color.Chocolate;
            btnHomePage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomePage.ForeColor = Color.Black;
            btnHomePage.Location = new Point(50, 13);
            btnHomePage.Margin = new Padding(2);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(157, 66);
            btnHomePage.TabIndex = 7;
            btnHomePage.Text = "Home";
            btnHomePage.UseVisualStyleBackColor = false;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // btnLoginPage
            // 
            btnLoginPage.BackColor = Color.Chocolate;
            btnLoginPage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginPage.ForeColor = Color.Black;
            btnLoginPage.ImageAlign = ContentAlignment.BottomCenter;
            btnLoginPage.Location = new Point(1033, 13);
            btnLoginPage.Margin = new Padding(2);
            btnLoginPage.Name = "btnLoginPage";
            btnLoginPage.Size = new Size(157, 66);
            btnLoginPage.TabIndex = 1;
            btnLoginPage.Text = "Log In";
            btnLoginPage.UseVisualStyleBackColor = false;
            btnLoginPage.Click += btnLoginPage_Click;
            // 
            // pnlBookSearch
            // 
            pnlBookSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlBookSearch.Controls.Add(btnBookSearchResetButton);
            pnlBookSearch.Controls.Add(label3);
            pnlBookSearch.Controls.Add(btnBookSearchSearchButton);
            pnlBookSearch.Controls.Add(lblBookSearchMaxPrice);
            pnlBookSearch.Controls.Add(lblBookSearchTitle);
            pnlBookSearch.Controls.Add(txtBookSearchMaxPrice);
            pnlBookSearch.Controls.Add(txtBookSearchTitle);
            pnlBookSearch.Controls.Add(lblBookSearchAuthor);
            pnlBookSearch.Controls.Add(txtBookSearchAuthor);
            pnlBookSearch.Location = new Point(50, 213);
            pnlBookSearch.Margin = new Padding(2);
            pnlBookSearch.Name = "pnlBookSearch";
            pnlBookSearch.Size = new Size(207, 285);
            pnlBookSearch.TabIndex = 10;
            // 
            // btnBookSearchResetButton
            // 
            btnBookSearchResetButton.Location = new Point(86, 233);
            btnBookSearchResetButton.Name = "btnBookSearchResetButton";
            btnBookSearchResetButton.Size = new Size(75, 23);
            btnBookSearchResetButton.TabIndex = 15;
            btnBookSearchResetButton.Text = "Reset";
            btnBookSearchResetButton.UseVisualStyleBackColor = true;
            btnBookSearchResetButton.Click += btnBookSearchResetButton_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(0, 2);
            label3.Margin = new Padding(2);
            label3.Name = "label3";
            label3.Size = new Size(123, 29);
            label3.TabIndex = 14;
            label3.Text = "Book Search";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBookSearchSearchButton
            // 
            btnBookSearchSearchButton.Location = new Point(3, 233);
            btnBookSearchSearchButton.Margin = new Padding(2);
            btnBookSearchSearchButton.Name = "btnBookSearchSearchButton";
            btnBookSearchSearchButton.Size = new Size(78, 24);
            btnBookSearchSearchButton.TabIndex = 13;
            btnBookSearchSearchButton.Text = "Search";
            btnBookSearchSearchButton.UseVisualStyleBackColor = true;
            btnBookSearchSearchButton.Click += btnBookSearchSearchButton_Click;
            // 
            // lblBookSearchMaxPrice
            // 
            lblBookSearchMaxPrice.AutoSize = true;
            lblBookSearchMaxPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookSearchMaxPrice.Location = new Point(35, 173);
            lblBookSearchMaxPrice.Margin = new Padding(2, 0, 2, 0);
            lblBookSearchMaxPrice.Name = "lblBookSearchMaxPrice";
            lblBookSearchMaxPrice.Size = new Size(86, 20);
            lblBookSearchMaxPrice.TabIndex = 12;
            lblBookSearchMaxPrice.Text = "Max Price";
            // 
            // lblBookSearchTitle
            // 
            lblBookSearchTitle.AutoSize = true;
            lblBookSearchTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookSearchTitle.Location = new Point(35, 114);
            lblBookSearchTitle.Margin = new Padding(2, 0, 2, 0);
            lblBookSearchTitle.Name = "lblBookSearchTitle";
            lblBookSearchTitle.Size = new Size(43, 20);
            lblBookSearchTitle.TabIndex = 12;
            lblBookSearchTitle.Text = "Title";
            // 
            // txtBookSearchMaxPrice
            // 
            txtBookSearchMaxPrice.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookSearchMaxPrice.Location = new Point(0, 197);
            txtBookSearchMaxPrice.Margin = new Padding(2);
            txtBookSearchMaxPrice.Name = "txtBookSearchMaxPrice";
            txtBookSearchMaxPrice.Size = new Size(180, 23);
            txtBookSearchMaxPrice.TabIndex = 3;
            txtBookSearchMaxPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBookSearchTitle
            // 
            txtBookSearchTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookSearchTitle.Location = new Point(0, 138);
            txtBookSearchTitle.Margin = new Padding(2);
            txtBookSearchTitle.Name = "txtBookSearchTitle";
            txtBookSearchTitle.Size = new Size(178, 23);
            txtBookSearchTitle.TabIndex = 2;
            txtBookSearchTitle.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBookSearchAuthor
            // 
            lblBookSearchAuthor.AutoSize = true;
            lblBookSearchAuthor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookSearchAuthor.Location = new Point(35, 48);
            lblBookSearchAuthor.Margin = new Padding(2, 0, 2, 0);
            lblBookSearchAuthor.Name = "lblBookSearchAuthor";
            lblBookSearchAuthor.Size = new Size(63, 20);
            lblBookSearchAuthor.TabIndex = 1;
            lblBookSearchAuthor.Text = "Author";
            // 
            // txtBookSearchAuthor
            // 
            txtBookSearchAuthor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookSearchAuthor.Location = new Point(0, 72);
            txtBookSearchAuthor.Margin = new Padding(2);
            txtBookSearchAuthor.Name = "txtBookSearchAuthor";
            txtBookSearchAuthor.Size = new Size(178, 23);
            txtBookSearchAuthor.TabIndex = 0;
            txtBookSearchAuthor.TextAlign = HorizontalAlignment.Right;
            // 
            // panel3
            // 
            panel3.Location = new Point(618, 523);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 6);
            panel3.TabIndex = 11;
            // 
            // pnlBookStock
            // 
            pnlBookStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBookStock.AutoScroll = true;
            pnlBookStock.BorderStyle = BorderStyle.Fixed3D;
            pnlBookStock.Controls.Add(pnlBookCard);
            pnlBookStock.Location = new Point(262, 213);
            pnlBookStock.Margin = new Padding(2);
            pnlBookStock.Name = "pnlBookStock";
            pnlBookStock.Size = new Size(1011, 484);
            pnlBookStock.TabIndex = 12;
            // 
            // pnlBookCard
            // 
            pnlBookCard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlBookCard.BorderStyle = BorderStyle.FixedSingle;
            pnlBookCard.Controls.Add(btnBookCardDetailedViewButton);
            pnlBookCard.Controls.Add(btnBookCardAddtoCartButton);
            pnlBookCard.Controls.Add(lblBookCardDivider);
            pnlBookCard.Controls.Add(lbl2BookCardSynopsis);
            pnlBookCard.Controls.Add(lbl2BookCardPrice);
            pnlBookCard.Controls.Add(lbl2BookCardAuthor);
            pnlBookCard.Controls.Add(lbl2BookCardTitle);
            pnlBookCard.Controls.Add(lblBookCardSynopsis);
            pnlBookCard.Controls.Add(lblBookCardPrice);
            pnlBookCard.Controls.Add(textBox6);
            pnlBookCard.Controls.Add(lblBookCardAuthor);
            pnlBookCard.Controls.Add(lblBookCardTitle);
            pnlBookCard.Controls.Add(picBookCardCover);
            pnlBookCard.Location = new Point(2, 2);
            pnlBookCard.Margin = new Padding(2);
            pnlBookCard.Name = "pnlBookCard";
            pnlBookCard.Size = new Size(1003, 225);
            pnlBookCard.TabIndex = 0;
            pnlBookCard.Visible = false;
            // 
            // btnBookCardDetailedViewButton
            // 
            btnBookCardDetailedViewButton.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBookCardDetailedViewButton.Location = new Point(651, 27);
            btnBookCardDetailedViewButton.Name = "btnBookCardDetailedViewButton";
            btnBookCardDetailedViewButton.Size = new Size(24, 23);
            btnBookCardDetailedViewButton.TabIndex = 19;
            btnBookCardDetailedViewButton.Text = "i";
            btnBookCardDetailedViewButton.UseVisualStyleBackColor = true;
            // 
            // btnBookCardAddtoCartButton
            // 
            btnBookCardAddtoCartButton.Location = new Point(393, 172);
            btnBookCardAddtoCartButton.Name = "btnBookCardAddtoCartButton";
            btnBookCardAddtoCartButton.Size = new Size(94, 23);
            btnBookCardAddtoCartButton.TabIndex = 18;
            btnBookCardAddtoCartButton.Text = "Add to Cart";
            btnBookCardAddtoCartButton.UseVisualStyleBackColor = true;
            // 
            // lblBookCardDivider
            // 
            lblBookCardDivider.BackColor = Color.Coral;
            lblBookCardDivider.ForeColor = Color.Coral;
            lblBookCardDivider.Location = new Point(-1, 213);
            lblBookCardDivider.Name = "lblBookCardDivider";
            lblBookCardDivider.Size = new Size(999, 10);
            lblBookCardDivider.TabIndex = 17;
            lblBookCardDivider.Text = "label1";
            // 
            // lbl2BookCardSynopsis
            // 
            lbl2BookCardSynopsis.ForeColor = SystemColors.ControlText;
            lbl2BookCardSynopsis.Location = new Point(393, 53);
            lbl2BookCardSynopsis.MaximumSize = new Size(150, 200);
            lbl2BookCardSynopsis.Name = "lbl2BookCardSynopsis";
            lbl2BookCardSynopsis.Size = new Size(150, 104);
            lbl2BookCardSynopsis.TabIndex = 16;
            lbl2BookCardSynopsis.Text = "Description";
            lbl2BookCardSynopsis.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl2BookCardPrice
            // 
            lbl2BookCardPrice.ForeColor = SystemColors.ControlText;
            lbl2BookCardPrice.Location = new Point(192, 172);
            lbl2BookCardPrice.Name = "lbl2BookCardPrice";
            lbl2BookCardPrice.Size = new Size(82, 32);
            lbl2BookCardPrice.TabIndex = 15;
            lbl2BookCardPrice.Text = "Price";
            lbl2BookCardPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2BookCardAuthor
            // 
            lbl2BookCardAuthor.ForeColor = SystemColors.ControlText;
            lbl2BookCardAuthor.Location = new Point(192, 104);
            lbl2BookCardAuthor.Name = "lbl2BookCardAuthor";
            lbl2BookCardAuthor.Size = new Size(88, 41);
            lbl2BookCardAuthor.TabIndex = 14;
            lbl2BookCardAuthor.Text = "Author";
            lbl2BookCardAuthor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2BookCardTitle
            // 
            lbl2BookCardTitle.ForeColor = SystemColors.ControlText;
            lbl2BookCardTitle.Location = new Point(191, 37);
            lbl2BookCardTitle.Name = "lbl2BookCardTitle";
            lbl2BookCardTitle.Size = new Size(162, 43);
            lbl2BookCardTitle.TabIndex = 13;
            lbl2BookCardTitle.Text = "TItle";
            lbl2BookCardTitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblBookCardSynopsis
            // 
            lblBookCardSynopsis.BackColor = Color.Coral;
            lblBookCardSynopsis.BorderStyle = BorderStyle.Fixed3D;
            lblBookCardSynopsis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCardSynopsis.ForeColor = SystemColors.WindowText;
            lblBookCardSynopsis.Location = new Point(393, 29);
            lblBookCardSynopsis.Margin = new Padding(2);
            lblBookCardSynopsis.Name = "lblBookCardSynopsis";
            lblBookCardSynopsis.Size = new Size(253, 21);
            lblBookCardSynopsis.TabIndex = 12;
            lblBookCardSynopsis.Text = "Book Synopsis";
            lblBookCardSynopsis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBookCardPrice
            // 
            lblBookCardPrice.AutoSize = true;
            lblBookCardPrice.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCardPrice.ForeColor = SystemColors.MenuHighlight;
            lblBookCardPrice.Location = new Point(191, 155);
            lblBookCardPrice.Margin = new Padding(2, 0, 2, 0);
            lblBookCardPrice.Name = "lblBookCardPrice";
            lblBookCardPrice.Size = new Size(45, 17);
            lblBookCardPrice.TabIndex = 6;
            lblBookCardPrice.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(287, 304);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(297, 23);
            textBox6.TabIndex = 5;
            // 
            // lblBookCardAuthor
            // 
            lblBookCardAuthor.AutoSize = true;
            lblBookCardAuthor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCardAuthor.ForeColor = SystemColors.MenuHighlight;
            lblBookCardAuthor.Location = new Point(191, 87);
            lblBookCardAuthor.Margin = new Padding(2, 0, 2, 0);
            lblBookCardAuthor.Name = "lblBookCardAuthor";
            lblBookCardAuthor.Size = new Size(56, 17);
            lblBookCardAuthor.TabIndex = 3;
            lblBookCardAuthor.Text = "Author";
            // 
            // lblBookCardTitle
            // 
            lblBookCardTitle.AutoSize = true;
            lblBookCardTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCardTitle.ForeColor = SystemColors.MenuHighlight;
            lblBookCardTitle.Location = new Point(191, 20);
            lblBookCardTitle.Margin = new Padding(2, 0, 2, 0);
            lblBookCardTitle.Name = "lblBookCardTitle";
            lblBookCardTitle.Size = new Size(40, 17);
            lblBookCardTitle.TabIndex = 2;
            lblBookCardTitle.Text = "Title";
            // 
            // picBookCardCover
            // 
            picBookCardCover.Location = new Point(2, 2);
            picBookCardCover.Margin = new Padding(2);
            picBookCardCover.Name = "picBookCardCover";
            picBookCardCover.Size = new Size(184, 202);
            picBookCardCover.TabIndex = 0;
            picBookCardCover.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = SystemColors.Control;
            lblAppName.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.WindowText;
            lblAppName.Location = new Point(386, 9);
            lblAppName.Margin = new Padding(2);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(493, 72);
            lblAppName.TabIndex = 14;
            lblAppName.Text = "The Bookstore Application";
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDebugText
            // 
            txtDebugText.Location = new Point(50, 501);
            txtDebugText.Margin = new Padding(2);
            txtDebugText.Multiline = true;
            txtDebugText.Name = "txtDebugText";
            txtDebugText.Size = new Size(208, 92);
            txtDebugText.TabIndex = 13;
            // 
            // pnlAccountPage
            // 
            pnlAccountPage.Controls.Add(btnLogOutAccount);
            pnlAccountPage.Controls.Add(btnChangePasswordAccount);
            pnlAccountPage.Controls.Add(btnEditInfoAccount);
            pnlAccountPage.Controls.Add(lbl2EmailAccount);
            pnlAccountPage.Controls.Add(lbl2PhoneAccount);
            pnlAccountPage.Controls.Add(lbl2AddressAccount);
            pnlAccountPage.Controls.Add(lbl2UsernameAccount);
            pnlAccountPage.Controls.Add(lbl2LastNameAccount);
            pnlAccountPage.Controls.Add(lbl2FirstNameAccount);
            pnlAccountPage.Controls.Add(lblUsernameAccount);
            pnlAccountPage.Controls.Add(lblAddressAccount);
            pnlAccountPage.Controls.Add(lblPhoneAccount);
            pnlAccountPage.Controls.Add(lblEmailAccount);
            pnlAccountPage.Controls.Add(lblLastNameAccount);
            pnlAccountPage.Controls.Add(lblFirstNameAccount);
            pnlAccountPage.Controls.Add(label1);
            pnlAccountPage.Location = new Point(47, 213);
            pnlAccountPage.Name = "pnlAccountPage";
            pnlAccountPage.Size = new Size(1222, 484);
            pnlAccountPage.TabIndex = 15;
            pnlAccountPage.Visible = false;
            // 
            // btnLogOutAccount
            // 
            btnLogOutAccount.Location = new Point(581, 317);
            btnLogOutAccount.Name = "btnLogOutAccount";
            btnLogOutAccount.Size = new Size(75, 23);
            btnLogOutAccount.TabIndex = 15;
            btnLogOutAccount.Text = "Log Out";
            btnLogOutAccount.UseVisualStyleBackColor = true;
            btnLogOutAccount.Click += btnLogOutAccount_Click;
            // 
            // btnChangePasswordAccount
            // 
            btnChangePasswordAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePasswordAccount.Location = new Point(736, 317);
            btnChangePasswordAccount.Name = "btnChangePasswordAccount";
            btnChangePasswordAccount.Size = new Size(121, 23);
            btnChangePasswordAccount.TabIndex = 14;
            btnChangePasswordAccount.Text = "Change Password";
            btnChangePasswordAccount.UseVisualStyleBackColor = true;
            btnChangePasswordAccount.Click += btnChangePasswordAccount_Click;
            // 
            // btnEditInfoAccount
            // 
            btnEditInfoAccount.Location = new Point(420, 317);
            btnEditInfoAccount.Name = "btnEditInfoAccount";
            btnEditInfoAccount.Size = new Size(75, 23);
            btnEditInfoAccount.TabIndex = 13;
            btnEditInfoAccount.Text = "Edit Info";
            btnEditInfoAccount.UseVisualStyleBackColor = true;
            // 
            // lbl2EmailAccount
            // 
            lbl2EmailAccount.AutoSize = true;
            lbl2EmailAccount.ForeColor = Color.Black;
            lbl2EmailAccount.Location = new Point(757, 275);
            lbl2EmailAccount.Name = "lbl2EmailAccount";
            lbl2EmailAccount.Size = new Size(36, 15);
            lbl2EmailAccount.TabIndex = 12;
            lbl2EmailAccount.Text = "Email";
            // 
            // lbl2PhoneAccount
            // 
            lbl2PhoneAccount.AutoSize = true;
            lbl2PhoneAccount.ForeColor = Color.Black;
            lbl2PhoneAccount.Location = new Point(754, 209);
            lbl2PhoneAccount.Name = "lbl2PhoneAccount";
            lbl2PhoneAccount.RightToLeft = RightToLeft.No;
            lbl2PhoneAccount.Size = new Size(83, 15);
            lbl2PhoneAccount.TabIndex = 11;
            lbl2PhoneAccount.Text = "Phonenumber";
            // 
            // lbl2AddressAccount
            // 
            lbl2AddressAccount.ForeColor = Color.Black;
            lbl2AddressAccount.Location = new Point(757, 136);
            lbl2AddressAccount.Name = "lbl2AddressAccount";
            lbl2AddressAccount.RightToLeft = RightToLeft.No;
            lbl2AddressAccount.Size = new Size(119, 50);
            lbl2AddressAccount.TabIndex = 10;
            lbl2AddressAccount.Text = "Address";
            // 
            // lbl2UsernameAccount
            // 
            lbl2UsernameAccount.AutoSize = true;
            lbl2UsernameAccount.ForeColor = Color.Black;
            lbl2UsernameAccount.Location = new Point(435, 274);
            lbl2UsernameAccount.Name = "lbl2UsernameAccount";
            lbl2UsernameAccount.Size = new Size(60, 15);
            lbl2UsernameAccount.TabIndex = 9;
            lbl2UsernameAccount.Text = "Username";
            // 
            // lbl2LastNameAccount
            // 
            lbl2LastNameAccount.AutoSize = true;
            lbl2LastNameAccount.ForeColor = Color.Black;
            lbl2LastNameAccount.Location = new Point(435, 207);
            lbl2LastNameAccount.Name = "lbl2LastNameAccount";
            lbl2LastNameAccount.Size = new Size(58, 15);
            lbl2LastNameAccount.TabIndex = 8;
            lbl2LastNameAccount.Text = "Lastname";
            // 
            // lbl2FirstNameAccount
            // 
            lbl2FirstNameAccount.AutoSize = true;
            lbl2FirstNameAccount.ForeColor = Color.Black;
            lbl2FirstNameAccount.Location = new Point(436, 137);
            lbl2FirstNameAccount.Name = "lbl2FirstNameAccount";
            lbl2FirstNameAccount.Size = new Size(59, 15);
            lbl2FirstNameAccount.TabIndex = 7;
            lbl2FirstNameAccount.Text = "Firstname";
            // 
            // lblUsernameAccount
            // 
            lblUsernameAccount.AutoSize = true;
            lblUsernameAccount.Location = new Point(406, 252);
            lblUsernameAccount.Name = "lblUsernameAccount";
            lblUsernameAccount.RightToLeft = RightToLeft.No;
            lblUsernameAccount.Size = new Size(63, 15);
            lblUsernameAccount.TabIndex = 6;
            lblUsernameAccount.Text = "Username:";
            // 
            // lblAddressAccount
            // 
            lblAddressAccount.AutoSize = true;
            lblAddressAccount.Location = new Point(736, 114);
            lblAddressAccount.Name = "lblAddressAccount";
            lblAddressAccount.RightToLeft = RightToLeft.No;
            lblAddressAccount.Size = new Size(52, 15);
            lblAddressAccount.TabIndex = 5;
            lblAddressAccount.Text = "Address:";
            // 
            // lblPhoneAccount
            // 
            lblPhoneAccount.AutoSize = true;
            lblPhoneAccount.Location = new Point(736, 186);
            lblPhoneAccount.Name = "lblPhoneAccount";
            lblPhoneAccount.RightToLeft = RightToLeft.No;
            lblPhoneAccount.Size = new Size(91, 15);
            lblPhoneAccount.TabIndex = 4;
            lblPhoneAccount.Text = "Phone Number:";
            // 
            // lblEmailAccount
            // 
            lblEmailAccount.AutoSize = true;
            lblEmailAccount.Location = new Point(736, 252);
            lblEmailAccount.Name = "lblEmailAccount";
            lblEmailAccount.RightToLeft = RightToLeft.No;
            lblEmailAccount.Size = new Size(39, 15);
            lblEmailAccount.TabIndex = 3;
            lblEmailAccount.Text = "Email:";
            // 
            // lblLastNameAccount
            // 
            lblLastNameAccount.AutoSize = true;
            lblLastNameAccount.Location = new Point(406, 184);
            lblLastNameAccount.Name = "lblLastNameAccount";
            lblLastNameAccount.RightToLeft = RightToLeft.No;
            lblLastNameAccount.Size = new Size(66, 15);
            lblLastNameAccount.TabIndex = 2;
            lblLastNameAccount.Text = "Last Name:";
            // 
            // lblFirstNameAccount
            // 
            lblFirstNameAccount.AutoSize = true;
            lblFirstNameAccount.Location = new Point(405, 114);
            lblFirstNameAccount.Name = "lblFirstNameAccount";
            lblFirstNameAccount.RightToLeft = RightToLeft.No;
            lblFirstNameAccount.Size = new Size(67, 15);
            lblFirstNameAccount.TabIndex = 1;
            lblFirstNameAccount.Text = "First Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Chocolate;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(1215, 48);
            label1.TabIndex = 0;
            label1.Text = "Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1284, 701);
            Controls.Add(pnlAccountPage);
            Controls.Add(lblAppName);
            Controls.Add(txtDebugText);
            Controls.Add(pnlBookStock);
            Controls.Add(panel3);
            Controls.Add(pnlBookSearch);
            Controls.Add(pnlNavBar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(2);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlNavBar.ResumeLayout(false);
            pnlBookSearch.ResumeLayout(false);
            pnlBookSearch.PerformLayout();
            pnlBookStock.ResumeLayout(false);
            pnlBookCard.ResumeLayout(false);
            pnlBookCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCardCover).EndInit();
            pnlAccountPage.ResumeLayout(false);
            pnlAccountPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAccountPage;
        private System.Windows.Forms.Button btnCartPage;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnLoginPage;
        private System.Windows.Forms.Panel pnlBookSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lbl2BookCardAuthor;
        private System.Windows.Forms.Label lbl2BookCardTitle;
        private System.Windows.Forms.TextBox txtBookSearchMaxPrice;
        private System.Windows.Forms.TextBox txtBookSearchTitle;
        private System.Windows.Forms.Label lblBookSearchAuthor;
        private System.Windows.Forms.TextBox txtBookSearchAuthor;
        private System.Windows.Forms.Panel pnlBookStock;
        private System.Windows.Forms.Panel pnlBookCard;
        private System.Windows.Forms.Label lblBookCardPrice;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblBookCardAuthor;
        private System.Windows.Forms.Label lblBookCardTitle;
        private System.Windows.Forms.PictureBox picBookCardCover;
        private System.Windows.Forms.TextBox bookCardSynopsis;
        private System.Windows.Forms.Label lblBookSearchMaxPrice;
        private System.Windows.Forms.Label lblBookSearchTitle;
        private Button btnBookSearchSearchButton;
        private Label lblBookCardSynopsis;
        private Label lblAppName;
        private Label label3;
        private Label lbl2BookCardSynopsis;
        private Label lbl2BookCardPrice;
        private Label lblBookCardDivider;
        private Button btnBookSearchResetButton;
        private Button btnBookCardDetailedViewButton;
        private Button btnBookCardAddtoCartButton;
        private TextBox txtDebugText;
        private Panel pnlAccountPage;
        private Label label1;
        private Label lblFirstNameAccount;
        private Label lblUsernameAccount;
        private Label lblAddressAccount;
        private Label lblPhoneAccount;
        private Label lblEmailAccount;
        private Label lblLastNameAccount;
        private Label lbl2LastNameAccount;
        private Label lbl2FirstNameAccount;
        private Button btnChangePasswordAccount;
        private Button btnEditInfoAccount;
        private Label lbl2EmailAccount;
        private Label lbl2PhoneAccount;
        private Label lbl2AddressAccount;
        private Label lbl2UsernameAccount;
        private Button btnLogOutAccount;
    }
}

