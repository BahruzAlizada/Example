using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Example; Integrated Security=true;");
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Quetsion> Quetsions { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
