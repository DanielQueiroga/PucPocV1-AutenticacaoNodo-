using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    [Table("Mentorado")]
    public class Mentorado
    {
        [Key]
        public int ID { get; set; }

        // ID Usuario Relacionado
        public int ID_Usuario { get; set; }

        // Chave Estrangeira para Usuario
        [ForeignKey("ID_Usuario")]
        public Usuario Usuario { get; set; } 

    }
}
