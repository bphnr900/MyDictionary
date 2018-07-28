using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace MyDictionary
{
    public class DictionaryContext : DbContext
    {
        public DictionaryContext() : base("MainConnection")
        {
        }

        public DbSet<word> words { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<word>()
                .HasKey(i => i.WordId);
        }
    }
}
