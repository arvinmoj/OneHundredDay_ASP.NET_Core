using System.ComponentModel.DataAnnotations;

namespace My_Application.Models
{
    public class Login
    {
        public Login() : base()
        {
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "FullName")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Full Name Is Required !")]
        [StringLength(maximumLength: 50, MinimumLength = 5,
                      ErrorMessage = "Name should be minimum 5 characters and a maximum of 50 characters")]
        public string Fullname { get; set; }

        [Display(Name = "EmailAddress")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "EmailAddress Is Required !")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username Is Required !")]
        [StringLength(maximumLength: 50, MinimumLength = 5,
                      ErrorMessage = "Username should be minimum 5 characters and a maximum of 50 characters")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Is Required !")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [StringLength(maximumLength: 50, MinimumLength = 8,
                      ErrorMessage = "Password should be minimum 8 characters and a maximum of 50 characters")]
        public string Password { get; set; }
    }
}