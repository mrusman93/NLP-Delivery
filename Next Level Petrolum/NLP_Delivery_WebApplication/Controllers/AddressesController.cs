using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public AddressesController(/*<addressesController> logger,*/DataContext
            dataContext)
        {
            //_logger = logger;
            _dataContext = dataContext;
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
        public async Task<IActionResult> CreateAddress([FromBody] Addresses Address)
        {
            _dataContext.Address.Add(Address);
            await _dataContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAddressById), new { id = Address.AddressID, Address });
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
