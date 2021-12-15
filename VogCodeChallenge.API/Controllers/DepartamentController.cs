using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentController : Controller
    {
        private readonly IDepartamentRepository _departamentRepository;
        public DepartamentController(IDepartamentRepository departamentRepository)
        {
            _departamentRepository = departamentRepository;
        }

        [HttpGet]
        public IList<Departament> ListAll()
        {
            return _departamentRepository.ListAll();
        }

        [HttpGet("{id}")]
        public IEnumerable<Departament> Get(int id)
        {
            return _departamentRepository.GetAllById(id);
        }
    }
}
