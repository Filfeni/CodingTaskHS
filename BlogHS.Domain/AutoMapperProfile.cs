using AutoMapper;
using BlogHS.Domain.Entities.Entry;
using BlogHS.Domain.Models.Entry;

namespace BlogHS.Domain
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Entry, EntryDTO>();
            CreateMap<EntryDTO, Entry>();
            CreateMap<Entry, BaseEntryDTO>();
            CreateMap<BaseEntryDTO, Entry>();
        }
    }
}
