using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public interface IStudentReposatry
    {

        public List<Student> getAll();

        public Student getbyid(int id);

        public Student getbyName(string Name);

        public int Create(Student student);

        public int update(int id, Student student);

        public int Delete(int id);

    }
}
