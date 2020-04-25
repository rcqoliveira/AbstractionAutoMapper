using Demo.AutoMapper.Class;

namespace Demo.AutoMapper
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        public static PeopleResponse ToResponse(this PeopleRequest entity)
        {
            return entity.MapTo<PeopleRequest, PeopleResponse>();
        }

        public static PeopleRequest ToRequest(this PeopleResponse model)
        {
            return model.MapTo<PeopleResponse, PeopleRequest>();
        }
    }
}
