using Indexer_Reflexion.Service.Interface;
using Indexer_Reflexion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Controllers
{
    public class PersonController
    {




        public static void GetPersonDatas()
        {
            IPersonService personService = new PersonService();
            var result = personService.GetFullData(m=> m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        public static void GetFilteredPersonPowCount()
        {
            IPersonService personService=new PersonService();
            string word = "C";
            Console.WriteLine(personService.GetFilteredDatasCount(m => m.Name.ToLower().StartsWith(word.ToLower())));
        }

    }



}
