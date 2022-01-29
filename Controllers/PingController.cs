using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XssValidatorUsage.Controllers
{

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        public UserController()
        {

        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            return Ok();
        }

    }
}
