using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book() { }

        public book(int Id, string Title, string Author)
        {
            _Id = Id;
            _Title = Title;
            _Author = Author;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.Id = 1;
            book1.Title = "Book 1";
            book1.Author = "Author 1";

            book book2 = new book();
            Console.WriteLine("Please enter the book ID: ");
            book2.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            book2.Title = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            book2.Author = Console.ReadLine();

            book book3 = new book(3, "Book 3", "Author 3");

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        static void displayBooks(book book)
        {
            Console.WriteLine("Here's the book information");
            Console.WriteLine($"Book ID: {book.Id}");
            Console.WriteLine($"Book Title: {book.Title}");
            Console.WriteLine($"Book Author: {book.Author}");
        }
    }
}
