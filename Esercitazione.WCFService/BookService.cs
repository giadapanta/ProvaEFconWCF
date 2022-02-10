using Esercitazione.CoreLibrary.Entities;
using Esercitazione.CoreLibrary.Interfaces;
using Esercitazione.Library;
using Esercitazione.Library.BusinessLayer;
using Esercitazione.Library.Entities;
using Esercitazione.Library.Interfaces;
using Esercitazione.Library.Mock.Repositories;
using System.Collections.Generic;
using System.ServiceModel;
using Esercitazione.EF.Repositories;

namespace Esercitazione.WCFService
{
    public class BookService : IBookService
    {
        private IBusinessLayer _bl;

        public BookService()
        {
            DependencyContainer.Register<IBusinessLayer, BusinessLayer>();
            DependencyContainer.Register<IBookRepository, RepositoryBook>();
            DependencyContainer.Register<IPrestitoRepository, MockPrestitoRepository>();

            _bl = DependencyContainer.Resolve<IBusinessLayer>();
        }
        public bool AddBook(Book newBook)
        {
            return _bl.AddNewBook(newBook);
        }

        public bool DeleteBook(Book newBook)
        {
            return _bl.DeleteBook(newBook);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bl.GetAllBooks();
        }

        public IEnumerable<Prestito> GetAllPrestiti()
        {
            return _bl.GetAllPrestiti();
        }

        public Prestito PrestitoLibro(Book bookDaPrestare)
        {
            if (bookDaPrestare == null)
                throw new FaultException<LibraryFault>(
                    new LibraryFault() { Criticity = "Normal", Method = "LoanBook", Message = "Invalid data." }
                );
            else {
                Prestito pres =_bl.PrestitoLibro(bookDaPrestare);
                return pres;
                if (pres==null)
                    throw new FaultException<LibraryFault>(
                        new LibraryFault() { Criticity = "High", Method = "LoanBook", Message = "Error saving return record." }
                    );
            }
           
        }

        public Prestito ResaLibro(Prestito pres, Book bookDaRestituire)
        {
            return _bl.ResaLibro(pres, bookDaRestituire);
        }

        public bool UpdateBook(Book newBook)
        {
            return _bl.UpdateBook(newBook); 
        }
    }
}
