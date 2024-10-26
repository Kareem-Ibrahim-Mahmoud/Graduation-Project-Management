using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public class groupReposatry :IGroupReposatry
    {
        private Context context;

        public groupReposatry(Context _context)
        {
            context = _context;

        }

        public List<Group> groups()
        {
            return context.groups.ToList();

        }

        public Group getbyid(int id)
        {
            return context.groups.FirstOrDefault(g => g.Id == id);
        }

        public Group getbyName(string Name)
        {
           //  context.groups.FirstOrDefault(g => g.Name == Name);
            return context.groups.FirstOrDefault(g => g.Name == Name);
        }

        public int Create(Group group)
        {
            context.groups.Add(group);
            return context.SaveChanges();
        }

        public int update(int id,Group group)
        {
            Group groupupate=context.groups.FirstOrDefault(g => g.Id == id);
            groupupate.Id = id;
            groupupate.Name = group.Name;
            groupupate.Description = group.Description;
            groupupate.doctor = group.doctor;
            groupupate.student = group.student;

            int raw = context.SaveChanges();
            return raw;
        }

        public int Delete(int id)
        {
            Group group=context.groups.FirstOrDefault(g => g.Id == id);
            context.groups.Remove(group);
            int raw=context.SaveChanges();
            return raw;

        }


    }
}
