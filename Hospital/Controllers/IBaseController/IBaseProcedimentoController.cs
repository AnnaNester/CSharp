using Modelos;
using System.Collections.Generic;

namespace Controllers.IBaseController
{
    public interface IBaseProcedimentoController<T> where T:class
    {
        void Cadastrar (T entity);

        IList<T> ListarTodos();

        IList<T> ListarPorNome (string nome);

        IList<T> ListarPorPaciente (string chave);

        IList<T> ListarPorMedico(string chave);

       T BuscarPorID(int id);

        void Atualizar (T entity);

        void Excluir (int id);
    }
}
