using BlogHS.Domain.Base;

namespace BlogHS.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity;
    }
}
