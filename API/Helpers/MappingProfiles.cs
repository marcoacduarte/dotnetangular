using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDTO>()
                .ForMember(m => m.ProductBrand, o => o.MapFrom(x => x.ProductBrand.Name))
                .ForMember(m => m.ProductType, o => o.MapFrom(x => x.ProductType.Name))
                .ForMember(m => m.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}