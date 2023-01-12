using Microsoft.EntityFrameworkCore;
using NLWalks.API.Models.Domain;

namespace NLWalks.API.Data
{
    public class NLWalksDbContext:DbContext
    {
        public NLWalksDbContext(DbContextOptions<NLWalksDbContext>options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
