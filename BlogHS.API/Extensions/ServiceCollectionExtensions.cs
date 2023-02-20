using BlogHS.API.Services.Entry;
using BlogHS.Domain.Entities.Entry;
using BlogHS.Domain.Interfaces;
using BlogHS.Infrastructure.Data;
using BlogHS.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogHS.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                .AddScoped<IEntryRepository, EntryRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<EFContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("DDDConnectionString")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<EntryService>();
        }
    }
}
