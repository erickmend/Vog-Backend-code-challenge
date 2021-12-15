using BusinessLogic.Constants;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Logic
{
    public class EmployeeRepository : IEmployeeRepository
    {

        public IEnumerable<Employee> GetAll(int id)
        {
            return MockData.Employees.Where(x => x.Id == id);
        }

        public IList<Employee> ListAll()
        {
            return MockData.Employees;
        }

        public IList<Employee> ListByDepartament(int departamentId)
        {
            return MockData.Employees.Where(x => x.DepartamentId == departamentId).ToList();
        }
    }
}
