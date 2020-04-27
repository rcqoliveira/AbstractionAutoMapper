using AutoMapper;

namespace Demo.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static IMapper Mapper { get; private set; }
        public static MapperConfiguration MapperConfiguration { get; private set; }

        public static void Initialize()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<PersonProfile>();
                cfg.AddProfile<CompanyProfile>();
            });

            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}
