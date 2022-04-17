using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DevelopersDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=(localDb)\MSSQLLocalDB;database=DeveloperDb;Trusted_connection=False;MultipleActiveResultSets=True;");
        }
        public DbSet<MainSubject> MainSubjects { get; set; }
        public DbSet<SubSubject> SubSubjects { get; set; }
    }
}
