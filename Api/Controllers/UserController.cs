using Api.Dtos;
using Api.Filters;
using Api.Interfaces;
using Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ErrorFilter]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string userId)
        {
            var user = await _service.GetUser(userId ?? string.Empty);
            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost]
        [ValidateModelFilter]
        public async Task<IActionResult> Post([FromBody] UserDTO model)
        {
            await _service.AddUser(_mapper.Map<User>(model));
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string userId)
        {
            await _service.RemoveUser(userId);
            return Ok();
        }
    }
}
