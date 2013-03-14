using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unusua_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            MContext db = new MContext();

            Manga manga = new Manga();
            manga.Date = DateTime.Now;

            db.Mangas.Add(manga);
            db.SaveChanges();

            Console.WriteLine("date: " + manga.Date);
            Console.ReadLine();
        }
    }
}
