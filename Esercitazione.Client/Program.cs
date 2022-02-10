//using BookServicePrestito;
using BookServicePrestitoSelfHost;
//using BookServiceSelfHost;
using System;

namespace Esercitazione.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            BookServiceClient client = new BookServiceClient();
            //var prestiti = client.GetAllPrestiti();
            //foreach(var pres in prestiti)
            //{
            //    Console.WriteLine($"{pres.Id}, {pres.IdLibro}, {pres.Utente}, {pres.DataPrestito} , {pres.DataReso}");
            //}

            var books = client.GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.ISBN} - {book.Titolo} - {book.Autore} - {book.Sommario}");
            }

            //Book newBook=new Book();
            //newBook.ISBN = "A001";
            //newBook.Autore = "Alessandro Manzoni";
            //newBook.Titolo = "I promessi sposi";
            //newBook.Sommario = "bla bla bla";

            //var flag = client.AddBook(newBook);
            //Console.WriteLine(flag);

            //var books2 = client.GetAllBooks();
            //foreach (var book in books2)
            //{
            //    Console.WriteLine($"{book.ISBN} - {book.Titolo} - {book.Autore} - {book.Sommario}");
            //}


            //var flag2=client.DeleteBook(newBook);
            //Console.WriteLine(flag2);

            //var books3 = client.GetAllBooks();
            //foreach (var book in books3)
            //{
            //    Console.WriteLine($"{book.ISBN} - {book.Titolo} - {book.Autore} - {book.Sommario}");
            //}

            //PRESTITO



        }
    }
}
