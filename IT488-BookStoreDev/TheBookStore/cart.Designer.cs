
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
            checkOutButton = new Button();
            label2 = new Label();
            pricePlaceholderLabel = new Label();
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
            bookCard.Location = new Point(585, 537);
            bookCard.Margin = new Padding(3, 4, 3, 4);
            bookCard.Name = "bookCard";
            bookCard.Size = new Size(1403, 373);
            bookCard.TabIndex = 10;
            bookCard.Visible = false;
            // 
            // bookCardSynopsis
            // 
            bookCardSynopsis.BackColor = Color.Coral;
            bookCardSynopsis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardSynopsis.Location = new Point(291, 56);
            bookCardSynopsis.Margin = new Padding(3, 4, 3, 4);
            bookCardSynopsis.Name = "bookCardSynopsis";
            bookCardSynopsis.Size = new Size(1098, 35);
            bookCardSynopsis.TabIndex = 11;
            bookCardSynopsis.Text = "Book Synopsis";
            bookCardSynopsis.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(-1, 72);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 31);
            textBox4.TabIndex = 10;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(291, 97);
            richTextBox3.Margin = new Padding(3, 4, 3, 4);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(1098, 270);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // bookCardPriceLabel
            // 
            bookCardPriceLabel.AutoSize = true;
            bookCardPriceLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardPriceLabel.ForeColor = SystemColors.InfoText;
            bookCardPriceLabel.Location = new Point(9, 291);
            bookCardPriceLabel.Name = "bookCardPriceLabel";
            bookCardPriceLabel.Size = new Size(61, 25);
            bookCardPriceLabel.TabIndex = 6;
            bookCardPriceLabel.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(410, 506);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(422, 30);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(-1, 325);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 30);
            textBox5.TabIndex = 4;
            // 
            // bookCardAuthorLabel
            // 
            bookCardAuthorLabel.AutoSize = true;
            bookCardAuthorLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardAuthorLabel.ForeColor = SystemColors.InfoText;
            bookCardAuthorLabel.Location = new Point(-1, 165);
            bookCardAuthorLabel.Name = "bookCardAuthorLabel";
            bookCardAuthorLabel.Size = new Size(76, 25);
            bookCardAuthorLabel.TabIndex = 3;
            bookCardAuthorLabel.Text = "Author";
            // 
            // bookCardTitleLabel
            // 
            bookCardTitleLabel.AutoSize = true;
            bookCardTitleLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookCardTitleLabel.ForeColor = SystemColors.InfoText;
            bookCardTitleLabel.Location = new Point(-1, 27);
            bookCardTitleLabel.Name = "bookCardTitleLabel";
            bookCardTitleLabel.Size = new Size(54, 25);
            bookCardTitleLabel.TabIndex = 2;
            bookCardTitleLabel.Text = "Title";
            // 
            // bookCardAuthor
            // 
            bookCardAuthor.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookCardAuthor.ForeColor = SystemColors.WindowText;
            bookCardAuthor.Location = new Point(-1, 202);
            bookCardAuthor.Margin = new Padding(3, 4, 3, 4);
            bookCardAuthor.Name = "bookCardAuthor";
            bookCardAuthor.Size = new Size(248, 30);
            bookCardAuthor.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(117, 197);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1871, 151);
            panel1.TabIndex = 12;
            // 
            // button7
            // 
            button7.BackColor = Color.Chocolate;
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(72, 21);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(224, 110);
            button7.TabIndex = 7;
            button7.Text = "Home";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Chocolate;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(787, 21);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(224, 110);
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
            button1.Location = new Point(1476, 21);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(224, 110);
            button1.TabIndex = 1;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Microsoft Sans Serif", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(668, 50);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.No;
            richTextBox1.Size = new Size(704, 120);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "The Bookstore Application";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(828, 369);
            label1.Name = "label1";
            label1.Size = new Size(349, 48);
            label1.TabIndex = 13;
            label1.Text = "Your Shopping Cart";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(956, 420);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pricePlaceholderLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkOutButton);
            panel2.Location = new Point(117, 537);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 373);
            panel2.TabIndex = 15;
            // 
            // checkOutButton
            // 
            checkOutButton.BackColor = Color.LimeGreen;
            checkOutButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkOutButton.Location = new Point(77, 282);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(257, 74);
            checkOutButton.TabIndex = 0;
            checkOutButton.Text = "Check Out";
            checkOutButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 27);
            label2.Name = "label2";
            label2.Size = new Size(219, 54);
            label2.TabIndex = 1;
            label2.Text = "Total Price";
            // 
            // pricePlaceholderLabel
            // 
            pricePlaceholderLabel.AutoSize = true;
            pricePlaceholderLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pricePlaceholderLabel.Location = new Point(77, 98);
            pricePlaceholderLabel.Name = "pricePlaceholderLabel";
            pricePlaceholderLabel.Size = new Size(124, 74);
            pricePlaceholderLabel.TabIndex = 2;
            pricePlaceholderLabel.Text = "$....";
            // 
            // cart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2103, 1096);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bookCard);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
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