using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HerancaTPC
{
    public class JogadoresContext:DbContext
    {
        public DbSet<Artilheiro> Artilheiros { get; set; }
        public DbSet<Goleiro> Goleiros { get; set; }

        public JogadoresContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<JogadoresContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Artilheiro>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Artilheiros");
            });

            modelBuilder.Entity<Goleiro>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Goleiros");
            });
 

            base.OnModelCreating(modelBuilder);
        }
    }
}
