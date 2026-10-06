using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public int ISBN;

        //Paramaterised constructor
        public Book(string booktitle, string bookauthor, int bookISBN)
        {
            Title = booktitle;
            Author = bookauthor;
            ISBN = bookISBN;
        }

        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"ISBN: {book.ISBN}");
        }
    }
}