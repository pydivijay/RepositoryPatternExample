using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternExample.Interfaces;
using RepositoryPatternExample.Models;

namespace RepositoryPatternExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("GetUsers")]
        [HttpGet]
        public IActionResult GetUsers()
        {
           List<User> userList =_userService.GetAll();
            return Ok(userList);
        }
    }
}
