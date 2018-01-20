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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class AddLivro : Window1
    {
        public AddLivro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=DESKTOP-6SPO3I6;Initial Catalog=Livroteca;Integrated Security=SSPI;")

            };

            string titulo, editora, quantidade;

            titulo = addTitulo.Text;
            editora = addEditora.Text;
            quantidade = addQuantidade.Text;

            if (addTitulo.Text == "" || addTitulo.Text == "" || addQuantidade.Text == "")
            {
                MessageBox.Show("Insira os seus dados nas caixas de texto.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            else
            {
                // Envia para o BD, os dados inseridos pelo usuario
                try
                {
                    Livro l = new Livro();
                    l.EnviarParaBD(titulo, editora, quantidade);
                    // Se apos os dados forem enviados com sucesso para o BD, a telaRegistro se fecha e a telaLogin abre novamente. (cadastrook é um "flag" que confirma se ocorreu tudo corretamente)
                    if (l.adicionarok == true)
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
