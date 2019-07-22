using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirdBookShelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ISBN:");
            string isbn = Console.ReadLine();

            Console.WriteLine("Enter Book Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Book Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Book Author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price:");
            int price = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(isbn, name, title, author, quantity, price);

            book.DisplayBill();
            Console.ReadLine();
        }
    }

    public class Book
    {
        public string isbn;
        public string bookName;
        public string bookTitle;
        public string bookAuthor;
        public int quantity;
        public int bookPrice;

        public Book(string _isbn, string _bookName, string _bookTitle, string _bookAuthor,
                    int _quantity, int _bookPrice)
        {
            this.isbn = _isbn;
            this.bookName = _bookName;
            this.bookTitle = _bookTitle;
            this.bookAuthor = _bookAuthor;
            this.quantity = _quantity;
            this.bookPrice = _bookPrice;
        }

        public void DisplayBill()
        {
            Console.WriteLine("****Bill Generated****");
            Console.WriteLine("ISBN : {0}", isbn);
            Console.WriteLine("Name : {0}", bookName);
            Console.WriteLine("Title : {0}", bookTitle);
            Console.WriteLine("Author : {0}", isbn);
            Console.WriteLine("Quantity : {0}", quantity);
            Console.WriteLine("Price : {0}", bookPrice);
            Console.WriteLine("Total Price : {0}", (quantity * bookPrice));
        }
    }
}
