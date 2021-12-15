using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IDepartamentRepository
    {
        IEnumerable<Departament> GetAllById(int id);
        IList<Departament> ListAll();
    }
}
