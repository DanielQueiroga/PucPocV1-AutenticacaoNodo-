using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    // TABELA INTERMEDIARIA, POIS UM MENTOR PODE TER VARIAS AREAS DE CONHECIMENTO
    // Essa tabela serve praticamente como uma ponte entre Mentor e Área.

    [Table("MentorAreaConhecimento")]
    public class MentorAreaConhecimento
    {
        // ID registro
        [Key]
        public int ID { get; set; }

        //ID do Mentor
        public int ID_Mentor { get; set; }

        //Chave Estrangeira para Mentor
        [ForeignKey("ID_Mentor")]
        public Mentor Mentor { get; set; }

        //ID Area de Conhecimento
        public int ID_AreaConhecimento { get; set; }

        //CHave Estrangeira p Area de Conhecimento
        [ForeignKey("ID_AreaConhecimento")]
        public AreaConhecimento AreaConhecimento { get; set; }
    }
}
