using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    [Table("Pacientes")]
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
    }
}
