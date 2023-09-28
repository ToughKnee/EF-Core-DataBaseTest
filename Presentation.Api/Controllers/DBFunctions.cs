using CleanArchitectureWorkshop.Domain.Core;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureWorkshop.Presentation.Api.Controllers;
public static class Functions
{

    public static List<Author> createFakeData()
    {
        var authors = new List<Author>
        {
            new Author
            {
                Name = "AAA", Books = new List<Book>
                {
                    new Book {Title = "CONFLICT 1", PublicationYear = 1831},
                    new Book {Title = "CONFLICT 1", PublicationYear = 213},
                    new Book {Title = "CONFLICT 1", PublicationYear = 13}
                }
            },
            new Author
            {
                Name = "CCC", Books = new List<Book>
                {
                    new Book {Title = "C", PublicationYear = 981},
                    new Book {Title = "C++", PublicationYear = 2000},
                    new Book {Title = "C#", PublicationYear = 3200}
                }
            }
        };
        return authors;
    }

    public static string BooksToString(ICollection<Book> books)
    {
        string returnValue = "";
        foreach(Book book in books)
        {
            returnValue += book.ToString();
            returnValue += " --- ";
        }
        return returnValue;
    }

    public static BooksContext createDatabase()
    {
        BooksContext db = new BooksContext();
        db.Database.EnsureCreated();
        return db;
    }
}

