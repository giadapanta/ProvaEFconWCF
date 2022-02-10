using System;

namespace Esercitazione.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var ctx = new LibraryContext())
            {
                ctx.Database.EnsureCreated();
            }
        }
    }
}
