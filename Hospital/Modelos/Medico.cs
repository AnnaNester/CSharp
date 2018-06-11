using System;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Medico : Pessoa
    {
        public string dataNasc { get; set; }

        public string endereco { get; set; }

        public string nome { get; set; }

        [Key]
        int crm { get; set; }

        string especialidadeMedico { get; set; }
    }
}
