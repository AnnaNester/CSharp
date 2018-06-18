using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Medico : Pessoa
    {
        public string dataNasc { get; set; }

        public string endereco { get; set; }

        [Required, MaxLength(50)]
        public string nome { get; set; }

        [Key]
        string crm { get; set; }

        [Required, MaxLength(50)]
        string especialidadeMedico { get; set; }
    }
}
