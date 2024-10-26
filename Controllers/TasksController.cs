using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Your_Graduation.DTO;
using Your_Graduation.Model;
using Your_Graduation.Services;

namespace Your_Graduation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        public Context context;
        public ITasksReposatry itasksrepo;

        public TasksController(Context _context, ITasksReposatry _itaskrepo)
        {
            context = _context;
            itasksrepo = _itaskrepo;

        }

        [HttpGet]
        public async Task<IActionResult> getbyalltask()
        {
            List<Tasks> tsk = context.tasks.ToList();

            return Ok(tsk);

        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getbyId(int id)
        {

            Tasks task = context.tasks.FirstOrDefault(d => d.Id == id);

            return Ok(task);

        }

        [HttpGet]
        [Route("{Name}")]
        public async Task<IActionResult> getbyName(string Name)
        {

            Tasks tsk = context.tasks.FirstOrDefault(d => d.Name == Name);
            return Ok(tsk);

        }



        [HttpPost]
        public async Task<IActionResult> Create(Tasksdto tasksdto)
        {
            Tasks tasks = new Tasks();

            if (ModelState.IsValid)
            {
                tasks.Name = tasksdto.Name;
                tasks.Description = tasksdto.Description;
             
                tasks.Created = DateTime.Now.Date;
                tasks.End = tasksdto.End;
               

                itasksrepo.Create(tasks);
                return Ok(tasks);

            }
            else
            {
                return BadRequest("Please login to your account or register a new account, and verify the entered data.");
            }



        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(UpdateTaskdto taskss, int id)
        {
            // Tasks tasks1=new Tasks();
            // var updatee = itasksrepo.update(taskss,id);

            Tasks task2 = context.tasks.FirstOrDefault(t => t.Id == id);

            if (ModelState.IsValid)
            {
                if (task2 != null)
                {
                    task2.Name = taskss.Name;
                    task2.Description = taskss.Description;

                    itasksrepo.update(task2, id);
                    return Ok();
                }

                else
                {
                    return BadRequest("Please verify the data or login.");

                }

                //
                return BadRequest("Please verify the data or login.");




            }

            return BadRequest("Please verify the data or login.");


        }

        [HttpDelete("{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            var task = context.tasks.FirstOrDefault(t => t.Id == id);

            context.tasks.Remove(task);
            int raw = context.SaveChanges();

            return Ok(raw);



        }




    }
}
