using Esercitazione.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Library.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Book GetBookByTitolo(string titolo);    
    }
}
