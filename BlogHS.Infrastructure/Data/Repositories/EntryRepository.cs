using BlogHS.Domain.Entities.Entry;

namespace BlogHS.Infrastructure.Data.Repositories
{
    public class EntryRepository : RepositoryBase<Entry>
        , IEntryRepository
    {
        public EntryRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
