using AspNetCore2._2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore2._2.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions dbContext):base(dbContext)
        {

        }
        public DbSet<Request> Requests { get; set; }
    }
}
