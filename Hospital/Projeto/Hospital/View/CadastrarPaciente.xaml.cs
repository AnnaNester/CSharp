using System.Windows;
using Controllers;
using Hospital;
using Modelos;

namespace HospitalView
{
    /// <summary>
    /// Lógica interna para CadastrarPaciente.xaml
    /// </summary>
    public partial class CadastrarPaciente : Window
    {
        public CadastrarPaciente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if(txtNome.Text.Length == 0 || txtCPF.Text.Length == 0 || txtDataNasc.Text.Length == 0 || txtEndereco.Text.Length == 0)
            {
                MessageBox.Show("Você deve preencher todos os campos!!");
                return;
            }
            PacienteController pacienteController = new PacienteController();
            Paciente paciente = new Paciente();

            paciente.Nome = txtNome.Text;
            paciente.CPF = txtCPF.Text;
            paciente.DataNasc = txtDataNasc.Text;
            paciente.Endereco = txtEndereco.Text;

            pacienteController.Cadastrar(paciente);

            MessageBox.Show("Paciente cadastrado com sucesso.");

            MainWindow tela = new MainWindow();
            tela.Show();
            Close();
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deseja voltar a tela inicial?", "Sair", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                MainWindow tela = new MainWindow();
                tela.Show();
                Close();
            }
        }
    }
}
