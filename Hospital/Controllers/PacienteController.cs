using Controllers.DAL;
using Controllers.IBaseController;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PacienteController : IBaseController<Paciente>
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Paciente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Cadastrar(Paciente entity)
        {
            contexto.Pacientes.Add(entity);
            contexto.SaveChanges();
        }

        public void Excluir(Paciente entity)
        {
            contexto.Pacientes.Remove(entity);
            contexto.SaveChanges();
        }

        public IList<Paciente> ListarPorNome(string nome)
        {
            return contexto.Pacientes.Where(a => a.Nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Paciente> ListarPorCPF(string cpf)
        {
            return contexto.Pacientes.Where(a => a.CPF == cpf).ToList();
        }

        public IList<Paciente> ListarTodos()
        {
            return contexto.Pacientes.ToList();
        }
    }
}
