using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Medico : Pessoa
    {
        [Key]
        int crm { get; set; }

        string especialidade { get; set; }
    }
}
