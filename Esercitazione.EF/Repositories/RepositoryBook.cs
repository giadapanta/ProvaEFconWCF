
using Esercitazione.Library.Entities;
using Esercitazione.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione.EF.Repositories
{
    public class RepositoryBook : IRepository<Book>
    {
        public bool Add(Book newItem)
        {
          using(var ctx = new LibraryContext())
            {
                ctx.Libri.Add(newItem);
                ctx.SaveChanges();
                
            }
          return true;  
        }

        public bool Delete(Book itemToDelete)
        {
            using (var ctx = new LibraryContext())
            {
                ctx.Libri.Remove(itemToDelete);
                ctx.SaveChanges();

            }
            return true;
        }

        public IEnumerable<Book> GetAll()
        {
            using (var ctx = new LibraryContext())
            {
                return ctx.Libri.ToList();

            }
            
        }

        public Book GetById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Book updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
