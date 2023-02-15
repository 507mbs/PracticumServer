
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;

namespace DBContext
{

    public class MyDbContext : DbContext, IContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Detail> Details { get; set; }

        //public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{
        //    throw new NotImplementedException();
        //}

        //on configuring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=form;Trusted_Connection=True");
            //optionsBuilder.UseSqlServer("Server=sqlsrv;Database=BazeProject;Trusted_Connection=True");
        }
       
    }
}