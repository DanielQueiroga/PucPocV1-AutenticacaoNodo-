using System.ComponentModel.DataAnnotations;

namespace PucPocV1.ViewModels
{
    public class RegistrarMentorViewModel
    {

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme a senha.")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime? Data_Nasc { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [StringLength(1)]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A escolaridade é obrigatória.")]
        [StringLength(2)]
        public string Escolaridade { get; set; }

        //ID das áreas escolhidas pelo mentor
        public List<int> AreasSelecionadas { get; set; } = new();

        //ID das tecnologias escolhidas pelo mentor
        public List<int> TecnologiasSelecionadas { get; set; } = new();
    }
}
