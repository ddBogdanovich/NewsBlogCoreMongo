namespace NewsBlogCoreMongo.ViewModels.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class RegisterViewModel
    {
        [Display(Name = "UserName")] 
        [Required(ErrorMessage = "UserNameReuqired")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "EmailRequired")]
        [EmailAddress(ErrorMessage =  "InvalidEmail")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "PasswordRequired")]
        [StringLength(100, ErrorMessage = "PasswordLength", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessage = "PasswordCompare")]
        public string ConfirmPassword { get; set; }
    }
}