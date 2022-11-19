using Indexer_Reflexion.Service;
using Indexer_Reflexion.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Controllers
{
    public class EmployeeController
    {
        public static void GetEmployeesSalaryAverage()
        {
            IEmployeeService employeeService = new EmployeeService();
            Console.WriteLine(employeeService.GetAllByAverageSalary(m=> m.Age>20 && m.Age<40));
        }
    }
}
