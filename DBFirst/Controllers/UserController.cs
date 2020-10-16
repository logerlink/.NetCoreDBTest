using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirstService.Impl;
using DBFirstService.IService;
using Microsoft.AspNetCore.Mvc;

namespace DBFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
           // var users = _userService.GetUsers();
            return new List<string>() { "4444", "5555" };

        }
        [HttpGet]
        [Route("getUser")]
        public ActionResult GetUser()
        {
            var users = _userService.GetUsers();
            return Json(users);

        }
    }
}
