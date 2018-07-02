using Controllers.DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class PacienteController
    {
        private Contexto contexto = new Contexto();
        public void Atualizar(Paciente paciente)
        {
            contexto.Entry(paciente).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Cadastrar(Paciente paciente)
        {
            contexto.Pacientes.Add(paciente);
            contexto.SaveChanges();
        }

        public void Excluir(Paciente paciente)
        {
            contexto.Entry(paciente).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }

        public IList<Paciente> ListarPorNomeCPF(string find)
        {
            return contexto.Pacientes.Where(a => a.Nome.ToLower().Contains(find.ToLower()) || a.CPF.Contains(find)).ToList();
        }

        public IList<Paciente> ListarTodos()
        {
            return contexto.Pacientes.ToList();
        }
    }
}
