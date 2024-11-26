using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class ActiviteitRepository : GenericRepository<Activiteit>, IActiviteitRepository
    {
        public ActiviteitRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}
