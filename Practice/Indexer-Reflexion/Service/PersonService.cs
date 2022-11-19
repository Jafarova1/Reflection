using Indexer_Reflection.Models;
using Indexer_Reflexion.Service.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Service
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = GetFullData();

            var filteredDatas = datas.FindAll(predicate);
            var result = Math.Pow(filteredDatas.Count, 2);
            return (int)result;
        }

        public List<Person> GetFullData(Predicate<Person> predicate)
        {
            List<Person> people = new List<Person>();

            Person person1 = new()
            {
                Name = "Cesul",
                Surname = "Hesenov",
                Adress = "Xalqlar",
                Salary = 400,
            };
            Person person2 = new()
            {
                Name = "Covreste",
                Surname = "Alizade",
                Adress = "Azadliq",
                Salary = 700,
            };
            Person person3 = new()
            {
                Name = "Qoshqar",
                Surname = "Nerimanov",
                Adress = "Ehmedli",
                Salary = 8000,
            };
            Person person4 = new()
            {
                Name = "Lale",
                Surname = "Quliyeva",
                Adress = "Nesimi",
                Salary = 2000,
            };
            Person person5 = new()
            {
                Name = "Gultac",
                Surname = "Ceferova",
                Adress = "Tbilisi",
                Salary = 10000,

            };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            var result = people.FindAll(predicate);

            List<string> fullDatas = new();
            foreach (var item in result)
            {
                string data = $"{item.Name}  {item.Surname} {item.Adress}";
                fullDatas.Add(data);
            }
            return people;
        }
      

        public List<string> GetFullData(Predicate<PersonService> predicate)
        {
            throw new NotImplementedException();
        }
    }
      
    }

