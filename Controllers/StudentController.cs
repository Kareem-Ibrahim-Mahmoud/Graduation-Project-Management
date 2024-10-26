using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Your_Graduation.DTO;
using Your_Graduation.Model;
using Your_Graduation.Services;

namespace Your_Graduation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public Context context;
        public IStudentReposatry studentrepo;

        public StudentController(Context _context, IStudentReposatry _studentrepo)
        {
            context = _context;
            studentrepo = _studentrepo;

        }

        [HttpGet]
        public async Task<IActionResult> getbyallstudent()
        {
            List<Student> student = context.Students.ToList();

            return Ok(student);

        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getbyId(int id)
        {

            Student std = context.Students.FirstOrDefault(d => d.Id == id);
            return Ok(std);

        }



        [HttpGet]
        [Route("{Name}")]
        public async Task<IActionResult> getbyName(string Name)
        {

            Student std = context.Students.FirstOrDefault(d => d.Name == Name);
            return Ok(std);

        }



        [HttpPost]
        public async Task<IActionResult> Create(Studentdto studdto)
        {
            Student student = new Student();


            if (ModelState.IsValid)
            {
               // student.Id = studdto.Id;
                student.Name = studdto.Name;
                student.PhoneNumber = studdto.PhoneNumber;
                student.universtyNumber = studdto.universtyNumber;
               

                studentrepo.Create(student);
                return Ok();
            }
            return BadRequest("Error in registering the purchase of the share. Please make sure that the entered data or the email registration process is correct.");



        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Student student)
        {
            Student std = new Student();
            var updatee = studentrepo.update(id, student);
            Student stud = context.Students.FirstOrDefault(s => s.Id == id);

            if (ModelState.IsValid)
            {
                if (stud != null)
                {
                    // std.Id = stud.Id;
                    std.Name = stud.Name;
                    std.PhoneNumber = stud.PhoneNumber;
                    std.universtyNumber = stud.universtyNumber;
                    std.group = stud.group;
                    std.tasks = stud.tasks;
                    std.idGroup = stud.idGroup;

                    studentrepo.update(id, std);

                    return Ok();

                }
                else
                {
                    return BadRequest("Error You must make sure that you did not leave the available fields blank and you must enter the correct statement.");

                }

            }

            //
            return BadRequest("Error You must make sure that you did not leave the available fields blank and you must enter the correct statement.");

        }



        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            context.Remove(student);
            int raw = context.SaveChanges();

            return Ok(raw);
        }





    }
}
