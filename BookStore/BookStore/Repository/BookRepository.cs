using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Preetam", Description = "This is a MVC Book" },
                new BookModel() { Id = 2, Title = "C#", Author = "Preetam", Description = "This is a C# Book" },
                new BookModel() { Id = 3, Title = "Java", Author = "Basudev", Description = "This is a Java Book" },
                new BookModel() { Id = 4, Title = "Php", Author = "Rahul", Description = "This is a Php Book" },
                new BookModel() { Id = 5, Title = "Python", Author = "Tanmaya", Description = "This is a Python Book" }
            };
        }
    }
}
