using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Departament : Entity
    {
        public Departament()
        {

        }

        public string Name { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
