using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLP.Dal;
using NLP.Domain.Models;
using static NLP.Dal.AppDataContext;
/*
namespace NLP_Delivery_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public UserController(DataContext dataContext, IMapper mapper) 
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _dataContext.User.ToListAsync();
            var usersGet = _mapper.Map<List<GetUserDTO>>(users);
            return Ok(usersGet);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var users = await _dataContext.User.FirstOrDefaultAsync(u => u.UserID == id);

            if (users == null)
                return NotFound();

            var userGet = _mapper.Map<GetUserDTO>(users);
            return Ok(userGet);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUsersDTO User)
        {
            var domainUsers = _mapper.Map<Users>(User);

            _dataContext.User.Add(domainUsers);
            await _dataContext.SaveChangesAsync();

            var UserGet = _mapper.Map<GetUserDTO>(domainUsers);
            return CreatedAtAction(nameof(GetUserById), new { id = domainUsers.UserID }, UserGet);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] CreateUsersDTO updated, int id)
        {
            var toupdate = _mapper.Map<Users>(updated);
            toupdate.UserID = id;

            _dataContext.User.Update(toupdate);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id) 
        {
            var user = await _dataContext.User.FirstOrDefaultAsync(u => u.UserID == id);

            if (user == null)
                return NotFound();

            _dataContext.User.Remove(user);
            await _dataContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
*/