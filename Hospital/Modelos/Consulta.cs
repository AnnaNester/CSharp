using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Consulta : Procedimento
    {
        public string horario { get; set; }

        [Key]
        public int id { get; set; }

        [Required]
        public string medico { get; set; }

        [Required, StringLength(30)]
        public string nome { get; set; }

        [Required]
        public string paciente { get; set; }

        [Required]
        public string especialidade { get; set; }
    }
}
