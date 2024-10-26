using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public interface ITasksReposatry
    {

        public List<Tasks> getbyall();
        public Tasks getbyid(int id);
        public Tasks getbyName(string Name);
        public int Create(Tasks taskss);
        public int update(Tasks task, int id);
        public int Delete(int id);
    }
}
