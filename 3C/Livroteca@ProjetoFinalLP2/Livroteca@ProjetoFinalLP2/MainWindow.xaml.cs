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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Livroteca_ProjetoFinalLP2
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
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            Cadastro telaCadastro = new Cadastro();
            this.Close();
            telaCadastro.Show();

        }
        public static string usubd, senhabd;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string usu, senha;

                usu = loginUsu.Text;
                senha = loginSenha.Password;
                
                SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-6SPO3I6;Initial Catalog=Livroteca;Integrated Security=SSPI;");          
                // Procura no BD se o usuário e senha, existem.    
                SqlCommand verificar = new SqlCommand(@"SELECT
                                                      COUNT (*) FROM Cliente WHERE usu=@usu AND senha=@senha", conexao);
                verificar.Parameters.Clear();
                verificar.Parameters.AddWithValue("@usu", loginUsu.Text);
                verificar.Parameters.AddWithValue("@senha", loginSenha.Password);
                conexao.Open();
                // Se achar o usuário e senha, aparece um mensagem de "Bem-Vindo", a telaLogin se fecha e o Menu é aberto.
                if(verificar.ExecuteScalar().ToString()=="1")
                {
                   MessageBox.Show("Bem-Vindo à Livroteca, " + loginUsu.Text + "!", "Login", MessageBoxButton.OK, MessageBoxImage.Information);
                   Menu loginMenu = new Menu();
                   this.Close();
                   loginMenu.Show();
                }
                else
                {
                    // Se as caixas de texto do Usuário e Senha estiverem vazias, apresenta a mensagem abaixo. As caixa de texto são apagadas para o usuário não ter que apagar manualmente.
                    if (loginUsu.Text == "" || loginSenha.Password == "")
                    {
                        MessageBox.Show("Insira os suas credenciais para entrar no sistema", "Erro no Login", MessageBoxButton.OK, MessageBoxImage.Error);
                        loginUsu.Clear();
                        loginSenha.Clear();
                    }
                    else
                    {
                        // Se as credenciais digitadas pelo usuário estiverem incorretas, a mensagem abaixo aparecerá. As caixa de texto são apagadas para o usuário não ter que apagar manualmente.
                        MessageBox.Show("Suas credenciais estão incorretas. Por favor verifique-as.", "Erro no Login", MessageBoxButton.OK, MessageBoxImage.Error);
                        loginUsu.Clear();
                        loginSenha.Clear();
                    }               
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
