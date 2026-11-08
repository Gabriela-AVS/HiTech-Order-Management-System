using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechOrderManagementSystem.LINQ_Data; 

namespace HiTechOrderManagementSystem.DAL
{
    public static class BookDB
    {
        
        
        public static List<Book> GetAllBooks()
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                return db.Books.ToList();
            }
        }

     
        

       
        public static void AddBook(string isbn, string title, decimal unitPrice,
                                   int yearPublished, int qoh,
                                   int categoryId, int publisherId)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                Book bk = new Book
                {
                    ISBN = isbn,
                    Booktitle = title,
                    UnitPrice = unitPrice,
                    YearPublished = yearPublished,
                    QOH = qoh,
                    CategoryId = categoryId,
                    PublisherId = publisherId
                };

                db.Books.InsertOnSubmit(bk);
                db.SubmitChanges();
            }
        }

       
        public static Book GetBookById(int bookId)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                return db.Books.FirstOrDefault(b => b.BookId == bookId);
            }
        }

        public static int AddBookReturnId(string isbn, string title, decimal unitPrice,
                                   int yearPublished, int qoh,
                                   int categoryId, int publisherId)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                Book bk = new Book
                {
                    ISBN = isbn,
                    Booktitle = title,
                    UnitPrice = unitPrice,
                    YearPublished = yearPublished,
                    QOH = qoh,
                    CategoryId = categoryId,
                    PublisherId = publisherId
                };

                db.Books.InsertOnSubmit(bk);
                db.SubmitChanges();

                return bk.BookId;  
            }
        }
        public static Book GetBookByISBN(string isbn)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                return db.Books.FirstOrDefault(b => b.ISBN == isbn);
            }
        }

        public static void UpdateBook(int bookId, string isbn, string title, decimal unitPrice,
                                      int yearPublished, int qoh,
                                      int categoryId, int publisherId)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                Book bk = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (bk == null) return;

                bk.ISBN = isbn;
                bk.Booktitle = title;
                bk.UnitPrice = unitPrice;
                bk.YearPublished = yearPublished;
                bk.QOH = qoh;
                bk.CategoryId = categoryId;
                bk.PublisherId = publisherId;

                db.SubmitChanges();
            }
        }

        
        public static void DeleteBook(int bookId)
        {
            using (HiTechDBDataContext db = new HiTechDBDataContext())
            {
                Book bk = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (bk == null) return;

                db.Books.DeleteOnSubmit(bk);
                db.SubmitChanges();
            }
        }
    }
}   


