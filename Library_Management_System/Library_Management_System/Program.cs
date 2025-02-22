

using System;

namespace Library_Management_System
{
    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(int bookId, string title, string author)
        {
            BookID = bookId;
            Title = title;
            Author = author;
            
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Book ID: {BookID}");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Available Or Not: {(IsAvailable ? "Yes" : "No")}");
            Console.WriteLine();
        }
    }

    


    class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public int BorrowedBookID { get; set; }

        public User(int userID, string name )
        {
            UserID = userID;
            Name = name;
            BorrowedBookID = -1;
        }

        public void DisplayUserDetails()
        {
            Console.WriteLine($"UserID: {UserID}");
            Console.WriteLine($"User Name: {Name}");
            Console.WriteLine($"Borrowed Book ID: {(BorrowedBookID == -1 ? "None" : BorrowedBookID.ToString())}");
            Console.WriteLine();
        }
    }

    class Library
    {
        List<Book> books { get; set; }
        List<User> users { get; set; }


        public Library()
        {
            books = new List<Book>();
            users = new List<User>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }
        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine($"User {user.Name} Added the Library.");
        }


        public void BorrowBook(int userID, int bookID)
        {
            Book book = books.Find(b => b.BookID == bookID);
            User user = users.Find(u => u.UserID == userID);

            Console.WriteLine(user.UserID);

            if(user != null && book != null && book.IsAvailable)
            {
                user.BorrowedBookID = bookID;
                book.IsAvailable = false;
                Console.WriteLine($"{user.Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine("Book is Not Available or User not found.");
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book(101, "C# Programming", "John Doe");

            User user1 = new User(11,"Nilesh");
            Library barrow = new Library();


            book.DisplayBookDetails();
            user1.DisplayUserDetails();

            barrow.BorrowBook(11, 101);
            Console.ReadLine();
        }
    }
}