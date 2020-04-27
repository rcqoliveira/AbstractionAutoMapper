using AutoMapper;

namespace Demo.AutoMapper
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Person, PersonDto>().ReverseMap();
        }
    }
}
