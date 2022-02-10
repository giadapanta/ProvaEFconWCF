using Esercitazione.CoreLibrary.Entities;
using Esercitazione.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitazione.Library.Interfaces
{
    public interface IBusinessLayer
    {
        IList<Book> GetAllBooks();
        bool AddNewBook(Book newBook);
        bool DeleteBook(Book bookToDelete);
        bool UpdateBook(Book bookToUpdate);
        Prestito PrestitoLibro(Book bookDaPrestare);
        Prestito ResaLibro(Prestito pres, Book bookDaRestituire);
        IList<Prestito> GetAllPrestiti();
        bool AddNewPrestito(Prestito pres);
        bool DeletePrestito(Prestito pres);
        bool UpdatePrestito(Prestito pres);
    }
}
