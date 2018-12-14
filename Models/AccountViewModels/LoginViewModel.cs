namespace NewsBlogCoreMongo.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required(ErrorMessage = "EmailRequired")]        
        [EmailAddress(ErrorMessage = "InvalidEmail")] 
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "PasswordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")] 
        public bool RememberMe { get; set; }
    }
}