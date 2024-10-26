using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public interface IDoctorReposatry
    {
        public List<Doctor> getbyAll();
        public Doctor getbyid(int id);
        public Doctor getbyName(string Name);
        public int Create(Doctor doctor);
        public int update(int id, Doctor doctor);
        public int Delete(int id);


    }
}
