using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class BestemmingRepository : GenericRepository<Bestemming>, IBestemmingRepository
    {
        public BestemmingRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}
