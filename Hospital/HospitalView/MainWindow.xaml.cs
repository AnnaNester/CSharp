using System.Windows;

namespace HospitalView
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

        private void btnMedico_Click(object sender, RoutedEventArgs e)
        {
            MedicoView medico = new MedicoView();
            medico.Show();
        }
    }
}
