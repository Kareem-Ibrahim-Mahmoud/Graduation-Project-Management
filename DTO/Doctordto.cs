using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Your_Graduation.DTO
{
    public class Doctordto
    {
      
        [Required]
        public string Name { get; set; }
        /*
        [ForeignKey("Group")]
        public int Groupid { get; set; }
        public virtual Group Group { get; set; }
        */
        /*
        لو انا عاوز الدكتور يشارك اكتر من تيم 

         */
       
    }
}
