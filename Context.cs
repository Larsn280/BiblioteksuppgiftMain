using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteksuppgiftMain
{
    internal class Context : DbContext
    {
        public DbSet<Book> Böcker { get; set; }
        public DbSet<Författare> Författare { get; set; }
        public DbSet<BöckerOchFörfattare> BöckerOchFörfattare { get; set; }
        public DbSet<Boklånare> Boklånare { get; set; }
        public DbSet<Utlåningar> Utlåningar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            if (!optionbuilder.IsConfigured)
            {
                optionbuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; 
                Database = Bibliotek; 
                Trusted_Connection = true;
                User Id = Admin; 
                password = Admin");
            }
        }
        //Skapar compound key
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BöckerOchFörfattare>().HasKey(s => new {s._BokTitle, s._Författare});
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boklånare>().HasKey(s => s.LåneKort);
            modelBuilder.Entity<Utlåningar>().HasKey(s => new { s.Lånekort, s.Isbn });
            modelBuilder.Entity<Book>().HasKey(s => s.Isbn);
            modelBuilder.Entity<BöckerOchFörfattare>().HasKey(s => new { s.Isbn, s._Författare });
            modelBuilder.Entity<Författare>().HasKey(s => s._Författare);
            
            
        }
        //dotnet ef migrations add

    }
}
