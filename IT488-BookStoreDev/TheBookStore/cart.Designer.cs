
namespace TheBookStore
{
    partial class cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart));
            bookCard = new Panel();
            bookCardSynopsis = new TextBox();
            textBox4 = new TextBox();
            richTextBox3 = new RichTextBox();
            bookCardPriceLabel = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            bookCardAuthorLabel = new Label();
            bookCardTitleLabel = new Label();
            bookCardAuthor = new TextBox();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pricePlaceholderLabel = new Label();
            label2 = new Label();
            checkOutButton = new Button();
            bookCard.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // bookCard
            // 
            bookCard.BorderStyle = BorderStyle.FixedSingle;
            bookCard.Controls.Add(bookCardSynopsis);
            bookCard.Controls.Add(textBox4);
            bookCard.Controls.Add(richTextBox3);
            bookCard.Controls.Add(bookCardPriceLabel);
            bookCard.Controls.Add(textBox6);
            bookCard.Controls.Add(textBox5);
            bookCard.Controls.Add(bookCardAuthorLabel);
            bookCard.Controls.Add(bookCardTitleLabel);
            bookCard.Controls.Add(bookCardAuthor);
            bookCard.Location = new Point(410, 322);
            bookCard.Margin = new Padding(2, 2, 2, 2);
            bookCard.Name = "bookCard";
            bookCard.Size = new Size(983, 225);
            bookCard.TabIndex = 10;
            bookCard.Visible = false;
            // 
            // bookCardSynopsis
            // 
            bookCardSynopsis.BackColor = Color.Coral;
            bookCardSynopsis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardSynopsis.Location = new Point(204, 34);
            bookCardSynopsis.Margin = new Padding(2, 2, 2, 2);
            bookCardSynopsis.Name = "bookCardSynopsis";
            bookCardSynopsis.Size = new Size(770, 26);
            bookCardSynopsis.TabIndex = 11;
            bookCardSynopsis.Text = "Book Synopsis";
            bookCardSynopsis.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(-1, 43);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 23);
            textBox4.TabIndex = 10;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(204, 58);
            richTextBox3.Margin = new Padding(2, 2, 2, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(770, 164);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // bookCardPriceLabel
            // 
            bookCardPriceLabel.AutoSize = true;
            bookCardPriceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardPriceLabel.ForeColor = SystemColors.InfoText;
            bookCardPriceLabel.Location = new Point(6, 175);
            bookCardPriceLabel.Margin = new Padding(2, 0, 2, 0);
            bookCardPriceLabel.Name = "bookCardPriceLabel";
            bookCardPriceLabel.Size = new Size(45, 17);
            bookCardPriceLabel.TabIndex = 6;
            bookCardPriceLabel.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(287, 304);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(297, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(-1, 195);
            textBox5.Margin = new Padding(2, 2, 2, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 23);
            textBox5.TabIndex = 4;
            // 
            // bookCardAuthorLabel
            // 
            bookCardAuthorLabel.AutoSize = true;
            bookCardAuthorLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardAuthorLabel.ForeColor = SystemColors.InfoText;
            bookCardAuthorLabel.Location = new Point(-1, 99);
            bookCardAuthorLabel.Margin = new Padding(2, 0, 2, 0);
            bookCardAuthorLabel.Name = "bookCardAuthorLabel";
            bookCardAuthorLabel.Size = new Size(56, 17);
            bookCardAuthorLabel.TabIndex = 3;
            bookCardAuthorLabel.Text = "Author";
            // 
            // bookCardTitleLabel
            // 
            bookCardTitleLabel.AutoSize = true;
            bookCardTitleLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardTitleLabel.ForeColor = SystemColors.InfoText;
            bookCardTitleLabel.Location = new Point(-1, 16);
            bookCardTitleLabel.Margin = new Padding(2, 0, 2, 0);
            bookCardTitleLabel.Name = "bookCardTitleLabel";
            bookCardTitleLabel.Size = new Size(40, 17);
            bookCardTitleLabel.TabIndex = 2;
            bookCardTitleLabel.Text = "Title";
            // 
            // bookCardAuthor
            // 
            bookCardAuthor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookCardAuthor.ForeColor = SystemColors.WindowText;
            bookCardAuthor.Location = new Point(-1, 121);
            bookCardAuthor.Margin = new Padding(2, 2, 2, 2);
            bookCardAuthor.Name = "bookCardAuthor";
            bookCardAuthor.Size = new Size(175, 23);
            bookCardAuthor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(82, 118);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 91);
            panel1.TabIndex = 12;
            // 
            // button7
            // 
            button7.BackColor = Color.Chocolate;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(50, 13);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(157, 66);
            button7.TabIndex = 7;
            button7.Text = "Home";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Chocolate;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(551, 13);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(157, 66);
            button6.TabIndex = 6;
            button6.Text = "Account";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(1033, 13);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(157, 66);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(468, 30);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(493, 72);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Authors4Fans";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 221);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 13;
            label1.Text = "Your Shopping Cart";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(669, 252);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pricePlaceholderLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkOutButton);
            panel2.Location = new Point(82, 322);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 224);
            panel2.TabIndex = 15;
            // 
            // pricePlaceholderLabel
            // 
            pricePlaceholderLabel.AutoSize = true;
            pricePlaceholderLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePlaceholderLabel.Location = new Point(54, 59);
            pricePlaceholderLabel.Margin = new Padding(2, 0, 2, 0);
            pricePlaceholderLabel.Name = "pricePlaceholderLabel";
            pricePlaceholderLabel.Size = new Size(84, 51);
            pricePlaceholderLabel.TabIndex = 2;
            pricePlaceholderLabel.Text = "$....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 16);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 37);
            label2.TabIndex = 1;
            label2.Text = "Total Price";
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.LimeGreen;
            checkOutButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutButton.Location = new Point(54, 169);
            checkOutButton.Margin = new Padding(2, 2, 2, 2);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(180, 44);
            checkOutButton.TabIndex = 0;
            checkOutButton.Text = "Check Out";
            checkOutButton.UseVisualStyleBackColor = false;
            // 
            // cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 658);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bookCard);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "cart";
            Text = "Form2";
            bookCard.ResumeLayout(false);
            bookCard.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel bookCard;
        private TextBox bookCardSynopsis;
        private TextBox textBox4;
        private RichTextBox richTextBox3;
        private Label bookCardPriceLabel;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label bookCardAuthorLabel;
        private Label bookCardTitleLabel;
        private TextBox bookCardAuthor;
        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button checkOutButton;
        private Label label2;
        private Label pricePlaceholderLabel;
    }
}