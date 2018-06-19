namespace Modelos
{
    public interface Procedimento
    {
        int id { get; set; }

        string nome { get; set; }

        string horario { get; set; }

        Paciente paciente { get; set; }

        Medico medico { get; set; }
    }
}
