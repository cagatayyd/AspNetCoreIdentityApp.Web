using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class PasswordChangeViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]
        [Display(Name = "Şifreniz :")]
        [MinLength(6,ErrorMessage="Şifreniz en az 6 karakterli olabilir.")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz.")]
        [Display(Name = "Yeni şifre :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakterli olabilir.")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "Girmiş olduğunuz şifreler eşleşmiyor.")]
        [Required(ErrorMessage = "Yeni şifre doğrulama alanı boş bırakılamaz.")]
        [Display(Name = "Yeni şifre tekrar :")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakterli olabilir.")]
        public string ConfirmNewPassword { get; set;}
    }
}
