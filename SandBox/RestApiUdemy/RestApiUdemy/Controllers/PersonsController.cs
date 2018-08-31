using Microsoft.AspNetCore.Mvc;
using RestApiUdemy.Model;
using RestApiUdemy.Services;

namespace RestApiUdemy.Controllers
{

    public class PersonsController:Controller
    {

        private IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {

            var person = _personService.FindById(id);

            if (person == null) return NotFound();

            return Ok(person);

        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {

            if (person == null) return BadRequest();

            return new ObjectResult(_personService.Create(person));

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Person person)
        {

            if (person == null) return BadRequest();

            return new ObjectResult(_personService.Update(person));

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }

    }

}