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
                    new Book {Title = "feat 1", PublicationYear = 121},
                    new Book {Title = "feat 1", PublicationYear = 2219},
                    new Book {Title = "feat 1", PublicationYear = 22},
                    new Book {Title = "A feat 1", PublicationYear = 31}
                }
            },
            new Author
            {
                Name = "CCC", Books = new List<Book>
                {
                    new Book {Title = "C", PublicationYear = 981},
                    new Book {Title = "C++", PublicationYear = 30021},
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

