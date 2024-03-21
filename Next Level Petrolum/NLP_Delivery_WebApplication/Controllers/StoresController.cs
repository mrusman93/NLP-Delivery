using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        public StoresController() 
        {

        }

        [HttpGet]
        public IActionResult GetStore()
        {
            return Ok("Hello to Store Controller");
        }
    }
}
