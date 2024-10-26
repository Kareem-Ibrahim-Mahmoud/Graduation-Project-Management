using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public class StudentReposatry : IStudentReposatry
    {
        private Context context;
        public StudentReposatry(Context _context)
        {
            context = _context;

        }

        public List<Student> getAll()
        {
            return context.Students.ToList();   
        }

        public Student getbyid(int id)
        {
            return context.Students.FirstOrDefault(s=>s.Id == id);
        }
        public Student getbyName(string Name)
        {
            return context.Students.FirstOrDefault(s=>s.Name == Name);

        }

        public int Create(Student student)
        {
            context.Students.Add(student);
            return context.SaveChanges();


        }

        public int update(int id,Student student)
        {
            Student studentToUpdate = context.Students.FirstOrDefault(s=>s.Id == id);
            studentToUpdate.Name=student.Name;
            studentToUpdate.PhoneNumber=student.PhoneNumber;
            studentToUpdate.universtyNumber = student.universtyNumber;
           // studentToUpdate.group=student.group;
            studentToUpdate.tasks=student.tasks;
            studentToUpdate.idGroup=student.idGroup;

            int raw=context.SaveChanges();

            return raw;


        }

        public int Delete(int id)
        {
            Student student=context.Students.FirstOrDefault(s=>s.Id == id);
            context.Students.Remove(student);
            int raw= context.SaveChanges();
            return raw;


        }

    }
}
