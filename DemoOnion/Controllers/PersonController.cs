using Application.Service;
using Application.ViewModel;
using Domain.Person;
using Microsoft.AspNetCore.Mvc;

namespace DemoOnion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        readonly IPersonService personService;
        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await personService.GetData());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetID(int Id)
        {
            return Ok(await personService.GetById(Id));
        }
        [HttpPost]
        public async Task<IActionResult> Insert(PersonViewModel PersonEx)
        {
            return Ok(await personService.Insert(PersonEx));
        }
        [HttpPut]
        public async Task<IActionResult> Update(Person PersonEx)
        {
            return Ok(await personService.Update(PersonEx));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await personService.Delete(Id));
        }
    }
}