using Controllers;
using Hospital;
using Modelos;
using System;
using System.Windows;

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
            try
            {
                Paciente paciente = (Paciente)GridPacientes.Items[GridPacientes.SelectedIndex];
                if (paciente.PacienteID > 0)
                {
                    AlterarPaciente tela = new AlterarPaciente(paciente);
                    tela.Show();
                    Close();
                }
            }
            catch { }
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Paciente paciente = (Paciente)GridPacientes.Items[GridPacientes.SelectedIndex];
                if (paciente.PacienteID > 0)
                {
                    PacienteController pacienteController = new PacienteController();
                    pacienteController.Excluir(paciente);
                    MessageBox.Show("Paciente excluído com sucesso!!");
                    ExibirPacientes("");
                }
            }
            catch { }
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            if(txtFiltro.Text.Length == 0)
            {
                MessageBox.Show("Digite o que deseja filtrar!!");
                return;
            }
            ExibirPacientes(txtFiltro.Text);
        }

        private void ExibirPacientes(string filtro)
        {
            PacienteController pacienteController = new PacienteController();
            if (filtro.Length == 0) GridPacientes.ItemsSource = pacienteController.ListarTodos();
            else GridPacientes.ItemsSource = pacienteController.ListarPorNomeCPF(filtro);

            GridPacientes.Columns[0].Visibility = Visibility.Hidden;

            try
            {
                for(int tela = 0; tela < 5; tela++) GridPacientes.Columns[tela].IsReadOnly = true;
            }
            catch { }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ExibirPacientes("");
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tela = new MainWindow();
            tela.Show();
            Close();
        }
    }
}
