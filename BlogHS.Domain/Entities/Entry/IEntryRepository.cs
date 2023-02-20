using BlogHS.Domain.Interfaces;

namespace BlogHS.Domain.Entities.Entry
{
    public interface IEntryRepository : IAsyncRepository<Entry>
    {
    }
}
