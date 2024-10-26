using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Your_Graduation.Model;

namespace Your_Graduation.DTO
{
    public class Tasksdto
    {
      
       // public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Created { get; set; }//*
        public DateTime End { get; set; }

      
       

    }
}
