using Indexer_Reflexion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Service.Interface
{
    public interface IBookService
    {
        int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();
            return books.FindAll(predicate).Count;
        }
        private List<Book> GetAll()
        {

            List<Book> books = new List<Book>();
            Book book1 = new Book()
            {
                Name = "Iskendername",
                Author="Nizami",
            };

            Book book2 = new Book()
            {
                Name = "Sikayetname",
                Author = "Fizuli",
            };
            Book book3 = new Book()
            {
                Name = "Xosrov ve Shirin",
                Author = "Nizami",
            };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            return books;



        }
    }
}
