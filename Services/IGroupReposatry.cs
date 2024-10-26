

using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public interface IGroupReposatry
    {
        public List<Group> groups();
        public Group getbyid(int id);
        public Group getbyName(string Name);
        public int Create(Group group);
        public int update(int id, Group group);
        public int Delete(int id);

    }
}
