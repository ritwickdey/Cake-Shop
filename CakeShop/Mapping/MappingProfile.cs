using AutoMapper;
using CakeShop.Core.Dto;
using CakeShop.Core.Models;

namespace CakeShop.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<CakeDto, Cake>();

            CreateMap<Cake, CakeDto>();
        }
    }
}
