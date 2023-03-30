using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using FinalProject.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace FinalProject.Models
{
    public class FinalProjectDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public FinalProjectDBContext(DbContextOptions<FinalProjectDBContext> options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("CustomerDataService");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Customer> Customers { get; set; } = null!; 
        public DbSet<Email> Emails { get; set; } = null!;
    }
}
