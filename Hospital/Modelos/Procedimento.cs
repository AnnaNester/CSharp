namespace Modelos
{
    public interface Procedimento
    {
        int id { get; set; }

        string nome { get; set; }

        string horario { get; set; }

        string paciente { get; set; }

        string medico { get; set; }
    }
}
