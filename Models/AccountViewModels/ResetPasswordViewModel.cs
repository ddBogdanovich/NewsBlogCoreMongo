namespace NewsBlogCoreMongo.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    public class ResetPasswordViewModel
    {
       // [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
      //  [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailRequired")]
     //   [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "InvalidEmail")]
        public string Email { get; set; }



     //   [Display(Name = "Password", ResourceType = typeof(Resources.Resource))]
      //  [StringLength(100, ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordLength", MinimumLength = 6)]
      //  [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [DataType(DataType.Password)]
     //   [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Resource))]
      //  [Compare("Password", ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "PasswordCompare")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}