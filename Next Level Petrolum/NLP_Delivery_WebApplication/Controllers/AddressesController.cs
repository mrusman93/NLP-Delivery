using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;
using NLP_Delivery_WebApplication.DTOS.Addresses;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public AddressesController(/*<addressesController> logger,*/DataContext
            dataContext, IMapper mapper)
        {
            //_logger = logger;
            _dataContext = dataContext;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAddresses()
        {
            var addresses = await _dataContext.Address.ToListAsync();
            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var addresses = await _dataContext.Address.FirstOrDefaultAsync(s => s.AddressID == id);
            return Ok(addresses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] DTOCreateAddresses Address)
        {
            var domainAddress = _mapper.Map<Addresses>(Address);

            _dataContext.Address.Add(domainAddress);
            await _dataContext.SaveChangesAsync();

            var AddressGet = _mapper.Map<DTOGetAddresses>(domainAddress);

            return CreatedAtAction(nameof(GetAddressById), new { id = domainAddress.AddressID }, AddressGet );
        }

        /*
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddressByID([FromBody] Addresses updated, int id)
        {
            var addresses = await _dataContext.Address.FirstOrDefaultAsync(s => s.AddressID == id);
            //Add some value before running Update function
            addresses. = updated.;
            addresses. = updated.;
            addresses. = updated.;


            _dataContext.Address.Update(addresses);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }
        */
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddressByID(int id)
        {
            var Address = await _dataContext.Address.FirstOrDefaultAsync(s => s.AddressID == id);
            _dataContext.Address.Remove(Address);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
