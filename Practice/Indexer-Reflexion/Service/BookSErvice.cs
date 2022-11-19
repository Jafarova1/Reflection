using Indexer_Reflexion.Models;
using Indexer_Reflexion.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Service
{
    public class BookSErvice : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
