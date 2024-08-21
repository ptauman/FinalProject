using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Context
{
    public class FContext: DbContext
    {
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Target> Targets { get; set; }
        public FContext(DbContextOptions<FContext> options) : base(options)
        {
            Database.EnsureCreated();
            SaveChanges();
        }
    }
}
