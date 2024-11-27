using Microsoft.EntityFrameworkCore;
using ZiekenFonds.API.Models;

namespace ZiekenFonds.API.Data.Repository
{
    public class GroepsReisRepository : GenericRepository<Groepsreis>, IGroepsReisRepository
    {
        public GroepsReisRepository(ZiekenFondsApiContext context) : base(context)
        {
        }

        public async Task<Groepsreis?> GetCompleteGroepsReis(int id)
        {
            return await _context.Groepsreizen
                .Include(groepsreis => groepsreis.Bestemming)
                    .ThenInclude(bestemming => bestemming.Fotos)
                .Include(groepsreis => groepsreis.Bestemming)
                    .ThenInclude(bestemming => bestemming.Reviews)
                .Include(groepsreis => groepsreis.Programmas)
                    .ThenInclude(programma => programma.Activiteit)
                .Include(groepsreis => groepsreis.Deelnemers)
                .Include(groepsreis => groepsreis.Monitors)
                .FirstOrDefaultAsync(groepsreis => groepsreis.Id == id);
        }
    }
}