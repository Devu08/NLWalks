using Microsoft.EntityFrameworkCore;
using NLWalks.API.Data;
using NLWalks.API.Models.Domain;

namespace NLWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NLWalksDbContext nLWalksDbContext;

        public RegionRepository(NLWalksDbContext nLWalksDbContext)
        {
            this.nLWalksDbContext = nLWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nLWalksDbContext.Regions.ToListAsync();
        }
    }
}
