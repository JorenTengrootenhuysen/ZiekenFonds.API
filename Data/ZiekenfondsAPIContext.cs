using Api.Ziekenfonds.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Api.Ziekenfonds.Data
{
    public class ZiekenfondsAPIContext : IdentityDbContext<CustomUser>
    {

    }
}
