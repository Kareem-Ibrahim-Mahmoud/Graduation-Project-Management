using System.ComponentModel.DataAnnotations;

namespace Your_Graduation.DTO
{
    public class UpdateTaskdto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
