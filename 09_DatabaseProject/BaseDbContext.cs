using System;
using System.Collections.Generic;
using _09_DatabaseProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _09_DatabaseProject
{
	public class BaseDbContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BaseDbContext()
		{
		}

        public BaseDbContext(DbContextOptions<BaseDbContext> dbContextOptions, IConfiguration configuration)
        : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = CSharpCamp; User Id = SA; Password = rentacardb; TrustServerCertificate=true");
        }
    }
    
}





