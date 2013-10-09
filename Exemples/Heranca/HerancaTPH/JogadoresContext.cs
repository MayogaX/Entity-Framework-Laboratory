using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HerancaTPH
{
    public class JogadoresContext:DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }

        public JogadoresContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<JogadoresContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
