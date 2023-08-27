using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=EfCoreBasics; " + 
                "User id=sa; Password=Kip; Encrypt=False; TrustServerCertificate=True");
        }
        public DbSet<Tour> Tours { get; set; }
    }
}
