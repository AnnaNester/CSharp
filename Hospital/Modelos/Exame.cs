using System;

namespace Modelos
{
    class Exame : Procedimento
    {
        public string horario { get; set; }

        public int id { get; set; }

        public string medico { get; set; }

        public string nome { get; set; }

        public string paciente { get; set; }
    }
}
