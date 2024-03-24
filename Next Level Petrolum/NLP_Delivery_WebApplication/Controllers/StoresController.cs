using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.DTOS.Addresses;
using NLP_Delivery_WebApplication.DTOS.StoreDTO;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        //private readonly ILogger<StoresController> _logger;
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public StoresController(DataContext dataContext, IMapper mapper) 
        {
            //_logger = logger;
            _dataContext = dataContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStore()
        {
            var stores = await _dataContext.Store.ToListAsync();
            var storesGet = _mapper.Map<List<GetStoreDTO>>(stores);

            return Ok(storesGet);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoreById(int id)
        {
            var stores = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);

            if (stores == null)
                return NotFound();
            
            var storeGet = _mapper.Map<GetStoreDTO>(stores);

            return Ok(storeGet);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDTO store)
        {
            var domainStore = _mapper.Map<Stores>(store);

            _dataContext.Store.Add(domainStore);
            await _dataContext.SaveChangesAsync();

            var storeGet = _mapper.Map<GetStoreDTO>(domainStore);

            return CreatedAtAction(nameof(GetStoreById), new { id = domainStore.StoreID }, storeGet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStoreByID([FromBody] CreateStoreDTO updated, int id)
        {
            var toupdate = _mapper.Map<Stores>(updated);

            _dataContext.Store.Update(toupdate);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreByID(int id) 
        {
            var store = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);

            if (store == null)
                return NotFound();
            
            _dataContext.Store.Remove(store);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }
        
        [HttpGet("{StoreId}/Address")]
        public async Task<IActionResult> GetAllStoreAddresses(int StoreId)
        {
            var address = await _dataContext.Address.Where(a => a.StoreID == StoreId).ToListAsync();
            var mappedAddress = _mapper.Map<List<GetAddressesDTO>>(address);

            return Ok(mappedAddress);
        }

        [HttpGet("{StoreId}/Address/{AddressId}")]
        public async Task<IActionResult> GetStoreAddressById(int AddressId, int StoreId)
        {
            var address = await _dataContext.Address.FirstOrDefaultAsync(a => a.AddressID == AddressId && a.StoreID == StoreId);

            if (address == null)
                return NotFound("Address not Found");

            var mappedaddress = _mapper.Map<GetAddressesDTO>(address);

            return Ok(mappedaddress);
        }

        [HttpPost("{StoreId}/Address")]
        public async Task<IActionResult> AddStoreAddress(int StoreId, [FromBody] PostPutAddressesDTO newAddress)
        {
            var address = _mapper.Map<Addresses>(newAddress);

            var store = await _dataContext.Store.Include(s => s.Address)
                .FirstOrDefaultAsync(s => s.StoreID == StoreId);

            store.Address.Add(address);

            await _dataContext.SaveChangesAsync();

            var mappedAddress = _mapper.Map<GetAddressesDTO>(address);
            return CreatedAtAction(nameof(GetStoreAddressById),
                new { StoreId = StoreId, AddressId = mappedAddress.AddressID }, mappedAddress);
        }

        [HttpPut("{StoreId}/Address/{AddressId}")]
        public async Task<IActionResult> UpdateStoreAddress(int StoreId, int AddressId,
            [FromBody] PostPutAddressesDTO updatedAddress)
        {
            var toUpdate = _mapper.Map<Addresses>(updatedAddress);
            toUpdate.AddressID = AddressId;
            toUpdate.StoreID = StoreId;

            _dataContext.Address.Update(toUpdate);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{StoreId}/Address/{AddressId}")]
        public async Task<IActionResult> RemoveAddressFromStore(int StoreId, int AddressId)
        {
            var address = _dataContext.Address.SingleOrDefaultAsync(a => a.AddressID == AddressId && a.StoreID == StoreId);

            if (address == null) 
                return NotFound("Address not Found");

            _dataContext.Address.Remove(await address);
            await _dataContext.SaveChangesAsync();

            return NoContent();

        }

            
    }
}
