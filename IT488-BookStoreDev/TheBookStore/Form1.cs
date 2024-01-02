using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace bookstoreapp
{
    public partial class Form1 : Form
    {
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
            txtDebugText.Text = "Startup...";

            try
            {
                var datasource = @"(local)\SQLExpress";
                var database = "Bookstoredb";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                txtDebugText.Text = "Connection Successful";
                conn.Close();
            }
            catch (Exception ex)
            {
                txtDebugText.Text = "Error, " + ex;
            }
        }

        public void CreateBookPanels(List<Book> books)
        {
            int panelHeight = pnlBookCard.Height;
            int spacing = 5;

            for (int i = 0; i < books.Count; i++)
            {
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
    }
}
