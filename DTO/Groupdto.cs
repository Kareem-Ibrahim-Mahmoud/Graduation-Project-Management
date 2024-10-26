using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Your_Graduation.Model;

namespace Your_Graduation.DTO
{
    public class Groupdto
    {
      //  public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string joinlink { get; set; }

        public int DoctortId { get; set; }
     

    }
}
