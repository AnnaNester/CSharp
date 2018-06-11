using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Pessoa
    {
        [Required]
        string nome { get; set; }

        string endereco { get; set; }

        string datanasc { get; set; }
    }
}
