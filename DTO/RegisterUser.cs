using System.ComponentModel.DataAnnotations;

namespace Your_Graduation.DTO
{
    public class RegisterUser
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "The field must be exactly 11 digits.")]
        public string PhoneNumber { get; set; }
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The field must be exactly 10 digits.")]
        public string Universitynumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
