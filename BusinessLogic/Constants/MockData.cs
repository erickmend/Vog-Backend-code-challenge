using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Constants
{
    public static class MockData
    {
        public static readonly Employee Employee1 = new Employee
        {
            Id = 1,
            FirstName = "Erick",
            LastName = "Mendoza",
            JobTitle = "Software Developer",
            ResidenceAddress = "Pedro Baranda 459",
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false,

            DepartamentId=1
        };

        public static readonly Employee Employee2 = new Employee
        {
            Id = 2,
            FirstName = "Luis",
            LastName = "Munguia",
            JobTitle = "Doctor",
            ResidenceAddress = "Lopez Portillo",
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false,

            DepartamentId = 1
        };

        public static readonly Employee Employee3 = new Employee
        {
            Id = 3,
            FirstName = "Denise",
            LastName = "Daniel",
            JobTitle = "Police",
            ResidenceAddress = "Corceless 7895",
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false,

            DepartamentId=2
        };

        public static readonly Employee Employee4 = new Employee
        {
            Id = 4,
            FirstName = "Enrique",
            LastName = "Bunbury",
            JobTitle = "Singer",
            ResidenceAddress = "Spain 789",
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false,

            DepartamentId = 2
        };


        public static readonly Departament Departament1 = new Departament
        {
            Id = 1,
            Name = "IT department",
            Address = "Address 1",
            Employees = new List<Employee> { Employee1, Employee2 },
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false
        };

        public static readonly Departament Departament2 = new Departament
        {
            Id = 2,
            Name = "Health Department",
            Address = "Address 2",
            Employees = new List<Employee> { Employee3, Employee4 },
            CreationDate = DateTime.Now,
            LastUpdate = DateTime.Now,
            IsActive = true,
            IsDeleted = false
        };


        public static readonly List<Employee> Employees = new List<Employee>
        {
            Employee1,
            Employee2,
            Employee3,
            Employee4
        };
        public static readonly List<Departament> Departaments = new List<Departament>
        {
            Departament1,
            Departament2
        };
    }
}
