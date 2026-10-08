using System.ComponentModel.DataAnnotations;

namespace PucPocV1.ViewModels
{
    public class LoginViewModel
    {
        // PREENCHER COM EMAIL
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string Email { get; set; } = string.Empty;

        // PREENCHER SENHA
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
