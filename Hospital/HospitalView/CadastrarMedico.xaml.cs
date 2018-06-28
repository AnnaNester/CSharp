using Controllers;
using Modelos;
using System;
using System.Windows;

namespace HospitalView
{
    /// <summary>
    /// Interaction logic for CadastrarMedico.xaml
    /// </summary>
    public partial class CadastrarMedico : Window
    {
        public CadastrarMedico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Medico medico = new Medico();
                medico.crm = txtCrm.Text;
                medico.nome = txtNome.Text;
                medico.endereco = txtEndereco.Text;
                medico.dataNasc = txtDataNasc.Text;
                medico.especialidadeMedico = txtEspecialidade.Text;

                 MedicoController MedicoController = new MedicoController();

                MedicoController.Cadastrar(medico);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar!" + "Erro: " + ex);
            }
        }
    }
}
