using Esercitazione.CoreLibrary.Entities;
using Esercitazione.CoreLibrary.Interfaces;
using Esercitazione.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione.Library.Mock.Repositories
{
    public class MockPrestitoRepository : IPrestitoRepository
    {
        private List<Prestito> _prestitoList = new List<Prestito>()
        {
            new Prestito { Id ="Pres01",IdLibro="L0001", Utente="giada", DataPrestito=new DateTime(2022,01,25), DataReso=null}
        };
        public bool Add(Prestito newItem)
        {
            var exists = _prestitoList.Exists(p => p.Id == newItem.Id);
            if (exists)
                throw new Exception($"Book with isbn: {newItem.Id} already exists");
            _prestitoList.Add(newItem);
            return true;
        }

        public bool Delete(Prestito itemToDelete)
        {
            var exists = _prestitoList.Exists(p => p.Id == itemToDelete.Id);
            if(exists)
                _prestitoList.Remove(itemToDelete);
            return false;
        }

        public IEnumerable<Prestito> GetAll()
        {
            return _prestitoList;
        }

        public Prestito GetById(string id)
        {
            var pres = _prestitoList.FirstOrDefault(p => p.Id == id);
            if (pres == null)
                return null;
            return pres;
        }

        //public Prestito PrestitoLibro(Book bookDaPrestare)
        //{
        //    MockBookRepository bookRepo = new MockBookRepository();
        //    if (bookRepo.Equals(bookDaPrestare))
        //    {
        //        return new Prestito { DataPrestito = DateTime.Now, DataReso = null, IdLibro=bookDaPrestare.ISBN};
        //     }
        //    return null;
        //}

        //public Prestito ResaLibro(Prestito pres, Book bookDaRestituire)
        //{
        //    if(bookDaRestituire.ISBN == pres.IdLibro)
        //    {
        //        pres.DataReso=DateTime.Now;
        //        return pres;
        //    }
        //    return null;
        //}

        public bool Update(Prestito updatedItem)
        {
            foreach (var p in _prestitoList)
            {
                p.Id = updatedItem.Id;
                p.IdLibro = updatedItem.IdLibro;
                p.Utente = updatedItem.Utente;
                p.DataPrestito= updatedItem.DataPrestito;
                p.DataReso = updatedItem.DataReso;
                return true;
            }
            return false;
        }
    }
}
