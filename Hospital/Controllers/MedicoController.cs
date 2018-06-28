using Controllers.IBaseController;
using Modelos;
using System.Collections.Generic;
using Controllers.DAL;
using System.Linq;

namespace Controllers
{
    public class MedicoController : IBaseController<Medico>
    {
        private List<Medico> listaMedicos { get; set; }

        private Contexto contexto = new Contexto();

        public void Atualizar(Medico entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Cadastrar(Medico entity)
        {
            contexto.Medicos.Add(entity);
            contexto.SaveChanges();
        }

        public Medico BuscarPorCrm(string chave)
        {
            return contexto.Medicos.FirstOrDefault(m => m.crm == chave);
        }

        public void Excluir(Medico medico)
        {
            contexto.Medicos.Remove(medico);
            contexto.SaveChanges();
        }

        public IList<Medico> ListarPorNome(string nome)
        {
            return contexto.Medicos.Where(a => a.nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Medico> ListarTodos()
        {
            return listaMedicos;
        }

        public IList<Medico> ListarPorEspecialidade (string especialidade)
        {
            return contexto.Medicos.Where(e => e.especialidadeMedico.ToLower() == especialidade.ToLower()).ToList();
        }


    }
}
