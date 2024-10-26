using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public class DoctorReposatry : IDoctorReposatry
    {
        private Context context;

        public DoctorReposatry(Context _context)
        {
            context = _context;
        }

        public List<Doctor> getbyAll()
        {
            return context.Doctors.ToList();
        }

        public Doctor getbyid(int id)
        {
            return context.Doctors.FirstOrDefault(s => s.Id == id);
        }

        public Doctor getbyName(string Name)
        {
            return context.Doctors.FirstOrDefault(s=>s.Name == Name);

        }

        public int Create(Doctor doctor)
        {
            context.Doctors.Add(doctor);
            return context.SaveChanges();
        }


        public int update(int id,Doctor doctor)
        {
            Doctor doctorupdate=context.Doctors.FirstOrDefault(s => s.Id == id);

            doctorupdate.Id = id;
            doctorupdate.Name = doctor.Name;
            doctorupdate.Groups = doctor.Groups;
            int raw=context.SaveChanges();
            return raw;
        }

        public int Delete(int id)
        {
            Doctor doctor = context.Doctors.FirstOrDefault(s => s.Id == id);
            context.Doctors.Remove(doctor);
            int raw=context.SaveChanges();
            return raw;

        }
    }
}
