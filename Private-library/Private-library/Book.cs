using System;
using System.Collections.Generic;
using System.Text;

namespace Private_library
{
    internal class Book
    {
		// books need to have name, author and __
		private bool isAvailable;

		public bool IsAvailable
        {
			get { return isAvailable; }
			set { isAvailable = value; }
		}
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2) throw new ArgumentException("Name of book is not allowed to be less than 2 character long.");
                name = value;
            }
        }
        private string author;

        public string Author
        {
            get { return author; }
            set
            {
                if (value.Length < 2) throw new ArgumentException("Name of author is not allowed to be less than 2 character long.");
                name = value;
            }
        }
        public Book(string name, string author)
        {
            IsAvailable = true;
            Name = name;
            Author = author;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author}\nBorrowed: {IsAvailable}\n";
        }
    }
}
