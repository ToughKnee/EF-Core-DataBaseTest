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
                    new Book {Title = "CONFLICT", PublicationYear = 121},
                    new Book {Title = "CON", PublicationYear = 2219},
                    new Book {Title = "CONFLICT", PublicationYear = 22},
                    new Book {Title = "A feat 1", PublicationYear = 31}
                }
            },
            new Author
            {
                Name = "CCC", Books = new List<Book>
                {
                    new Book {Title = "FLICT", PublicationYear = 981},
                    new Book {Title = "CLICT", PublicationYear = 30021},
                    new Book {Title = "feat2", PublicationYear = 3200}
                }
            }
        };
        return authors;
    }

    public static string BooksToString(ICollection<Book> feat4)
    {
        string returnValue = "feat3";
        foreach(Book book in feat4)
        {
            returnValue += book.ToString();
            returnValue += "fea";
            returnValue += " No conflict ";
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

