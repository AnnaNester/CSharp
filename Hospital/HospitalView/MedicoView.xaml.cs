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
    /// Interaction logic for MedicoView.xaml
    /// </summary>
    public partial class MedicoView : Window
    {
        public MedicoView()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastrarMedico cadmed = new CadastrarMedico();
            cadmed.Show();
        }
    }
}
