using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class OnkostenRepository : GenericRepository<Onkosten>
    {
        public OnkostenRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}
