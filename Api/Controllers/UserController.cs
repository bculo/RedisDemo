using Api.Dtos;
using Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string userId)
        {
            var user = await _service.GetUser(userId ?? string.Empty);
            return Ok(new UserDTO { UserName = user.UserName, Age = user.Age, Email = user.Email });
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO model)
        {
            await _service.AddUser(model.UserName, model.Age, model.Email);
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
