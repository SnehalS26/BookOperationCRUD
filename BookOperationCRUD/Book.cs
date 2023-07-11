using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOperationCRUD
{
    public class Book
    {
        public int Id { get; set; }
        public string Book_name { get; set; }
        public string Author_name { get; set; }

        public int Book_price { get; set; }
    }
    public class BookCRUD
    {
        private List<Book> books;
        public BookCRUD()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void UpdateBook(Book book)
        {
            foreach(Book book1 in books)
            {
                if(book1.Id == book.Id)
                {
                    book1.Book_name = book.Book_name;
                    book1.Author_name = book.Author_name;
                    book1.Book_price = book.Book_price;
                    break;
                }
            }
        }
        public void DeleteBook(int id)
        {
            foreach(Book book1 in books)
            {
                if( book1.Id == id)
                {
                    books.Remove(book1);
                    break;
                }
            }
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }
}
