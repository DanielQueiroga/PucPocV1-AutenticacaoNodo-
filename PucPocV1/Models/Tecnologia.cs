using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    [Table("Tecnologia")]
    public class Tecnologia
    {
        // ID da Tecnologia
        [Key]
        public int ID { get; set; }

        // Nome da Tecnologia
        [Required(ErrorMessage = "O nome da tecnologia é obrigaróio.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
    }
}
