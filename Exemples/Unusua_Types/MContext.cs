using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Unusua_Types
{
    public class MContext:DbContext
    {
        public DbSet<Manga> Mangas { get; set; }
    }
}
