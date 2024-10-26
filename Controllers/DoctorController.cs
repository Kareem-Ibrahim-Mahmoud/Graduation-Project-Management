using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Your_Graduation.DTO;
using Your_Graduation.Model;
using Your_Graduation.Services;

namespace Your_Graduation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public Context context;
        public IDoctorReposatry docrepo;

        public DoctorController(Context _context, IDoctorReposatry _docrepo)
        {
            context = _context;
            docrepo = _docrepo;
        }


        [HttpGet]
        public async Task<IActionResult> getbyalldoc()
        {
            List<Doctor> doctors = context.Doctors.ToList();

            return Ok(doctors);

        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getbyId(int id)
        {

            Doctor doc = context.Doctors.FirstOrDefault(d => d.Id == id);
            return Ok(doc);

        }

        [HttpGet]
        [Route("{Name}")]
        public async Task<IActionResult> getbyName(string Name)
        {

            Doctor doc = context.Doctors.FirstOrDefault(d => d.Name == Name);
            return Ok(doc);

        }


        [HttpPost]
        public async Task<IActionResult> Create(Doctordto docdto)
        {
            Doctor doctor = new Doctor();
            if (ModelState.IsValid)
            {
                doctor.Name = docdto.Name;
                
                doctor.Id = doctor.Id;
                docrepo.Create(doctor);
                return Ok();



            }
            return BadRequest("Error in registering the purchase of the share. Please make sure that the entered data or the email registration process is correct.");


        }



    }
}
