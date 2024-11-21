using Api.Ziekenfonds.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZiekenFonds.API.Data
{
    public class ZiekenFondsApiContext: IdentityDbContext // TODO: Custom user
    {
        public DbSet<Activiteit> Activiteiten { get; set; }
    }
}
