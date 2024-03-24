using AutoMapper;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.DTOS.StoreDTO;

namespace NLP_Delivery_WebApplication.Automapper.AutoMapperStore
{
    public class StoreMappingProfile : Profile
    {
        public StoreMappingProfile() 
        {
            CreateMap<Stores, GetStoreDTO>();
            CreateMap<CreateStoreDTO, Stores>();
        }
    }
}
