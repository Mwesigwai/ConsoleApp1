using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Book
    {
        public string? author;
        public string? title;
        public Book(string Author, string Title) 
        {
            this.title = Title;
            this.author = Author;
        }

        public override string ToString()
        {
            return $"{title} by {author}";
        }
    }

    public class Library
    {
        int i = 0;
        public Book[] catalog = new Book[10];
        public void AddBook(Book book)
        {
            if(i < catalog.Length)
            {
                catalog[i] = book;
                i ++;
            }
            else
            {
                Console.WriteLine("The catalog is full");
            }
        }

        public void ShowBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var item in catalog)
            {
                Console.WriteLine(item);
            }
        }
    }
}
