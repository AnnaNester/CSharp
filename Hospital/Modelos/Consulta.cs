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

        public virtual Paciente paciente { get; set; }

        public virtual Medico medico { get; set; }

        public string medico_crm { get; set; }

        public string paciente_cpf { get;  set; }

    }
}
