using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    [Table("MentorTecnologia")]
    public class MentorTecnologia
    {
        [Key]
        public int ID { get; set; }

        // ID do Mentor
        public int ID_Mentor { get; set; }

        // Chave Estrangeira para Mentor
        [ForeignKey("ID_Mentor")]
        public Mentor Mentor { get; set; }

        // ID da Tecnologia
        public int ID_Tecnologia { get; set; }

        // Chave Estrangeira para Tecnologia
        [ForeignKey("ID_Tecnologia")]
        public Tecnologia Tecnologia { get; set; }
    }
}
