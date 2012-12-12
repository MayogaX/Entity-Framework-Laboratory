using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;

namespace Tracing_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (MContext db = new MContext())
            //{
            //    Manga manga = new Manga();
            //    manga.Title = "Saint Seiya";
            //    manga.Description = "The battle of Athena and Hades";

            //    db.Mangas.Add(manga).ToString();
            //    db.SaveChanges();
            //}

            //Console.ReadLine();

            using (MContext db = new MContext())
            {
                var result = (from m in db.Mangas
                              where m.Id.Equals(1)
                              select m);
                Console.WriteLine(((System.Data.Entity.Infrastructure.DbQuery<Manga>)result).ToString());
                //Console.WriteLine(result.Title);
            }
            Console.ReadLine();
        }
    }
}
