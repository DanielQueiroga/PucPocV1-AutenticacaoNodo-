using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    [Table("AreaConhecimento")]
    public class AreaConhecimento
    {
        // Id Area de Conhecimento
        [Key]
        public int ID { get; set; }

        // Nome da Area
        [Required(ErrorMessage = "O nome da área é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
    }
}
