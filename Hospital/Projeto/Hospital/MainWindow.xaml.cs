using HospitalView;
using System.Windows;

namespace Hospital
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarPaciente tela = new CadastrarPaciente();
            tela.Show();
            Close();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListarPacientes tela = new ListarPacientes();
            tela.Show();
            Close();
        }
    }
}
