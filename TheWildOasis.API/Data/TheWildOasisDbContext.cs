using Microsoft.EntityFrameworkCore;
using TheWildOasis.API.Data.Models;

namespace TheWildOasis.API.Data
{
    public partial class TheWildOasisDbContext : DbContext
    {
        public TheWildOasisDbContext(DbContextOptions<TheWildOasisDbContext> options) : base(options)
        { }
        public DbSet<Cabin> Cabins { get; set; }
    }
}
