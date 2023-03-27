using System;
using System.Collections.Generic;
using System.Text;

namespace Private_library
{
    internal class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length < 2) throw new ArgumentException("Name is not allowed to be less than 2 character long.");
                name = value; 
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 4) throw new ArgumentException("There is a minimum age of 4 required to have a membership.");
                age = value; 
            }
        }
        public List<Book> books;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            books = new List<Book>();
        }
        public void BorrowBook(Book book) // use for lending 1 or more books
        {
            books.Add(book);
            book.IsAvailable = false;
        }
        public void ReturnBook(Book book) // use for returning 1 or more books
        {
            books.Remove(book);
            book.IsAvailable = true;
        }
        public void ReturnAllBooks()
        {
            foreach (Book book in books)
            {
                book.IsAvailable = true;
            }
            books.Clear();
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\n";
        }
    }
}
