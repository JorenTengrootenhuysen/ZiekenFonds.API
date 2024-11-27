using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class OpleidingRepository : GenericRepository<Opleiding>, IOpleidingRepository
    {
        public OpleidingRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}
