using System.ComponentModel.DataAnnotations;

namespace NewsBlogCoreMongo.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
      //  [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
       // [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailRequired")]
      //  [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "InvalidEmail")]
        public string Email { get; set; }
    }
}