using AutoMapper;

namespace Demo.AutoMapper
{
    public class AutoMapperConfiguration
    {
        private static readonly object ConcurrentLock = new object();
        public static IMapper Mapper { get; private set; }
        public static MapperConfiguration MapperConfiguration { get; private set; }
        private static bool _initialized;


        public static void Initialize()
        {   
            lock (ConcurrentLock)
            if (!_initialized)
            {
                MapperConfiguration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<PersonProfile>();
                    cfg.AddProfile<CompanyProfile>();
                });

                _initialized = true;
            }

            Mapper = MapperConfiguration.CreateMapper();
        }
    }
}
