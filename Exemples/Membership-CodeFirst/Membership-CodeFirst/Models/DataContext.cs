using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Membership_CodeFirst.Models
{
    public class EContext : DbContext
    {
        public EContext()
        : base("EContex")
    {
    }

        public DbSet<Exemple> Exemples { get; set; }
    }
}