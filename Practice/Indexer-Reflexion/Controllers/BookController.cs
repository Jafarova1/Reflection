using Indexer_Reflexion.Service;
using Indexer_Reflexion.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Controllers
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookService bookService = new BookSErvice();
            Console.WriteLine(bookService.GetCount(m=> m.Author=="Nizami"));
        }
    }
}
