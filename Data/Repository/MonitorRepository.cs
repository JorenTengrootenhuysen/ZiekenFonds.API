using Monitor = ZiekenFonds.API.Models.Monitor;

namespace ZiekenFonds.API.Data.Repository

{
    public class MonitorRepository : GenericRepository<Monitor>, IMonitorRepository
    {
        public MonitorRepository(ZiekenFondsApiContext context) : base(context)
        {
        }
    }
}