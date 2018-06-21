using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Consulta
    {
        public string horario { get; set; }

        [Key]
        public int id { get; set; }


        [Required, StringLength(30)]
        public string nome { get; set; }


        [Required]
        public string especialidade { get; set; }

        Paciente paciente { get; set; }

        Medico medico { get; set; }

        public int medicoID { get; set; }

        public int pacienteID { get;  set; }

    }
}
