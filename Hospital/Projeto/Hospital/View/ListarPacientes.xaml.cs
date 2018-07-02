using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalView
{
    /// <summary>
    /// Lógica interna para ListarPacientesPorNome.xaml
    /// </summary>
    public partial class ListarPacientes : Window
    {
        public ListarPacientes()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            Paciente paciente = (Paciente)GridPacientes.Items[GridPacientes.SelectedIndex];
            if (paciente.PacienteID > 0)
            {
                AlterarPaciente tela = new AlterarPaciente(paciente);
                tela.Show();
            }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Paciente paciente = (Paciente)GridPacientes.Items[GridPacientes.SelectedIndex];
            if (paciente.PacienteID > 0)
            {
                PacienteController pacienteController = new PacienteController();
                pacienteController.Excluir(paciente);
                MessageBox.Show("Paciente excluído com sucesso!!");
            }
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            if(txtFiltro.Text.Length == 0)
            {
                MessageBox.Show("Digite o que deseja filtrar!!");
                return;
            }
        }

        private void ExibirItens(string filtro)
        {
            PacienteController pacienteController = new PacienteController();
            if (filtro.Length == 0) GridPacientes.ItemsSource = pacienteController.ListarTodos();
            else GridPacientes.ItemsSource = pacienteController.ListarPorNomeCPF(filtro);
        }
    }
}
