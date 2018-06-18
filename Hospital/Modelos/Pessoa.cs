using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public interface Pessoa
    {
        [Required, StringLength(50)]
        string nome { get; set; }

        string endereco { get; set; }

        string dataNasc { get; set; }
    }
}
