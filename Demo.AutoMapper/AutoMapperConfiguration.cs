using AutoMapper;
using Demo.AutoMapper.Class;

namespace Demo.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; private set; }
        public static MapperConfiguration MapperConfiguration { get; private set; }

        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PeopleRequest, PeopleResponse>();
                cfg.CreateMap<PeopleResponse, PeopleRequest>();
            });

            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}
