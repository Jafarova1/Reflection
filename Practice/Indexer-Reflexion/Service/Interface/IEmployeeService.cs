using Indexer_Reflexion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflexion.Service.Interface
{
    public interface IEmployeeService
    {
        double GetAllByAverageSalary(Predicate<Employee>predicate);
    }
}
