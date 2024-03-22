
using NLP_Delivery_WebApplication.DTOS.Addresses;
using NLP.Domain.Models;
using AutoMapper;

namespace NLP_Delivery_WebApplication.Automapper.Address
{
    public class AddressMappingProfile : Profile
    {
        public AddressMappingProfile() 
        {
            CreateMap<DTOCreateAddresses, Addresses>();
            CreateMap<Addresses, DTOGetAddresses>();
        }
    }
}
