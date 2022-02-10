using Esercitazione.CoreLibrary.Entities;
using Esercitazione.CoreLibrary.Interfaces;
using Esercitazione.Library.Entities;
using Esercitazione.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione.Library.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
       private IBookRepository _bookRepository;
        private IPrestitoRepository _prestitoRepository;
       

        public BusinessLayer()
        {
            _bookRepository = DependencyContainer.Resolve<IBookRepository>();
            _prestitoRepository=DependencyContainer.Resolve<IPrestitoRepository>();
        }
        public BusinessLayer(IBookRepository repo, IPrestitoRepository repoP)
        {
            _bookRepository = repo;
            _prestitoRepository = repoP;
        }
       
        public bool AddNewBook(Book newBook)
        {
           if(newBook == null)
                return false;
           return _bookRepository.Add(newBook);
        }

        public bool AddNewPrestito(Prestito pres)
        {
            if (pres == null)
                return false;
            return _prestitoRepository.Add(pres);
        }

        public bool DeleteBook(Book bookToDelete)
        {
           return _bookRepository.Delete(bookToDelete);
        }

        public bool DeletePrestito(Prestito pres)
        {
            return _prestitoRepository.Delete(pres);
        }

        public IList<Book> GetAllBooks()
        {
            return _bookRepository.GetAll().ToList();
        }

        public IList<Prestito> GetAllPrestiti()
        {
            return _prestitoRepository.GetAll().ToList();
        }

        public Prestito PrestitoLibro(Book bookDaPrestare)
        {
            if (_bookRepository.Equals(bookDaPrestare))
            {
                return new Prestito { DataPrestito=DateTime.Now, DataReso=null, IdLibro=bookDaPrestare.ISBN };
            }
            return null;
        }

        public Prestito ResaLibro(Prestito pres, Book bookDaRestituire)
        {
            if(pres != null)
            {
                pres.DataReso = DateTime.Now;
                return pres;
            }
            return null;
        }

        public bool UpdateBook(Book bookToUpdate)
        {
           return _bookRepository.Update(bookToUpdate);
        }

        public bool UpdatePrestito(Prestito pres)
        {
           return _prestitoRepository.Update(pres);
        }
    }
}
