using AutoMapper;

namespace Valhalla.Infrastructure.AutoMapper
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
