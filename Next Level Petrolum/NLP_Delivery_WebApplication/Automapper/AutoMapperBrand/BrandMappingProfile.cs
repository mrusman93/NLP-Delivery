using AutoMapper;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.DTOS.BrandDTO;

namespace NLP_Delivery_WebApplication.Automapper.AutoMapperBrand
{
    public class BrandMappingProfile : Profile
    {
        public BrandMappingProfile()
        {
            CreateMap<Brands, GetBrandDTO>();
            CreateMap<PostPutBrandDTO, Brands>();
        }
    }
}
