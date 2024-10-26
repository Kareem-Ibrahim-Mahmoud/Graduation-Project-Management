using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Your_Graduation.Model
{
    public class Context : IdentityDbContext<ApplcationUser>
    {

        public Context()
        {

        }

        public Context(DbContextOptions<Context> optios) : base(optios)
        {

        }

        public DbSet<ApplcationUser> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Group> groups { get; set; }    
        public DbSet<Tasks> tasks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data source=.;Initial catalog=Your Graduation;Integrated security=true");
           // optionsBuilder.UseSqlServer($"Server=.;Database=Graduation;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);

           
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tasks>().HasOne(t => t.headteam);

            builder.Entity<Tasks>().HasOne(t => t.Student).WithMany(s=>s.tasks).OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Student>().HasMany(s => s.tasks);
            builder.Entity<Group>().HasMany(j => j.student).WithOne(s => s.group).OnDelete(DeleteBehavior.NoAction);
            
            base.OnModelCreating(builder);
        }

    }
}
