using Your_Graduation.Model;

namespace Your_Graduation.Services
{
    public class TaskRebosatry :ITasksReposatry
    {

        private Context context;

        public TaskRebosatry(Context _context)
        {
            context = _context;
        }
        
        
        public List<Tasks> getbyall()
        {
            return context.tasks.ToList();

        }

        public Tasks getbyid(int id)
        {
            return context.tasks.FirstOrDefault(x => x.Id == id);
        }
        public Tasks getbyName(string Name)
        {
            return context.tasks.FirstOrDefault(t=>t.Name == Name);
        }

        public int Create(Tasks taskss)
        {
            context.tasks.Add(taskss);
            return context.SaveChanges();
        }

        
        public int update(Tasks task, int id)
        {
            Tasks tasks = context.tasks.FirstOrDefault(x => x.Id == id);

            tasks.Name = task.Name;
           
            tasks.Description = task.Description;
            /*
            tasks.headteam = task.headteam;
            tasks.StudentId = task.StudentId;
            tasks.headteamid = task.headteamid;
            tasks.Created =DateTime.Now;
            tasks.End = task.End;
            */
            int raw=context.SaveChanges();
            return raw;
            
        }
    
    

        public int Delete(int id)
        {
            Tasks tasks=context.tasks.FirstOrDefault(x => x.Id == id);
            context.tasks.Remove(tasks);
            int raw=context.SaveChanges();
            return raw;

        }






        


       

    }
}
