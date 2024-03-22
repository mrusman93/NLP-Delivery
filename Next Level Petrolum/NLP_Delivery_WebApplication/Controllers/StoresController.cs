using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        //private readonly ILogger<StoresController> _logger;
        private readonly DataContext _dataContext;
        public StoresController(/*<StoresController> logger,*/DataContext
            dataContext) 
        {
            //_logger = logger;
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetStore()
        {
            var stores = await _dataContext.Store.ToListAsync();
            return Ok(stores);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoreById(int id)
        {
            var stores = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);
            return Ok(stores);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStore([FromBody] Stores store)
        {
            _dataContext.Store.Add(store);
            await _dataContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStoreById), new {id = store.StoreID, store});
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStoreByID([FromBody] Stores updated, int id)
        {
            var stores = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);
            
            stores.StoreName = updated.StoreName;
            stores.Address = updated.Address;
            stores.Brand = updated.Brand;


            _dataContext.Store.Update(stores);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreByID(int id) 
        {
            var store = await _dataContext.Store.FirstOrDefaultAsync(s => s.StoreID == id);
            _dataContext.Store.Remove(store);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
