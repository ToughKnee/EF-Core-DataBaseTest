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
                    new Book {Title = "reset 2", PublicationYear = 2143},
                    new Book {Title = "reset 2", PublicationYear = 22},
                    new Book {Title = "A feat 1", PublicationYear = 31}
                }
            },
            new Author
            {
                Name = "CCC", Books = new List<Book>
                {
                    new Book {Title = "reset 1", PublicationYear = 9381},
                    new Book {Title = "feat2", PublicationYear = 311},
                    new Book {Title = "reset1", PublicationYear = 3100}
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
            returnValue += " FFFFFFFFFFFFF ";
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

