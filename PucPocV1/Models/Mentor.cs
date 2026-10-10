using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PucPocV1.Models
{
    [Table("Mentor")]
    public class Mentor
    {
        //ID do Mentor
        [Key]
        public int ID { get; set; }
        //ID do Usuario Relacionado
        public int ID_Usuario { get; set; }
        // Associando ID Usuario a chave estrangeira
        [ForeignKey("ID_Usuario")]
        public Usuario Usuario { get; set; }

    }
}
