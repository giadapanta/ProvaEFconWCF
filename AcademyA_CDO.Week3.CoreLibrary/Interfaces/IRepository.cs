using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyA_CDO.Week3.CoreLibrary.Interfaces
{
    public interface IRepository<T>
    {
        //interfaccia generica per i repository e farà uso dei generic <T> perchè deve implementare
        //le cose che si possono fare con un repository.
        //Ienumberable è + generico di ilist. 

        IEnumerable<T> Fetch(Func<T,bool> filter =null);
        T GetById(string id);
        bool Add(T newItem);
        bool DeleteById(string id);
        bool Update(T updatedItem);

    }
}
