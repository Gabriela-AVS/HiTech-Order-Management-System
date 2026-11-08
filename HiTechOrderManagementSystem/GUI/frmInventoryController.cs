using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechOrderManagementSystem.DAL;
using HiTechOrderManagementSystem.LINQ_Data;


namespace HiTechOrderManagementSystem.GUI
{
    public partial class frmInventoryController : Form
    {
        public frmInventoryController()
        {
            InitializeComponent();
        }

        private void LoadAuthors()
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                var authors = db.Authors
                                .Select(a => new
                                {
                                    AuthorId = a.AuthorId,
                                    FullName = a.FirstName + " " + a.LastName
                                })
                                .ToList();

                cboAuthor.DataSource = authors;
                cboAuthor.DisplayMember = "FullName";
                cboAuthor.ValueMember = "AuthorId";
                cboAuthor.SelectedIndex = -1;
            }
        }


        private void frmInventoryController_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPublishers();
            LoadAuthors();
        }

        private void LoadCategories()
        {
            var categories = CategoryDB.GetAllCategories();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";
            cboCategory.SelectedIndex = -1;
        }

        private void LoadPublishers()
        {
            var publishers = PublisherDB.GetAllPublishers();
            cboPublisher.DataSource = publishers;
            cboPublisher.DisplayMember = "PublisherName";
            cboPublisher.ValueMember = "PublisherId";
            cboPublisher.SelectedIndex = -1;
        }


        private void btnListBooks_Click(object sender, EventArgs e)
        {

            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                var books = (from b in db.Books
                             join ab in db.AuthorsBooks on b.BookId equals ab.BookId
                             join a in db.Authors on ab.AuthorId equals a.AuthorId
                             select new
                             {
                                 b.BookId,
                                 b.ISBN,
                                 b.Booktitle,
                                 b.UnitPrice,
                                 b.YearPublished,
                                 b.QOH,
                                 b.CategoryId,
                                 b.PublisherId,
                                 Author = a.FirstName + " " + a.LastName
                             }).ToList();

                dgvBooks.AutoGenerateColumns = true;
                dgvBooks.DataSource = books;
            }
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
            string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
            string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
            string.IsNullOrWhiteSpace(txtYearPublished.Text) ||
            string.IsNullOrWhiteSpace(txtQOH.Text) ||
            cboCategory.SelectedIndex < 0 ||
            cboPublisher.SelectedIndex < 0 ||
            cboAuthor.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all fields, including selecting an Author.", "Validation Error");
                return;
            }

            
            string isbn = txtISBN.Text.Trim();
            string title = txtBookTitle.Text.Trim();
            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            int yearPublished = Convert.ToInt32(txtYearPublished.Text.Trim());
            int qoh = Convert.ToInt32(txtQOH.Text.Trim());
            int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
            int publisherId = Convert.ToInt32(cboPublisher.SelectedValue);
            int authorId = Convert.ToInt32(cboAuthor.SelectedValue);

            int newBookId = BookDB.AddBookReturnId(isbn, title, unitPrice, yearPublished, qoh, categoryId, publisherId);

            
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                AuthorsBook ab = new AuthorsBook
                {
                    BookId = newBookId,
                    AuthorId = authorId,
                    YearPublished = yearPublished
                };

                db.AuthorsBooks.InsertOnSubmit(ab);
                db.SubmitChanges();
            }

            MessageBox.Show("Book added successfully.", "Add Book");

          
            btnListBooks_Click(sender, e);

            
            ClearBookFields();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBookFields();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                MessageBox.Show("Please select a book to update.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtYearPublished.Text) ||
                string.IsNullOrWhiteSpace(txtQOH.Text) ||
                cboCategory.SelectedIndex < 0 ||
                cboPublisher.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error");
                return;
            }

            int bookId = Convert.ToInt32(txtBookId.Text.Trim());
            string isbn = txtISBN.Text.Trim();
            string title = txtBookTitle.Text.Trim();
            decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            int yearPublished = Convert.ToInt32(txtYearPublished.Text.Trim());
            int qoh = Convert.ToInt32(txtQOH.Text.Trim());
            int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
            int publisherId = Convert.ToInt32(cboPublisher.SelectedValue);

            BookDB.UpdateBook(bookId, isbn, title, unitPrice, yearPublished, qoh, categoryId, publisherId);

            MessageBox.Show("Book updated successfully.", "Update Book");

            ClearBookFields();

            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = BookDB.GetAllBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                MessageBox.Show("Please select a book to delete.", "Input Error");
                return;
            }

            int bookId = Convert.ToInt32(txtBookId.Text.Trim());

            DialogResult answer = MessageBox.Show("Are you sure you want to delete this book?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                BookDB.DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully.", "Delete Book");

                ClearBookFields();

                dgvBooks.AutoGenerateColumns = false;
                dgvBooks.DataSource = BookDB.GetAllBooks();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.ShowDialog();
            this.Close();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Book selectedBook = dgvBooks.Rows[e.RowIndex].DataBoundItem as Book;
            if (selectedBook == null) return;

            txtBookId.Text = selectedBook.BookId.ToString();
            txtISBN.Text = selectedBook.ISBN;
            txtBookTitle.Text = selectedBook.Booktitle;
            txtUnitPrice.Text = selectedBook.UnitPrice.ToString();
            txtYearPublished.Text = selectedBook.YearPublished.ToString();
            txtQOH.Text = selectedBook.QOH.ToString();
            cboCategory.SelectedValue = selectedBook.CategoryId;
            cboPublisher.SelectedValue = selectedBook.PublisherId;
        }

        private void ClearBookFields()
        {
            txtBookId.Text = "";
            txtISBN.Text = "";
            txtBookTitle.Text = "";
            txtUnitPrice.Text = "";
            txtYearPublished.Text = "";
            txtQOH.Text = "";
            cboCategory.SelectedIndex = -1;
            cboPublisher.SelectedIndex = -1;
            cboAuthor.SelectedIndex = -1;

            txtISBN.Focus();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string bookIdText = txtBookId.Text.Trim();
            string isbnText = txtISBN.Text.Trim();
            int selectedAuthorId = cboAuthor.SelectedIndex >= 0
                                   ? (int)cboAuthor.SelectedValue
                                   : -1;

            Book foundBook = null;

            
            if (!string.IsNullOrWhiteSpace(bookIdText))
            {
                int bookId;
                if (!int.TryParse(bookIdText, out bookId))
                {
                    MessageBox.Show("Book Id must be a number.", "Input Error");
                    txtBookId.Focus();
                    return;
                }

                foundBook = BookDB.GetBookById(bookId);

                if (foundBook != null)
                {
                    DisplayBook(foundBook);
                    return;
                }
            }

           
            if (!string.IsNullOrWhiteSpace(isbnText))
            {
                foundBook = BookDB.GetBookByISBN(isbnText);

                if (foundBook != null)
                {
                    DisplayBook(foundBook);
                    return;
                }
            }

           
            if (selectedAuthorId != -1)
            {
                using (HiTechDBDataContext db = new HiTechDBDataContext())
                {
                    var books = (from b in db.Books
                                 join ab in db.AuthorsBooks on b.BookId equals ab.BookId
                                 where ab.AuthorId == selectedAuthorId
                                 join a in db.Authors on ab.AuthorId equals a.AuthorId
                                 select new
                                 {
                                     b.BookId,
                                     b.ISBN,
                                     b.Booktitle,
                                     b.UnitPrice,
                                     b.YearPublished,
                                     b.QOH,
                                     b.CategoryId,
                                     b.PublisherId,
                                     Author = a.FirstName + " " + a.LastName
                                 }).ToList();

                    if (books.Count > 0)
                    {
                        dgvBooks.AutoGenerateColumns = true;
                        dgvBooks.DataSource = books;
                        return;
                    }
                }
            }

            
            MessageBox.Show("Please enter bookId, ISBN or select an Author name to search", "Search Result");
            ClearBookFields();
        }

        private void DisplayBook(Book foundBook)
        {
            txtBookId.Text = foundBook.BookId.ToString();
            txtISBN.Text = foundBook.ISBN;
            txtBookTitle.Text = foundBook.Booktitle;
            txtUnitPrice.Text = foundBook.UnitPrice.ToString();
            txtYearPublished.Text = foundBook.YearPublished.ToString();
            txtQOH.Text = foundBook.QOH.ToString();
            cboCategory.SelectedValue = foundBook.CategoryId;
            cboPublisher.SelectedValue = foundBook.PublisherId;
        }

        
    }
}
