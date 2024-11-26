using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class FotoRepository : GenericRepository<Foto>
    {
        public FotoRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}
