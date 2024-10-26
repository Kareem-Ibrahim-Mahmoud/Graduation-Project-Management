using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Your_Graduation.Model
{
    public class Group
    {
               
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string joinlink { get; set; }

        
        [ForeignKey("doctor")]
        public int DoctortId { get; set; }
        public virtual Doctor doctor { get; set; }
        
        public virtual ICollection<Student> student { get; set; }

       
        public virtual Student studhead { get; set; }
        [ForeignKey("studhead")]
        public int idhead { get; set; }


    }
}
