using Esercitazione.Library.Entities;
using Esercitazione.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esercitazione.Library.Mock.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>()
        {
            new Book {ISBN ="L0001", Titolo ="La divina commedia", Autore="Dante Alighieri", Sommario="..."},
            new Book {ISBN ="L0002", Titolo="Harry Potter e la pietra filosofale", Autore="J.K. Rowling", Sommario="..." },
            new Book {ISBN ="L0003", Titolo="Harry Potter e la camera dei segreti", Autore ="J.K. Rowling", Sommario ="..."},
            new Book {ISBN ="L0004", Titolo="Se questo è un uomo", Autore="Primo Levi", Sommario="..."}
        };
        public bool Add(Book newItem)
        {
            var exists = _books.Exists(b => b.ISBN  == newItem.ISBN);
            if (exists)
                throw new Exception($"Book with isbn: {newItem.ISBN} already exists");
            _books.Add(newItem);
            return true;
        }

        public bool Delete(Book itemToDelete)
        {
           var exists=_books.Contains(itemToDelete);
            if (exists)
                return _books.Remove(itemToDelete);
            throw new Exception($"Book with isbn: {itemToDelete.ISBN} doesn't exist");
            
                          
        }        

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book GetBookByTitolo(string titolo)
        {
            return _books.FirstOrDefault(b => b.Titolo == titolo);
        }

        public Book GetById(string id)
        {
           var book = _books.FirstOrDefault(b => b.ISBN == id);
            if (book == null)
                return null;
            return book;

        }

        public bool Update(Book updatedItem)
        {
            foreach(var b in _books)
            {
                b.Autore=updatedItem.Autore;
                b.Titolo=updatedItem.Titolo;
                b.Sommario=updatedItem.Sommario;
                b.ISBN=updatedItem.ISBN;
                return true;
            }
            return false;
        }
    }
}
