using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Employee : Entity
    {
        public Employee()
        {

        }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string ResidenceAddress { get; set; }

        public  int DepartamentId { get; set; }
    }
}
