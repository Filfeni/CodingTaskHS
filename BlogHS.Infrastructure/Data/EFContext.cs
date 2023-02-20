using BlogHS.Domain.Entities.Entry;
using Microsoft.EntityFrameworkCore;

namespace BlogHS.Infrastructure.Data
{
    public class EFContext : DbContext
    {
        public DbSet<Entry> entries { get; set; }
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }
    }
}
