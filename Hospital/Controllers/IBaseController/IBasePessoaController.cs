using System.Collections.Generic;

namespace Controllers.IBaseController
{
    public interface IBaseController<T> where T: class
    {
        void Cadastrar(T entity);

        IList<T> ListarTodos();

        IList<T> ListarPorNome(string nome);

        void Atualizar(T entity);

        void Excluir(string chave);
    }
}
