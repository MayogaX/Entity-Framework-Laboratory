using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HerancaTPT
{
    public class JogadoresContext:DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }

        public JogadoresContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<JogadoresContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Jogador>().ToTable("Jogadores");
            //modelBuilder.Entity<Artilheiro>().ToTable("Artilheiros");
            //modelBuilder.Entity<Goleiro>().ToTable("Goleiros");

            base.OnModelCreating(modelBuilder);
        }
    }
}
