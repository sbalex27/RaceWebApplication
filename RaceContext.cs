using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;
using RaceWebApplication;

namespace RaceWebApplication
{
    public class RaceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Race;Trusted_Connection=True");
        }
        public DbSet<RaceWebApplication.Participante>? Participante { get; set; }
    }
}
