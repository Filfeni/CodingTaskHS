using AutoMapper;
using BlogHS.Domain.Interfaces;
using BlogHS.Domain.Models.Entry;
using EntryEntity = BlogHS.Domain.Entities.Entry.Entry;

namespace BlogHS.API.Services.Entry
{
    public class EntryService : BaseService
    {
        private readonly IMapper _mapper;
        public EntryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            _mapper = mapper;
        }

        public async Task<EntryDTO> GetByIdAsync(int id)
        {
            var repository = UnitOfWork.AsyncRepository<EntryEntity>();
            var result = await repository.GetAsync(x => x.Id == id);

            return _mapper.Map<EntryDTO>(result);
        }

        public async Task<List<EntryDTO>> GetAllAsync()
        {
            var repository = UnitOfWork.AsyncRepository<EntryEntity>();
            var result = await repository.ListAsync(x => true);

            return result.Select(x => _mapper.Map<EntryDTO>(x)).ToList();
        }

        public async Task<EntryDTO> CreateEntryAsync(BaseEntryDTO dto)
        {
            var repository = UnitOfWork.AsyncRepository<EntryEntity>();
            var entity = _mapper.Map<EntryEntity>(dto);
            var newEntity = await repository.AddAsync(entity);

            return _mapper.Map<EntryDTO>(newEntity);
        }
        public async Task<bool> UpdateEntryAsync(EntryDTO dto)
        {
            try
            {
                var repository = UnitOfWork.AsyncRepository<EntryEntity>();
                var current = await repository.GetAsync(x => x.Id == dto.Id);
                current.Update(dto.Title, dto.Content, dto.Thumbnail, dto.CreationDate, dto.ModificationDate);
                var newEntity = await repository.UpdateAsync(current);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteEntryAsync(int id)
        {
            try
            {
                var repository = UnitOfWork.AsyncRepository<EntryEntity>();
                var current = await repository.GetAsync(x => x.Id == id);

                return await repository.DeleteAsync(current);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
