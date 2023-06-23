using Application.Interfaces;
using Application.ViewModel.Doctor;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService serviceDoctor;

        public DoctorController(IDoctorService serviceDoctor)
        {
            this.serviceDoctor = serviceDoctor;
        }
        // GET: api/<DoctorController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await serviceDoctor.FindAll());
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            return Ok(await serviceDoctor.FindById(id));
        }

        // POST api/<DoctorController>
        [HttpPost]
        public async Task<ActionResult> Post(DoctorCreate newDoctor)
        {
            var doctor = await serviceDoctor.Insert(newDoctor);
            return CreatedAtAction(nameof(Get),new { doctor.Id}, doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(DoctorResponse updateDoctor)
        {
            var doctor = await serviceDoctor.Update(updateDoctor);

            if (doctor == null)
                return NotFound();

            return Ok(doctor);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await serviceDoctor.DeleteById(id);
            return NoContent();
        }
    }
}
