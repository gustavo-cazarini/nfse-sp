using System.ComponentModel.DataAnnotations;

namespace nfsesp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha {  get; set; }
    }
}
