using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for Medico.xaml
    /// </summary>
    public partial class MedicoView : Window
    {
        public MedicoView()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroMedico cadmed = new CadastroMedico();
            cadmed.Show();
        }
    }
}
