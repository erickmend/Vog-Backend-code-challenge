using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Entity
    {
        public int Id { private set; get; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }


        public void CreateEntity()
        {
            CreationDate = DateTime.Now;
            EditEntity();
            IsActive = true;
            IsDeleted = false;
        }
        public void EditEntity()
        {
            LastUpdate = DateTime.Now;
        }

        public void ChangeStatus()
        {
            IsActive = !IsActive;
            EditEntity();
        }

        public void Delete()
        {
            IsActive = false;
            IsDeleted = true;
            EditEntity();
        }

    }
}
