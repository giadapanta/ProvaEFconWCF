using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Library.Interfaces
{
    public interface IRepository<T>
    {
       
        T GetById(string id);
        bool Add(T newItem);
        bool Delete(T itemToDelete);
        bool Update(T updatedItem);
        IEnumerable<T> GetAll();
    }
}
