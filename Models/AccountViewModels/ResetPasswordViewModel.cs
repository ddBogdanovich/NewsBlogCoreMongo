namespace NewsBlogCoreMongo.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class ResetPasswordViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "EmailRequired")]
        [EmailAddress(ErrorMessage = "InvalidEmail")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "PasswordLength", MinimumLength = 6)]
        [Required(ErrorMessage = "PasswordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessage = "PasswordCompare")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}