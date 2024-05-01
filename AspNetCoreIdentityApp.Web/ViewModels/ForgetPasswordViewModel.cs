using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ForgetPasswordViewModel
    {
        public ForgetPasswordViewModel()
        {
            
        }
        public ForgetPasswordViewModel(string email)
        {
            Email = email;
        }
        [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Email formatı yanlış.")]
        [Display(Name = "Email :")]
        public string Email { get; set; }
    }
}
