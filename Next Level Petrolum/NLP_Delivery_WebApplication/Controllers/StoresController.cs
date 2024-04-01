using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.Abstractions.Repo;
using NLP_Delivery_WebApplication.DTOS.Addresses;
using NLP_Delivery_WebApplication.DTOS.StoreDTO;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IStoreRepo _storeRepo;
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public StoresController(DataContext dataContext, IMapper mapper, IStoreRepo repo) 
        {
            _storeRepo = repo;
            _dataContext = dataContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStore()
        {
            var stores = await _storeRepo.GetAllStoresAsync();
            var storesGet = _mapper.Map<List<GetStoreDTO>>(stores);

            return Ok(storesGet);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoreById(int id)
        {
            
            
            var storeGet = _mapper.Map<GetStoreDTO>(stores);

            return Ok(storeGet);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDTO store)
        {
            var domainStore = _mapper.Map<Stores>(store);

            

            var storeGet = _mapper.Map<GetStoreDTO>(domainStore);

            return CreatedAtAction(nameof(GetStoreById), new { id = domainStore.StoreID }, storeGet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStoreByID([FromBody] CreateStoreDTO updated, int id)
        {
            var toupdate = _mapper.Map<Stores>(updated);

            

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreByID(int id) 
        {
            
            return NoContent();
        }
        
        [HttpGet("{StoreId}/Address")]
        public async Task<IActionResult> GetAllStoreAddresses(int StoreId)
        {
            
            var mappedAddress = _mapper.Map<List<GetAddressesDTO>>(address);

            return Ok(mappedAddress);
        }

        [HttpGet("{StoreId}/Address/{AddressId}")]
        public async Task<IActionResult> GetStoreAddressById(int AddressId, int StoreId)
        {
            

            var mappedaddress = _mapper.Map<GetAddressesDTO>(address);

            return Ok(mappedaddress);
        }

        [HttpPost("{StoreId}/Address")]
        public async Task<IActionResult> AddStoreAddress(int StoreId, [FromBody] PostPutAddressesDTO newAddress)
        {
            var address = _mapper.Map<Addresses>(newAddress);

            

            var mappedAddress = _mapper.Map<GetAddressesDTO>(address);
            return CreatedAtAction(nameof(GetStoreAddressById),
                new { StoreId = StoreId, AddressId = mappedAddress.AddressID }, mappedAddress);
        }

        [HttpPut("{StoreId}/Address/{AddressId}")]
        
        public async Task<IActionResult> UpdateStoreAddress(int StoreId, int AddressId,
            [FromBody] PostPutAddressesDTO updatedAddress)
        {
            var toUpdate = _mapper.Map<Addresses>(updatedAddress);
            toUpdate.StoreID = StoreId;
            toUpdate.AddressID = AddressId;

            

            return NoContent();
        }

        [HttpDelete("{StoreId}/Address/{AddressId}")]
        public async Task<IActionResult> RemoveAddressFromStore(int StoreId, int AddressId)
        {
            

            return NoContent();
        }

    }
}
