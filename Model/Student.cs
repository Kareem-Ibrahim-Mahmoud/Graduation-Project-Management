using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Your_Graduation.Model
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string universtyNumber { get; set; }




         public virtual ICollection<Tasks> tasks{ get; set; }



        [ForeignKey("group")]
        public int idGroup { get; set; }
        public virtual Group group { get; set; }
        
       // public virtual ICollection<Group> Groups { get; set; }

    }
}
