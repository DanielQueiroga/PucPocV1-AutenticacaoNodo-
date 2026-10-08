using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PucPocV1.Enums;

namespace PucPocV1.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        // ID USUÁRIO (CHAVE PRIMARIA)
        [Key]
        public int ID { get; set; }
        // NIVEL DE ACESSO
        public PerfilEnum NivelAcesso { get; set; }
        // NOME
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        //EMAIL
        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Infome um email válido.")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        // SENHA
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(255)]
        public string Senha { get; set; } = string.Empty;
        // DATA DE NASCIMENTO
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime Data_Nasc { get; set; }
        // GENERO
        [Required(ErrorMessage = "O gênero é obrigatório.")]
        [StringLength(1)]
        public string Genero { get; set; } = string.Empty;
        // ESCOLARIDADE
        [Required(ErrorMessage = "A escolaridade é obrigatória.")]
        [StringLength(2)]
        public string Escolaridade { get; set; } = string.Empty;
        // ATIVO NA AREA
        [Required]
        [StringLength(1)]
        public string Ativo_Area { get; set; } = string.Empty;
        // DATETIME DA CRIACAO
        public DateTime Criacao { get; set; }


    }
}
