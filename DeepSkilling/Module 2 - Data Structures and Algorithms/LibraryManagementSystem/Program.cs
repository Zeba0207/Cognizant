using System;

namespace LibraryManagementSystem
{
    class Book
    {
        public int BookId;
        public string Title;
        public string Author;

        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
        }
    }

    class Program
    {
        static void LinearSearch(Book[] books, string title)
        {
            foreach (Book book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: {book.Title} by {book.Author}");
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        static int BinarySearch(Book[] books, string title)
        {
            int left = 0, right = books.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                int result = string.Compare(
                    books[mid].Title,
                    title,
                    StringComparison.OrdinalIgnoreCase);

                if (result == 0)
                    return mid;

                if (result < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            Book[] books =
            {
                new Book(101, "CSharp", "Author A"),
                new Book(102, "Data Structures", "Author B"),
                new Book(103, "Java", "Author C"),
                new Book(104, "Python", "Author D")
            };

            Console.WriteLine("Linear Search:");
            LinearSearch(books, "Python");

            Array.Sort(books, (a, b) =>
                string.Compare(a.Title, b.Title, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\nBinary Search:");

            int index = BinarySearch(books, "Python");

            if (index != -1)
                Console.WriteLine($"Found: {books[index].Title} by {books[index].Author}");
            else
                Console.WriteLine("Book not found.");
        }
    }
}