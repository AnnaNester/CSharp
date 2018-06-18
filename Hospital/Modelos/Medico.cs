using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Medico : Pessoa
    {
        public string dataNasc { get; set; }

        public string endereco { get; set; }

        [Required, StringLength(50)]
        public string nome { get; set; }

        [Key]
        public string crm { get; set; }

        [Required, StringLength(50)]
        public string especialidadeMedico { get; set; }
    }
}
