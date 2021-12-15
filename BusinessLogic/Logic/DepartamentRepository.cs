using BusinessLogic.Constants;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class DepartamentRepository : IDepartamentRepository
    {
        public IEnumerable<Departament> GetAllById(int id)
        {
            return MockData.Departaments.Where(x => x.Id == id);
        }

        public IList<Departament> ListAll()
        {
            return MockData.Departaments;
        }
    }
}
