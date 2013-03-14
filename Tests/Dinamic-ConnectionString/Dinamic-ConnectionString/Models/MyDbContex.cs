using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dinamic_ConnectionString.Models
{
    public class MyDbContex : DbContext
    {
        public MyDbContex(string connString): base(connString)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<MyConnectionString> MyConnectionStrings { get; set; }
    }
}