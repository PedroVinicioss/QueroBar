using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QueroBar.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool KeepLoggedIn { get; set; }

        public string? Error { get; set; }

    }
}
