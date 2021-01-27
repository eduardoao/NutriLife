using Microsoft.AspNetCore.Mvc;
using NutriLife.API.Controllers.Person;
using NutriLife.Interfaces.Services;


namespace NutriLife.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

     
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonRequest value)
        {
           // _personService.CreatePerson();
        }
      
    }
}
