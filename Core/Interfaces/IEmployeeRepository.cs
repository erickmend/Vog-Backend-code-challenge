using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll(int id);
        IList<Employee> ListAll();
        IList<Employee> ListByDepartament(int departamentId);
    }
}
