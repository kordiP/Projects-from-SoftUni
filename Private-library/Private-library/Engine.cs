using System;
using System.Collections.Generic;
using System.Text;

namespace Private_library
{
    internal class Engine
    {
        List<Person> people = new List<Person>();
        List<Book> books = new List<Book>();
        public string CreatePersonCommand(List<string> input) // name, age
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            if (people.Contains(person)) return "Reader already exists.";
            people.Add(person);
            return $"Successfully created membership for {name}.";
        }
        public string AddBookCommand(List<string> input) // name, author
        {
            string name = input[0];
            string author = input[1];
            Book book = new Book(name, author);
            if (books.Contains(book)) return "Book already added.";
            books.Add(book);
            return $"Successfully added book {name} to library.";
        }
        public string LendBookCommand(List<string> input) // bookname, personname
        {
            string bookName = input[0];
            string personName = input[1];
            Book checkerBook = books.Find(x => x.Name == bookName);
            Person checkerPerson = people.Find(x => x.Name == personName);
            if (checkerBook == null) return "Book not found in library.";
            else if (checkerPerson == null) return "Reader not found in system.";
            else if (!checkerBook.IsAvailable) return "Book is already borrowed.";
            people[people.FindIndex(x => x.Name == personName)].BorrowBook(checkerBook);
            return $"{personName} successfully borrowed {bookName}";
        }
        public string ReturnBookCommand(List<string> input) // bookname, personname
        {
            string bookName = input[0];
            string personName = input[1];
            Book checkerBook = books.Find(x => x.Name == bookName);
            Person checkerPerson = people.Find(x => x.Name == personName);
            if (checkerBook == null) return "Book not found in system.";
            else if (checkerPerson == null) return "Reader not found in system.";
            else if (checkerBook.IsAvailable) return "This book is not borrowed by anyone.";
            else if (!checkerPerson.books.Contains(checkerBook)) return $"Book can not be returned, as it was not borrowed by {personName}.";
            people[people.FindIndex(x => x.Name == personName)].ReturnBook(checkerBook);
            return $"{personName} successfully returned {bookName}";
        }
        public string ReturnAllBooksCommand(List<string> input) // personname
        {
            string personName = input[0];
            if (people.Find(x => x.Name == personName) == null) return "Reader not found in system.";
            people[people.FindIndex(x => x.Name == personName)].ReturnAllBooks();
            return $"{personName} successfully returned all of his borrowed books.";
        }
        public string ShowAllReaders()
        {
            string readers = $"Readers: {people.Count}\n"; 
            foreach (var item in people)
            {
                readers += item.ToString();
            }
            return readers;
        }
        public string ShowAllLibraryBooks()
        {
            string booksReturn = $"Books: {books.Count}\n";
            foreach (var item in books)
            {
                booksReturn += item.ToString();
            }
            return booksReturn;
        }
        public string ShowAllBooksForPerson(List<string> input) // personname
        {
            string personName = input[0];
            int personIndex = people.FindIndex(x => x.Name == personName);
            List<Book> personBooks = people[personIndex].books;

            string booksReturn = $"Books borrowed by {personName}: {personBooks.Count}\n";
            foreach (var item in personBooks)
            {
                booksReturn += item;
            }
            return booksReturn;
        }
        
    }
}
