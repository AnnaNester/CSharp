using System.Collections.Generic;
using Modelos;
using Controllers.DAL;
using System.Linq;

namespace Controllers
{
    public class ConsultaController : IBaseController.IBaseProcedimentoController<Consulta>
    {
        private List<Consulta> listaConsultas { get; set; }

        private Contexto contexto = new Contexto();

        public void Atualizar(Consulta entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Cadastrar(Consulta entity)
        {
            contexto.Consultas.Add(entity);
            contexto.SaveChanges();
        }

        public Consulta BuscarPorID(int id)
        {
            return contexto.Consultas.Find();
        }


        public void Excluir(int id)
        {
            Consulta c = BuscarPorID(id);
            {
                if (c != null)
                {
                    contexto.Consultas.Remove(c);

                    contexto.SaveChanges();
                }
            }
        }

        public IList<Consulta> ListarPorMedico(Medico medico)
        {
            return contexto.Consultas.Where(m => m.medico.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Consulta> ListarPorNome(string nome)
        {
            return contexto.Consultas.Where(c => c.nome.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Consulta> ListarPorPaciente(Paciente paciente)
        {
            return contexto.Consultas.Where(p => p.paciente.ToLower() == nome.ToLower()).ToList();
        }

        public IList<Consulta> ListarTodos()
        {
            return listaConsultas;
        }

    }


}
