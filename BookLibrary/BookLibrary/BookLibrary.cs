using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class BookLibrary
    {
        private string name;

        private List<Book> books;

        public BookLibrary(string name)

        {
            this.name = name;
            books = new List<Book>();
        }

        public string Name

        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public List<Book> Books
        {
            get { return books; }
            set
            {
                books = value;
            }
        }

        public void AddBook(string title, double rating)
        {
            books.Add(new Book(title, rating));
        }

        public double AverageRating()
        {
            double sum = 0;
            for (int i = 0; i < Books.Count; i++)
            {
                sum += Books.ElementAt(i).Rating;
            }
            return sum/Books.Count;
        }

        public List<string> GetBooksByRating(double rating) // >= rating
        {
            List<string> Titles = new List<string>();
            for (int i = 0; i < Books.Count; i++)
                if (Books.ElementAt(i).Rating > rating)
                    Titles.Add(Books.ElementAt(i).Title);
            return Titles;
        }

        public List<Book> SortByTitle()
        {
            List<Book> redo = new List<Book>();
            redo = Books.OrderBy(x => x.Title).ToList();
            Books = redo;
            return Books;
        }

        public List<Book> SortByRating()
        {
            List<Book> redo = new List<Book>();
            redo = Books.OrderByDescending(x => x.Rating).ToList();
            Books = redo;
            return Books;
        }

        public string[] ProvideInformationAboutAllBooks()
        {
            string[] toReturn = new string[Books.Count];
            for (int i = 0; i < Books.Count; i++)
            {
                toReturn[i] = $"Book {Books[i].Title} is with {Books[i].Rating} rating."; 
            }
            return toReturn;
        }

        public bool CheckBookIsInBookLibrary(string title)
        {
            for (int i = 0; i < Books.Count; i++)
                if (Books.ElementAt(i).Title.Equals(title))
                    return true;
            return false;
        }
    }
}
