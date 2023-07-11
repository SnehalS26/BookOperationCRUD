using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOperationCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookCRUD bookCRUD = new BookCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Book Details:");
                Console.WriteLine("2. Update Book Details");
                Console.WriteLine("3. Delete Book Details");
                Console.WriteLine("4. Display All Book Details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Book book = new Book();
                        Console.WriteLine("Enter Book Id:");
                        book.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Name:");
                        book.Book_name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Book Author Name:");
                        book.Author_name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Book Price:");
                        book.Book_price = Convert.ToInt32(Console.ReadLine());
                        bookCRUD.AddBook(book);
                        break;
                    case 2:
                        Book book1 = new Book();
                        Console.WriteLine("Enter modify Book Id:");
                        book1.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Name:");
                        book1.Book_name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Book Author Name:");
                        book1.Author_name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter Book Price:");
                        book1.Book_price = Convert.ToInt32(Console.ReadLine());
                        bookCRUD.UpdateBook(book1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Delete Book Id:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        bookCRUD.DeleteBook(id);
                        break;
                    case 4:
                        List<Book> list = bookCRUD.GetBooks();
                        foreach(Book b in list)
                        {
                            Console.WriteLine($"{b.Id} --> {b.Book_name} --> {b.Author_name} --> {b.Book_price}");
                        }
                        break;
                }
                Console.WriteLine("Enter 1 Option");
                option= Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}
