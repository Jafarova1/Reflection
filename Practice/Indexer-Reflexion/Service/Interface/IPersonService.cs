using Indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Service.Interface
{
    public interface IPersonService
    {
        List<string> GetFullData(Predicate<PersonService> predicate);

        int GetFilteredDatasCount(Predicate<Person>predicate);
    }
}
