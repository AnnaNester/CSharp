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
    /// Lógica interna para AlterarPaciente.xaml
    /// </summary>
    public partial class AlterarPaciente : Window
    {
        private static Paciente paciente;
        public AlterarPaciente(Paciente p)
        {
            InitializeComponent();
            paciente = p;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCPF.Text = paciente.CPF;
            txtDataNasc.Text = paciente.DataNasc;
            txtEndereco.Text = paciente.Endereco;
            txtNome.Text = paciente.Nome;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            paciente.CPF = txtCPF.Text;
            paciente.DataNasc = txtDataNasc.Text;
            paciente.Endereco = txtEndereco.Text;
            paciente.Nome = txtNome.Text;

            PacienteController pacienteController = new PacienteController();
            pacienteController.Atualizar(paciente);

            MessageBox.Show("Cadastro alterado com sucesso!!");
        }
    }
}
