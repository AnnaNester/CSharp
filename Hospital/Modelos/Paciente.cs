using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Paciente
    {
        [Key]
        public int PacienteID;
        public string Nome;
        public string CPF;
        public string DataNasc;
        public string Endereco;
    }
}
