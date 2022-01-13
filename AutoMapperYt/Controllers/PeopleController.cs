using AutoMapper;
using AutoMapperYt.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperYt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IMapper _mapper;
        public PeopleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Post(PersonInputModel model)
        {
            var person = _mapper.Map<Person>(model);

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var person = new Person(id, "teste", "teste", DateTime.Now, MaritalStatusEnum.Single, "1111", "endereço");

            var personViewModel = _mapper.Map<PersonViewModel>(person);

            return Ok(personViewModel);
        }
    }
}
