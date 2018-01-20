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
using System.Data.SqlClient;

namespace Livroteca_ProjetoFinalLP2
{
    /// <summary>
    /// Interaction logic for Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            // String de conexao com o BD
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=DESKTOP-6SPO3I6;Initial Catalog=Livroteca;Integrated Security=SSPI;")

            };
            // Pega o conteudo das caixas de texto, é como se fosse um Console.ReadLine();
            string usu, senha, nome, rg, mail, nasc, endereco, cpf;
            
            usu = registroUser.Text;
            senha = registroSenha.Password;
            nome = registroNome.Text;
            rg = registroRG.Text;
            mail = registroMail.Text;
            nasc = registroNasc.Text;
            endereco = registroEnd.Text;
            cpf = registroCPF.Text;
            // Verifica se as caixas de texto estão em branco
            if (registroUser.Text == "" || registroSenha.Password == "" || registroNome.Text == "" || registroRG.Text == "" || registroMail.Text == "" || registroNasc.Text == "" || registroEnd.Text == "" || registroCPF.Text == "")
            {
                MessageBox.Show("Insira os seus dados nas caixas de texto.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                // Envia para o BD, os dados inseridos pelo usuario
                try
                {
                    DadosClientes d = new DadosClientes();
                    d.EnviarParaBD(usu, nasc, nome, rg, mail, senha, endereco, cpf);
                    // Se apos os dados forem enviados com sucesso para o BD, a telaRegistro se fecha e a telaLogin abre novamente. (cadastrook é um "flag" que confirma se ocorreu tudo corretamente)
                    if (d.cadastrook == true)
                    {
                        MainWindow telaLogin = new MainWindow();
                        this.Close();
                        telaLogin.Show();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Ocorreu um erro ao enviar seus dados para o servidor, por favor verificar os dados inseridos. ", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }     
        }
    }
}