using PucPocV1.Enums;
using System.ComponentModel.DataAnnotations;

namespace PucPocV1.ViewModels
{
    public class RegisterViewModel
    {
        // PERFIL DE USUARIO
        [Required(ErrorMessage = "Selecione se deseja se cadastrar como Mentor ou Mentorado")]
        public PerfilEnum? NivelAcesso { get; set; } 
        // NOME COMPLETO
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        // EMAIL DE CADASTRO
        [Required(ErrorMessage = "O Email é obrigatório.")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Informe um Email válido.")]
        public string Email { get; set; } = string.Empty;
        // SENHA
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = string.Empty;
        // CONFIRMAR SENHA
        [Required(ErrorMessage = "Confirme sua senha.")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; } = string.Empty;
        // DATA DE NASCIMENTO
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime? Data_Nasc { get; set; }
        // GENERO
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [StringLength(1)]
        public string Genero { get; set; } = string.Empty;
        // ESCOLARIDADE
        [Required(ErrorMessage = "A escolaridade é obrigatória.")]
        [StringLength(2)]
        public string Escolaridade { get; set; } = string.Empty;
    }
}
