using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using FinalProject.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

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

        public DbSet<Location> Locations { get; set; } = null!; 
        public DbSet<Landmark> Landmarks { get; set; } = null!;
    }
}
