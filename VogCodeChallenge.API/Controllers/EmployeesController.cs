using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IList<Employee> ListAll()
        {
            return _employeeRepository.ListAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<Employee> Get(int id)
        {
            return _employeeRepository.GetAll(id);
        }

        [HttpGet("departament/{departamentId}")]
        public IList<Employee> GetbyDepartament(int departamentId)
        {
            return _employeeRepository.ListByDepartament(departamentId);
        }
    }
}
