using System;
using Controllers.IBaseController;
using Modelos;

namespace Controllers
{
    public class MedicoController : IBaseController<Medico>
    {
        public void Atualizar(Medico entity)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Medico entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string chave)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IList<Medico> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IList<Medico> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
