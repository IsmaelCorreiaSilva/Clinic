using Application.Interfaces;
using Application.ViewModel.Specialty;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyService specialtyService;

        public SpecialtyController(ISpecialtyService specialtyService)
        {
            this.specialtyService = specialtyService;
        }
  
        // GET: api/<SpecialtyController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await specialtyService.FindAll());
        }

        // GET api/<SpecialtyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await specialtyService.FindById(id));
        }

        // POST api/<SpecialtyController>
        [HttpPost]
        public async Task<ActionResult> Post(SpecialtyCreate newSpecialty)
        {
            var specialty = await specialtyService.Insert(newSpecialty);
            return CreatedAtAction(nameof(Get), new { specialty.Id }, specialty) ;
        }

        // PUT api/<SpecialtyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(SpecialtyResponse updateSpecialty)
        {
            var specialty = await specialtyService.Update(updateSpecialty);

            if(specialty== null)
                return NotFound();

            return Ok(specialty);
        }

        // DELETE api/<SpecialtyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var result = await specialtyService.DeleteById(id);
            
            if(result)
                return NoContent();

            return NotFound();               
        }
    }
}
