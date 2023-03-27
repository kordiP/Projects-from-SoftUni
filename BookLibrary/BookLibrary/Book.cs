using System;

namespace BookLibrary
{
    internal class Book
    {
        private string title;

        private double rating;

        public Book(string title, double rating)
        {
            this.title = title;
            this.rating = rating;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public override string ToString()
        {
            return $"Book {title} is with {Math.Round(rating, 1)} rating.";
        }
    }
}
