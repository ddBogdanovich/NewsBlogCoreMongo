namespace NewsBlogCoreMongo.ViewModels.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class ForgotPasswordViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "EmailRequired")]
        [EmailAddress(ErrorMessage = "InvalidEmail")]
        public string Email { get; set; }
    }
}