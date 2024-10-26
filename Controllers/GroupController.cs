using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Your_Graduation.DTO;
using Your_Graduation.Model;
using Your_Graduation.Services;

namespace Your_Graduation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {

        public IGroupReposatry igroup;
        public Context context;

        public GroupController(Context _context, IGroupReposatry _igroup)
        {
            context = _context;
            igroup = _igroup;
        }

        [HttpGet]

        public async Task<IActionResult> getbyall()
        {
          List<Group> groups = context.groups.ToList();
           return Ok(groups);

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getbyid(int id)
        {
            Group group = context.groups.FirstOrDefault(x => x.Id == id);
           return Ok(group);
        }

        [HttpGet]
        [Route("{Name}")]
        public async Task<IActionResult> getbyName(string name)
        {
            Group group = context.groups.FirstOrDefault(x => x.Name == name);
           return Ok(group);
        }

        [HttpPost]
        [Route("{CraeteGroup}")]

        public async Task<IActionResult> Create(Groupdto grodto)
        {
           //Group group = new Group();
           // if (ModelState.IsValid)
           // {
           //     group.Name = grodto.Name;
           //    group.Description = grodto.Description;
           //     group.joinlink = grodto.joinlink;
           //    group.student = grodto.student;
           //     group.DoctortId = grodto.DoctortId;
           //     //group.Id = group.Id;

           //     igroup.Create(group);

           //     return Ok();

           // }

           return BadRequest("Make sure the login process or the entered data is correct.");

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Group group, int id)
        {
            // Group gro=new Group();
            // var updatee = igroup.update(id,group);
            Group gr = context.groups.FirstOrDefault(x => x.Id == id);

            if (ModelState.IsValid)
            {
                if (gr != null)
                {
                    gr.Name = group.Name;
                    gr.Description = group.Description;

                    igroup.update(id, gr);

                    return Ok();
                }
            }
            return BadRequest("");



        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> delet(int id)
        {
            var gr = context.groups.FirstOrDefault(x => x.Id == id);
            context.groups.Remove(gr);
            int raw = context.SaveChanges();

            return Ok(raw);
        }



    }

}

