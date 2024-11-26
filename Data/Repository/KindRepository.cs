using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class KindRepository : GenericRepository<Kind>, IKindRepository
    {
        public KindRepository(ZiekenFondsApiContext context) : base(context)
        {

        }
    }
}
