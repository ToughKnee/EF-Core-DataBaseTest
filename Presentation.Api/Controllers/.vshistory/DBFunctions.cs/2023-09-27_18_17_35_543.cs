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
                    new Book {Title = "AAAAAAAAA", PublicationYear = 1821},
<<<<<<< HEAD
                    new Book {Title = "master conflict", PublicationYear = 219},
=======
                    new Book {Title = "Conflict 2", PublicationYear = 2},
>>>>>>> 8855cb7 (Commit 2)
                    new Book {Title = "A Dub", PublicationYear = 1}
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

