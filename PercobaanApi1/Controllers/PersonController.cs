using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;
using Microsoft.AspNetCore.Authorization;


namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }

        [HttpGet("api/person/{id_person}")]
        public ActionResult GetPersonById(int id_person)
        {
            PersonContext context = new PersonContext();
            var person = context.ListPerson().Find(x => x.id_person == id_person);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }
    }
}
