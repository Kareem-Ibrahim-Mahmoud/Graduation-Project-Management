using System.ComponentModel.DataAnnotations.Schema;

namespace Your_Graduation.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /*
        [ForeignKey("Group")]
        public int Groupid { get; set; }
        public virtual Group Group { get; set; }
        */
        /*
        لو انا عاوز الدكتور يشارك اكتر من تيم 

         */
        public virtual ICollection<Group> Groups { get; set; }


    }
}
