using Esercitazione.CoreLibrary.Entities;
using Esercitazione.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.WCFService
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        bool AddBook(Book newBook);
        [OperationContract]
        bool DeleteBook(Book newBook);
        [OperationContract]
        bool UpdateBook(Book newBook);
        [OperationContract]
        IEnumerable<Book> GetAllBooks();
        [OperationContract]
        Prestito PrestitoLibro(Book bookDaPrestare);
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        Prestito ResaLibro(Prestito pres, Book bookDaRestituire);
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        IEnumerable<Prestito> GetAllPrestiti();
    }
}
