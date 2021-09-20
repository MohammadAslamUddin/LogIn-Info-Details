using System.ComponentModel.DataAnnotations;

namespace LogInInfoDetails.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "You must enter the Email")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email should be valid")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "You must enter a password")]
        //[RegularExpression(@"^(?=.[a-z])(?=.[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Minimum eight characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Choose One")]
        [Display(Name = "LogIn As")]
        public int LogInAs { get; set; }
    }
}