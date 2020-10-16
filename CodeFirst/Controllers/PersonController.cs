using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstCore.Model;
using CodeFirstService.IService;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("person")]
    public class PersonController : Controller
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Json(new List<string> {"CodeFirst测试" });
        }

        [HttpGet]
        [Route("AddOne")]  //         person/GetList
        public IActionResult AddOne()
        {
           var result =  _personService.Add(new Person() {Name="小石",Age=88 });
            return Json(new { success=result> 0});
        }


        [HttpGet]
        [Route("GetList")]  //         person/GetList
        public IActionResult GetList()
        {
            return Json(_personService.GetList());
        }

        
    }
}
