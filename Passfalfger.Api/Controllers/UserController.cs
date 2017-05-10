using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passfalfger.Infrastructure.DTO;
using Passfalfger.Infrastructure.Services;

namespace Passfalfger.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDTO Get(string email)
        {
            return _userService.Get(email);
        }
 
    }
}
