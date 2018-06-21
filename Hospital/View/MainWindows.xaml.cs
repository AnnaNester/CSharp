using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Paciente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Medico_Click(object sender, RoutedEventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
            
        }

        private void Consulta_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
