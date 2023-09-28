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
                    new Book {Title = "AAA Batteries", PublicationYear = 219},
                    new Book {Title = "A Dub", PublicationYear = 1}
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

    public static void createDatabase()
    {
        using var db = new BooksContext();
    }
}

